using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;


namespace RepoLayer.Repo
{
    public class BaseRepo<T> 
    {
        string connetionString;
        SqlConnection connection = null;
        public BaseRepo()
        {
            

        }
        private IDbConnection CRUD()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            connetionString = root.GetConnectionString("DefaultConnection");
            IDbConnection connection;
            connection = new SqlConnection(connetionString);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLServer);

            connection.Open();
            return connection;
        }

        public T GetItemById(int Id)
        {
            var Worker = CRUD();
            var result = Worker.Get<T>(Id);
            Worker.Close();
            return result;
        }
        public IEnumerable<T> GetItemFiltered(object Filtered)
        {
            var Worker = CRUD();
            var result = Worker.GetList<T>(Filtered);
            Worker.Close();
            return result;
        }   
        public T FindItem(object Filtered)
        {
            var Worker = CRUD();
            var result = Worker.GetList<T>(Filtered);
            Worker.Close();
            return result.FirstOrDefault();
        }
        public IEnumerable<T> GetSql(string Filtered)
        {
            var Worker = CRUD();
            var result = Worker.Query<T>(Filtered);
            Worker.Close();
            return result;
        }

        public IEnumerable<T> GetItemsById(int Id)
        {
            var Worker = CRUD();
            var result = Worker.GetList<T>(Id);
            Worker.Close();
            return result;
        }

        public IEnumerable<T> GetItems()
        {
            var Worker = CRUD();
            var result = Worker.GetList<T>();
            Worker.Close();
            return result;
        }

        public static object GetPropValue(object src, string propName)
        {
            var value = src.GetType().GetProperty(propName).GetValue(src, null);
            return value;
        }
        public T SaveItem(T item)
        {
            int Id = 0;
            var Worker = CRUD();
            if (GetPropValue(item, "Id") == null || int.Parse(GetPropValue(item, "Id").ToString()) == 0)
            {
                Id = (int)Worker.Insert(item);
            }
            else
            {
                Worker.Update(item);
                Id = int.Parse(GetPropValue(item, "Id").ToString());
            }
            var result = Worker.Get<T>(Id);
            Worker.Close();
            return result;
        }
    }
}
