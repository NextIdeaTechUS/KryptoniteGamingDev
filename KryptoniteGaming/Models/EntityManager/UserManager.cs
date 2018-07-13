using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KryptoniteGaming.Models.DB;
using KryptoniteGaming.Models.ViewModel;

namespace KryptoniteGaming.Models.EntityManager
{
    public class UserManager
    {

        public void AddUserAccount(UserSignUpView user)
        {

            using (kryptonitegamingEntities db = new kryptonitegamingEntities())
            {

                User SU = new User();
                SU.UserName = user.LoginName;
                SU.EncryptedPassword = user.Password;           
                SU.CreateDate = DateTime.Now;
                SU.LastUpdated = DateTime.Now;

                db.Users.Add(SU);
                db.SaveChanges();

            }
        }

        public bool IsLoginNameExist(string loginName)
        {
            using (kryptonitegamingEntities db = new kryptonitegamingEntities())
            {
                return db.Users.Where(o => o.UserName.Equals(loginName)).Any();
            }
        }

        public string GetUserPassword(string loginName)
        {
            using (kryptonitegamingEntities db = new kryptonitegamingEntities())
            {
                var user = db.Users.Where(o => o.UserName.ToLower().Equals(loginName));
                if (user.Any())
                    return user.FirstOrDefault().EncryptedPassword;
                else
                    return string.Empty;
            }
        }

    }
}