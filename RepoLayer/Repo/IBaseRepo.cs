using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoLayer.Repo
{
    public interface IBaseRepo<T>
    {
        IEnumerable<T> FindItems<T1>(object paramters = null);
        T FindItem<T1>(object paramters = null);
        T GetItemById<T1>(int id);
        T SaveItem(object paramters = null);
    }
}
