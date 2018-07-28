using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KryptoniteGaming.Models.DB;
using KryptoniteGaming.Models.ViewModel;

namespace KryptoniteGaming.Models.EntityManager
{
    public class SpinManager
    {

        public Batch GetNextSpin()
        {
            using (kryptonitegamingEntities db = new kryptonitegamingEntities())
            {
                var spin = db.Batches.Where(o => o.Processed.Equals(0));
                if (spin.Any())
                    return spin.FirstOrDefault();
                else
                    return null;
            }
        }

        public void AcceptSpin(Int32 SpinID)
        {
            using (kryptonitegamingEntities db = new kryptonitegamingEntities())
            {
                var spin = db.Batches.Where(o => o.Id.Equals(SpinID));
                if (spin.Any())
                {
                    spin.FirstOrDefault().Processed = 1;
                    db.SaveChanges();
                }
            }
        }

    }
}