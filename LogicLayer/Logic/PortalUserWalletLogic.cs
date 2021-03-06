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
    public class PortalUserWalletLogic : Baselogic<Entities.Models.PortalUserWallet>
    {
     

        public List<Entities.Models.PortalUserWallet> GetItemListByPortalUserId(int PortalUserId)
        {
            var result = base.PortalUserWalletRepo.GetItemFiltered(new { PortalUserId = PortalUserId }).ToList();
            if (result != null)
            {
                foreach (var item in result)
                {
                    var PortalWallet = Logic.UOW.PortalWalletLogic.GetItemById(item.PortalWalletId);
                    item.PortalWallet = PortalWallet;

                }
            }

            return result;
        }

        public PortalUserWalletLogic()
        {
        }
      
        public Entities.Models.PortalUserWallet GetItemById(int PortalUserWalletId)
        {
            var PortalUserWallet = base.PortalUserWalletRepo.GetItemById(PortalUserWalletId);
            if (PortalUserWallet != null)
            {
                PortalUserWallet.PortalWallet = base.PortalWalletRepo.GetItemById(PortalUserWallet.PortalWalletId);
            }
            else
            {
                PortalUserWallet = new();
                PortalUserWallet.PortalWallet = new();
            }
            return PortalUserWallet;
        }
        public Entities.Models.PortalUserWallet SaveItem(Entities.Models.PortalUserWallet model)
        {
            var PortalWallet = base.PortalWalletRepo.SaveItem(model.PortalWallet);
            if (model.PortalWalletId == 0)
            {
                model.PortalWalletId = PortalWallet.Id;
            }
            var PortalUserWallet = base.PortalUserWalletRepo.SaveItem(model);
            return PortalUserWallet;
        }
      


        //public async Task<List<Entities.Models.PoralWalletDisplay>> GetAccountAssest()
        //{  
        //    List<Entities.Models.PoralWalletDisplay> Detal = new List<Entities.Models.PoralWalletDisplay>();
        //    try
        //    {
        //        var date = TimeAsync().Result;

        //        String client_secret = Convert.ToBase64String(Encoding.UTF8.GetBytes("1BB0A2956173C6402CC5B1B0F0DB0B64"));
        //        var rr = generateHash(date + "GET" + "/api/v5/asset/balances", client_secret);
        //        var client = new HttpClient();
        //        client.DefaultRequestHeaders.Add("OK-ACCESS-KEY", "4b6d4a63-d764-400f-b652-ddada894afe4");
        //        client.DefaultRequestHeaders.Add("OK-ACCESS-SIGN", rr);
        //        client.DefaultRequestHeaders.Add("OK-ACCESS-TIMESTAMP", date);
        //        client.DefaultRequestHeaders.Add("OK-ACCESS-PASSPHRASE", "CEXt2YzUhv8vDa");
        //        var result = await client.GetAsync("https://www.okex.com/api/v5/asset/balances");
        //        var data = result.Content.ReadAsStringAsync().Result;
        //        var model = JsonConvert.DeserializeObject<Entities.Models.PortalCurrency>(data);

        //        var ZAR = CurrencyConverted().Result;
        //        foreach (var item in model.data)
        //        {
        //            var ConvertToZAR = item.bal * Convert.ToDouble(CurrencyTickerDetailList.Find(x => x.instId.Contains(item.ccy + "-USDK")).last) * ZAR;
        //            Detal.Add(new() {Currency= item.ccy,CurrencyValue= ConvertToZAR });
        //            //item.ccy + " - " + ConvertToZAR.ToString()

        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return Detal;
        //}
    }
}
