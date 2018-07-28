using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KryptoniteGaming.Models.DB;
using KryptoniteGaming.Models.ViewModel;
using System.Data.Entity.Migrations;

namespace KryptoniteGaming.Models.EntityManager
{
    public class SpinLogManager
    {

        public void UpsertSpinLog(SpinLog spinLog)
        {
            using (kryptonitegamingEntities db = new kryptonitegamingEntities())
            {
                db.SpinLogs.AddOrUpdate(spinLog);
                db.SaveChanges();
            }
        }
        

    }
}