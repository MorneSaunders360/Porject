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
    public class BaseRepo<T> : IBaseRepo<T>
    {
        string connetionString;
        public BaseRepo()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            connetionString = root.GetConnectionString("DefaultConnection");
        }
        public string BuildParamters(object Inputparamters)
        {
            var json = JsonConvert.SerializeObject(Inputparamters);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            var paramters = new List<string>();
            foreach (var item in dictionary)
            {
                paramters.Add(item.Key + "=" + "'" + item.Value + "'");
            }
            return string.Join(" AND ", paramters);


        }
        public string BuildUpdate(Dictionary<string, string> dictionary)
        {
            string Update = "";
            foreach (var item in dictionary)
            {
                Update += item.Key + "=" + item.Value + ",";
            }
            Update = Update.Remove(Update.Length - 1);
            return Update;
        }
        private string BuildModelQuerry(object model)
        {
            string ModelParm = "";
            string ModelValues = "(";
            string ModelId = "";
            int ModelIdValue = 0;
            var dictionaryUpdate = new Dictionary<string, string>();
            var convertedObject = Convert.ChangeType(model, model.GetType());
            var FromProps = convertedObject.GetType().GetProperties();
            int counter = 0;
            foreach (var prop in FromProps)
            {
                if (counter != 0)
                {
                    if (prop.PropertyType == typeof(string) || prop.PropertyType == typeof(int) || prop.PropertyType == typeof(decimal) || prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(DateTime))
                    {
                        if (prop.GetValue(convertedObject, null) != null)
                        {
                            ModelParm += prop.Name + ",";
                            ModelValues += "'" + prop.GetValue(convertedObject, null).ToString() + "'" + ",";

                            dictionaryUpdate.Add(prop.Name, "'" + prop.GetValue(convertedObject, null).ToString() + "'");
                        }

                    }
                    else
                    {
                        if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                        {
                            ModelParm += prop.Name + ",";
                            ModelValues += "NULL" + ",";
                        }


                    }

                }
                else
                {
                    ModelIdValue = int.Parse(prop.GetValue(convertedObject, null).ToString());
                    ModelId = prop.Name;
                }

                counter++;

            }
            ModelParm = ModelParm.Remove(ModelParm.Length - 1);
            ModelValues = ModelValues.Remove(ModelValues.Length - 1);
            ModelValues += ")";

            string queryString = "";
            if (ModelIdValue == 0)
            {
                queryString =
                    "BEGIN TRANSACTION " + model.GetType().Name +
                    " BEGIN TRY" +
                    " INSERT INTO [dbo]." + model.GetType().Name + $"({ModelParm})"
                     + "VALUES" + ModelValues
                     + " Select * from  [dbo]." + model.GetType().Name + " Where " + ModelId + "= SCOPE_IDENTITY()"
                     + " COMMIT TRANSACTION " + model.GetType().Name
                     + " END TRY "
                     + " BEGIN CATCH "
                     + " ROLLBACK TRANSACTION " + model.GetType().Name
                     + " END CATCH ";

            }
            else
            {
                queryString =
                            "BEGIN TRANSACTION " + model.GetType().Name +
                            " BEGIN TRY " +
                            " UPDATE [dbo]." + model.GetType().Name +
                            " SET " + BuildUpdate(dictionaryUpdate) +
                            "Where " + ModelId + "= " + ModelIdValue
                            + " Select * from  [dbo]." + model.GetType().Name + " Where " + ModelId + "= " + ModelIdValue
                            + " COMMIT TRANSACTION " + model.GetType().Name
                            + " END TRY "
                            + " BEGIN CATCH "
                            + " ROLLBACK TRANSACTION " + model.GetType().Name
                            + " END CATCH ";
            }

            return queryString;
        }

        public T FindItem<T1>(object paramters = null)
        {
            string queryString = "";
            if (paramters != null)
            {
                queryString = "SELECT * FROM [dbo]." + typeof(T1).Name + " Where " + BuildParamters(paramters);
            }
            else
                queryString = "SELECT * FROM [dbo]." + typeof(T1).Name;

            var connection = new SqlConnection(connetionString);
            connection.Open();
            var result = connection.Query<T>(queryString).FirstOrDefault();
            connection.Close();
            return result;
        }

        public IEnumerable<T> FindItems<T1>(object paramters = null)
        {
            string queryString = "";
            if (paramters != null)
            {
                queryString = "SELECT * FROM [dbo]." + typeof(T1).Name + " Where " + BuildParamters(paramters);
            }
            else
                queryString = "SELECT * FROM [dbo]." + typeof(T1).Name;

            var connection = new SqlConnection(connetionString);

            connection.Open();
            var result = connection.Query<T>(queryString).ToList();
            connection.Close();

            return result;
        }

        public T SaveItem(object model)
        {
            string queryString = BuildModelQuerry(model);

            var connection = new SqlConnection(connetionString);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var result = connection.Query<T>(queryString).FirstOrDefault();
            connection.Close();
            return result;
        }

        public T GetItemById<T1>(int id)
        {
            string queryString = "";
            queryString = "SELECT * FROM [dbo]." + typeof(T1).Name + " Where " + typeof(T1).Name + "Id = " + id;
            var connection = new SqlConnection(connetionString);
            connection.Open();
            var result = connection.Query<T>(queryString).FirstOrDefault();
            connection.Close();
            return result;
        }
    }
}
