using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KryptoniteGaming.Models.DB;
using KryptoniteGaming.Models.ViewModel;

namespace KryptoniteGaming.Models.EntityManager
{
    public class AccountManager
    {

        
        public Account GetAccount(string ID)
        {
            using (kryptonitegamingEntities db = new kryptonitegamingEntities())
            {
                var account = db.Accounts.Where(o => o.AccountNumber.ToLower().Equals(ID));
                if (account.Any())
                    return account.FirstOrDefault();
                else
                    return null;
            }
        }

        public void UpdateAccountCredits(String ID, Decimal Amount)
        {
            using (kryptonitegamingEntities db = new kryptonitegamingEntities())
            {
                var account = db.Accounts.Where(o => o.AccountNumber.ToLower().Equals(ID));
                if (account.Any())
                {
                    account.FirstOrDefault().Credits = account.FirstOrDefault().Credits + Amount;
                    db.SaveChanges();
                }
            }
        }

    }
}