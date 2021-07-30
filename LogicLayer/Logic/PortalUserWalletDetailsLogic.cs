using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public class PortalUserWalletDetailsLogic : Baselogic<Entities.Models.PortalUserWalletDetails>
    {
        public List<Entities.Models.Temp.PortalCurrencyTickerDetail> CurrencyTickerDetailList = new List<Entities.Models.Temp.PortalCurrencyTickerDetail>();
        public PortalUserWalletDetailsLogic()
        {

        }
        public List<Entities.Models.PortalUserWalletDetails> GetPortalUserWalletDetailsByPortalUserId(int PortalUserId) 
        {
            string qurrey = @$"
                       	EXEC [PortalUserWalletDetailProc] {PortalUserId}

                          ";
            var PortalUserWalletDetails = base.PortalUserWalletDetailsRepo.GetSql(qurrey).ToList();
            return PortalUserWalletDetails;
        }
        public Entities.Models.PortalUserWalletDetails SaveItem(Entities.Models.PortalUserWalletDetails model)
        {
            var PortalUserWalletDetails = base.PortalUserWalletDetailsRepo.SaveItem(model);
            return PortalUserWalletDetails;
        }
        public async Task<string> TimeAsync()
        {
            var client = new HttpClient();
            var results = await client.GetAsync("https://www.okex.com/api/general/v3/time");
            var model = JsonConvert.DeserializeObject<Entities.Models.Temp.PortalTimeClass>(results.Content.ReadAsStringAsync().Result);
            return model.iso;

        }
        public static async Task<double> CurrencyConverted()
        {
            var client = new HttpClient();
            var results = await client.GetAsync("https://free.currconv.com/api/v7/convert?q=USD_ZAR&compact=ultra&apiKey=3489ad7456fe2cbe34b4");
            var model = JsonConvert.DeserializeObject<Entities.Models.Temp.PortalCurrencyConverted>(results.Content.ReadAsStringAsync().Result);
            return model.USD_ZAR;

        }
        public static string generateHash(string str, string cypherkey)
        {
            // based on CryptoJS.enc.Base64.parse
            byte[] keyBytes = System.Convert.FromBase64String(cypherkey);

            using (var hmacsha256 = new HMACSHA256(keyBytes))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
                return Convert.ToBase64String(hashmessage);
            }
        }
        public async Task GetAccountAssestToUSD()
        {
            var date = TimeAsync().Result;

            String client_secret = Convert.ToBase64String(Encoding.UTF8.GetBytes("1BB0A2956173C6402CC5B1B0F0DB0B64"));
            var rr = generateHash(date + "GET" + "/api/v5/market/tickers?instType=SPOT", client_secret);
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("OK-ACCESS-KEY", "4b6d4a63-d764-400f-b652-ddada894afe4");
            client.DefaultRequestHeaders.Add("OK-ACCESS-SIGN", rr);
            client.DefaultRequestHeaders.Add("OK-ACCESS-TIMESTAMP", date);
            client.DefaultRequestHeaders.Add("OK-ACCESS-PASSPHRASE", "CEXt2YzUhv8vDa");
            var result = await client.GetAsync("https://www.okex.com/api/v5/market/tickers?instType=SPOT");
            var data = result.Content.ReadAsStringAsync().Result;
            var model = JsonConvert.DeserializeObject<Entities.Models.Temp.PortalCurrencyTicker>(data);
            foreach (var item in model.data)
            {
                CurrencyTickerDetailList.Add(item);
            }
        }
        public async Task GetPortalUserUserWallet()
        {
            await GetAccountAssestToUSD();
            foreach (var item in base.PortalUserWalletRepo.GetItems())
            {
                await GetPortalUserUserWallet(item.PortalUserId, item.PortalWalletId);
            }
        }
        public async Task GetPortalUserUserWallet(int PortalUserId,int PortalWalletId) 
        {
          
            try
            {
                var WalletConfig = base.PortalWalletRepo.GetItemById(PortalWalletId);
                var date = TimeAsync().Result;

                String client_secret = Convert.ToBase64String(Encoding.UTF8.GetBytes(WalletConfig.Secret));
                var rr = generateHash(date + "GET" + "/api/v5/asset/balances", client_secret);
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("OK-ACCESS-KEY", WalletConfig.AccessKey);
                client.DefaultRequestHeaders.Add("OK-ACCESS-SIGN", rr);
                client.DefaultRequestHeaders.Add("OK-ACCESS-TIMESTAMP", date);
                client.DefaultRequestHeaders.Add("OK-ACCESS-PASSPHRASE", WalletConfig.Password);
                var result = await client.GetAsync("https://www.okex.com/api/v5/asset/balances");
                var data = result.Content.ReadAsStringAsync().Result;
                var model = JsonConvert.DeserializeObject<Entities.Models.Temp.PortalCurrency>(data);

                var ZAR = CurrencyConverted().Result;
                foreach (var item in model.data)
                {
                    var ConvertToZAR = item.bal * Convert.ToDouble(CurrencyTickerDetailList.Find(x => x.instId.Contains(item.ccy + "-USDK")).last) * ZAR;
                    this.SaveItem(new Entities.Models.PortalUserWalletDetails { PortalUserId = PortalUserId, Currency = item.ccy, CurrencyValue = ConvertToZAR,DateCreated=DateTime.Now });

                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
