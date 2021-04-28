using Akavache;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Cache
{
    public class CacheService
    {
        public async void CacheData(object Object, string CacheName)
        {
            //try
            //{
            //    App.Current.Properties[CacheName] = null;
            //}
            //catch (Exception)
            //{
            //}
            //App.Current.Properties[CacheName] = JsonConvert.SerializeObject(Object);
            //App.Current.SavePropertiesAsync();
            try
            {
                await BlobCache.UserAccount.Invalidate(CacheName);
            }
            catch (Exception)
            {
            }
            try
            {
                await BlobCache
              .UserAccount
              .InsertObject(CacheName, JsonConvert.SerializeObject(Object));
            }
            catch (Exception)
            {

            }
      
        }
        public async void DeleteCacheDataAsyncByDataName(string DataName)
        {
            try
            {
                await BlobCache.UserAccount.Invalidate(DataName);
            }
            catch (Exception)
            {
            }
        }

        public async Task<string> GetCacheDataAsync(string DataName)
        {
            try
            {
                return await BlobCache.UserAccount.GetObject<string>(DataName);/*App.Current.Properties[DataName].ToString();*/
            }
            catch (Exception)
            {

                return string.Empty;
            }


        }

    }
}
