using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayPalListener.Models
{
    public class PayPalTransaction
    {
        //string url = PayPal.Manager.ConfigManager.Instance.GetProperties()["paypalUrl"];
        //private const string KEY_ADDRESSSTATE = "address_state";
        private string KEY_TXNID = "txn_id";
        private const string KEY_LASTNAME = "last_name";
        private const string KEY_CURRENCY = "mc_currency";
        private const string KEY_PAYERSTATUS = "payer_status";
        //private const string KEY_ADDRESSSTATUS = "address_status";
        //private const string KEY_TAX = "tax";
        //private const string KEY_INVOICE = "invoice";
        private const string KEY_PAYEREMAIL = "payer_email";
        private const string KEY_FIRSTNAME = "first_name";
        //private const string KEY_BUSINESS = "business";
        private const string KEY_VERIFYSIGN = "verify_sign";
        private const string KEY_PAYERID = "payer_id";
        private const string KEY_PAYMENTDATE = "payment_date";
        private const string KEY_PAYMENTSTATUS = "payment_status";
        private const string KEY_RECEIVEREMAIL = "receiver_email";
        private const string KEY_PAYMENTTYPE = "payment_type";
        //private const string KEY_ADDRESSNAME = "address_name";
        //private const string KEY_ADDRESSSTREET = "address_street";
        //private const string KEY_ADDRESSZIP = "address_zip";
        //private const string KEY_ADDRESSCITY = "address_city";
        //private const string KEY_ADDRESSCOUNTRY = "address_country";
        //private const string KEY_ADDRESSCOUNTRYCODE = "address_country_code";
        //private const string KEY_SHIPPING = "mc_shipping";
        private const string KEY_ITEMNUMBER1 = "item_number1";
        //private const string KEY_SHIPPING1 = "mc_shipping1";
        private const string KEY_ITEMNAME1 = "item_name1";
        private const string KEY_HANDLING1 = "mc_handling1";
        private const string KEY_GROSS1 = "mc_gross1";
        private const string KEY_GROSS = "mc_gross";
        //private const string KEY_FEE = "mc_fee";
        //private const string KEY_RESIDENCECOUNTRY = "residence_country";
        private const string KEY_NOTIFYVERSION = "notify_version";
        private const string KEY_RECEIVERID = "receiver_id";
        private const string KEY_HANDLING = "mc_handling";
        private const string KEY_TXNTYPE = "txn_type";
        private const string KEY_CUSTOM = "custom";
        private const string KEY_TESTIPN = "test_ipn";

        private const string KEY_IPNTRACKID = "ipn_track_id";
        private const string KEY_PROTECTION_ELIGIBILITY = "protection_eligibility";

        private const string KEY_QUANTITY = "quantity";
        private const string KEY_RESEND = "resend";
        private const string KEY_NOTIFY_VERSION = "notify_version";

        public PayPalTransaction()
        {
        }

        //public PayPalTransaction(PayPal.IPNMessage message)
        //{
        //    this.TransactionId = message.IpnValue(KEY_TXNID);
        //    this.TransactionType = message.IpnValue(KEY_TXNTYPE);
        //    this.PayerId = message.IpnValue(KEY_PAYERID);
        //    this.Currency = message.IpnValue(KEY_CURRENCY);
        //    this.Custom = message.IpnValue(KEY_CUSTOM);
        //    this.HandlingAmount = GetAsDecimal(message, KEY_HANDLING);
        //    this.FirstName = message.IpnValue(KEY_FIRSTNAME);
        //    this.IpnTrackId = message.IpnValue(KEY_IPNTRACKID);
        //    this.LastName = message.IpnValue(KEY_LASTNAME);
        //    this.PayerStatus = message.IpnValue(KEY_PAYERSTATUS);
        //    this.PaymentDate = GetAsDate(message, KEY_PAYMENTDATE);
        //    this.PaymentStatus = message.IpnValue(KEY_PAYMENTSTATUS);
        //    this.ProtectionEligibility = message.IpnValue(KEY_PROTECTION_ELIGIBILITY);
        //    this.ShippingAmount = GetAsDecimal(message, KEY_SHIPPING);
        //    this.GrossAmount = GetAsDecimal(message, KEY_GROSS);
        //    this.FeeAmount = GetAsDecimal(message, KEY_FEE);
 
        //    this.Quantity = GetAsInt(message, KEY_QUANTITY);
        //    this.Resend = GetAsBool(message, KEY_RESEND);
        //    this.PaymentType = message.IpnValue(KEY_PAYMENTTYPE);
        //    this.NotifyVersion = message.IpnValue(KEY_NOTIFY_VERSION);
        //    this.PayerEmail = message.IpnValue(KEY_PAYEREMAIL);
        //    this.TaxAmount = GetAsDecimal(message, KEY_TAX);
        //    this.ResidenceCountry = message.IpnValue(KEY_RESIDENCECOUNTRY);
 
        //    this.ItemNumber1 = message.IpnValue(KEY_ITEMNUMBER1);
        //    this.ItemName1 = message.IpnValue(KEY_ITEMNAME1);
        //    this.ShippingAmount1 = GetAsDecimal(message, KEY_SHIPPING1);
        //    this.HandlingAmount1 = GetAsDecimal(message, KEY_HANDLING1);
        //    this.GrossAmount1 = GetAsDecimal(message, KEY_GROSS1);
 
        //    this.AddressCity = message.IpnValue(KEY_ADDRESSCITY);
        //    this.AddressCountryCode = message.IpnValue(KEY_ADDRESSCOUNTRYCODE);
        //    this.AddressCountry = message.IpnValue(KEY_ADDRESSCOUNTRY);
        //    this.AddressName = message.IpnValue(KEY_ADDRESSNAME);
        //    this.AddressStreet = message.IpnValue(KEY_ADDRESSSTREET);
        //    this.AddressZip = message.IpnValue(KEY_ADDRESSZIP);
 
        //}
    }
}