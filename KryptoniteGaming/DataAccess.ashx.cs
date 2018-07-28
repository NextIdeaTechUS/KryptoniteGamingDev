using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KryptoniteGaming.Models.DB;
using KryptoniteGaming.Models.ViewModel;
using KryptoniteGaming.Models.EntityManager;

namespace KryptoniteGaming
{
    /// <summary>
    /// Summary description for DataAccess
    /// </summary>
    public class DataAccess : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            System.Collections.Specialized.NameValueCollection arrQueryString = context.Request.QueryString;

            String strMethod = "";
            String strReturn = "";
            Boolean blnHandled = false;

            if (arrQueryString["method"] != null)
            {
                strMethod = arrQueryString["method"].ToString().ToLower();
            }


            if (context.Session != null)
            {
                  
                
            }

            try
            {

                if (strMethod == "getnextspin")
                {

                    SpinManager SM = new SpinManager();
                    Batch batch = SM.GetNextSpin();

                    strReturn = Newtonsoft.Json.JsonConvert.SerializeObject(batch);
                }
                else if (strMethod == "getaccount")
                {

                    String strID = arrQueryString["id"].ToString();
                    AccountManager AM = new AccountManager();
                    Account account = AM.GetAccount(strID);

                    strReturn = Newtonsoft.Json.JsonConvert.SerializeObject(account);
                }
                else if (strMethod == "updateaccount")
                {

                    String strID = arrQueryString["accountid"].ToString();
                    String strAmount = arrQueryString["amount"].ToString() ;

                    AccountManager AM = new AccountManager();
                    AM.UpdateAccountCredits(strID, Convert.ToDecimal(strAmount));

                }
                else if (strMethod == "updatespinlog")
                {

                    String strID = arrQueryString["accountid"].ToString();
                    String strStatus = arrQueryString["status"].ToString();
                    String strSpinID = arrQueryString["spinid"].ToString();

                    SpinLogManager SLM = new SpinLogManager();

                    SpinLog spinLog = new SpinLog();

                    spinLog.AccountId = Convert.ToInt32(strID);
                    spinLog.Status = strStatus;
                    spinLog.CreateDate = DateTime.Now;
                    spinLog.SpinId = Convert.ToInt32(strSpinID);
                    
                    SLM.UpsertSpinLog(spinLog);

                    if (strStatus == "Accepted")
                    {
                        SpinManager SM = new SpinManager();
                        SM.AcceptSpin(Convert.ToInt32(strSpinID));
                    }

                }
                else
                {
                    strReturn = "Unknown method '" + strMethod + "'.";
                }



                if (!blnHandled)
                    context.Response.Write(strReturn);
            }
            catch (Exception ex)
            {
                context.Response.Write(ex.Message);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}