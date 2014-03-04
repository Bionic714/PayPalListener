using PayPal.Log;
using PayPalListener.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PayPalListener.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string url = PayPal.Manager.ConfigManager.Instance.GetProperties()["paypalUrl"];
            return View();
        }

        [HttpPost]
        public ActionResult IPN()
        {
            byte[] bytes = Request.BinaryRead(Request.ContentLength);

            PayPal.IPNMessage message = new PayPal.IPNMessage(bytes);
            if (message.Validate())
            {
                // message returned VERIFIED
                return View(new { map = message.IpnMap.ToString(), type = message.TransactionType.ToString() });
            }
            else
            {
                //message.IpnMap.ToString();
                //message.TransactionType.ToString();
                return View(new { map = message.IpnMap.ToString(), type = message.TransactionType.ToString() });
                // There was a problem
            }

            return null;
        }
        //public ActionResult IPN()
        //{
            
            //var log = new LogMessage();
            //log.LogMessageToFile("IPN recieved!");
            //var formVals = new Dictionary<string, string>();
            //formVals.Add("cmd", "_notify-validate");

            //string response = GetPayPalResponse(formVals, true);

            //if (response == "VERIFIED")
            //{
            //    log.LogMessageToFile("IPN VERIFIED!");
            //    //validate the order
            //    string sAmountPaid = Request.QueryString["amt"];
            //    string sPayment = ConfigurationManager.AppSettings["amount"].ToString();
            //    Decimal amountPaid = 0;
            //    Decimal Payment = 0;
            //    Decimal.TryParse(sAmountPaid, out amountPaid);
            //    Decimal.TryParse(sPayment, out Payment);

            //    if (Payment <= amountPaid)
            //    {
            //        log.LogMessageToFile("IPN Correct amount");
            //        //process it
            //        try
            //        {
            //            string GUID = Request.QueryString["cm"];
            //            string strGatewayResponse = Request.QueryString["tx"];
            //            var data = new Datalayer();
            //            data.AddPayment(GUID, amountPaid, strGatewayResponse, true);
            //            log.LogMessageToFile("IPN Commplete");
            //            return Redirect("/Payment/Success");
            //        }
            //        catch
            //        {
            //            log.LogMessageToFile("IPN Error");
            //            return Redirect("/Payment/Error");
            //        }
            //    }
            //    else
            //    {
            //        log.LogMessageToFile("IPN Incorrect amount!");
            //        log.LogMessageToFile("IPN amount:" + Request.QueryString["payment_gross"]);
            //        log.LogMessageToFile("IPN GUID:" + Request.QueryString["custom"]);
            //        log.LogMessageToFile("IPN ID:" + Request.QueryString["txn_id"]);
            //        return Redirect("/Payment/Error");
            //    }
            //}
            //log.LogMessageToFile("IPN not verified!");
            //return View("/Payment/Error");
        //}


    //    string GetPayPalResponse(Dictionary<string, string> formVals, bool useSandbox)
    //    {

    //        string paypalUrl = useSandbox ? "https://www.sandbox.paypal.com/cgi-bin/webscr"
    //            : "https://www.paypal.com/cgi-bin/webscr";


    //        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(paypalUrl);

    //        // Set values for the request back
    //        req.Method = "POST";
    //        req.ContentType = "application/x-www-form-urlencoded";

    //        byte[] param = Request.BinaryRead(Request.ContentLength);
    //        string strRequest = Encoding.ASCII.GetString(param);



    //        StringBuilder sb = new StringBuilder();
    //        sb.Append(strRequest);

    //        foreach (string key in formVals.Keys)
    //        {
    //            sb.AppendFormat("&{0}={1}", key, formVals[key]);
    //        }
    //        strRequest += sb.ToString();
    //        req.ContentLength = strRequest.Length;

    //        string response = "";
    //        using (StreamWriter streamOut = new StreamWriter(req.GetRequestStream(), System.Text.Encoding.ASCII))
    //        {

    //            streamOut.Write(strRequest);
    //            streamOut.Close();
    //            using (StreamReader streamIn = new StreamReader(req.GetResponse().GetResponseStream()))
    //            {
    //                response = streamIn.ReadToEnd();
    //            }
    //        }

    //        return response;
    //    }

    //    public ActionResult About()
    //    {
    //        ViewBag.Message = "Your application description page.";

    //        return View();
    //    }

    //    public ActionResult Contact()
    //    {
    //        ViewBag.Message = "Your contact page.";

    //        return View();
    //    }
    }
}