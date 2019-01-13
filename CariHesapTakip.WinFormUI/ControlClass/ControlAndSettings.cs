using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CariHesapTakip.WinFormUI.ControlClass
{
    public class ControlAndSettings
    {
        public string ExchanceUSD()
        {
            //Get USD
            string today = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            //<span class="value">5,6648</span>
            string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            return USD.Substring(0, USD.Length - 2);
        }

        public string ExchanceEuro()
        {
            //Get EURO
            string today = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            return EURO.Substring(0, EURO.Length - 2);
        }

        public string SelectDateExchance(string gun, string ay, string yil)
        {
            System.Windows.Forms.MessageBox.Show(gun + ay + yil);
            string anyDays = ("http://www.tcmb.gov.tr/kurlar/" + yil + ay + "/" + gun + ay + yil + ".xml");
            var xmlDoc = new XmlDocument();
            System.Windows.Forms.MessageBox.Show(anyDays.ToString());
            xmlDoc.Load(anyDays);
            string EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            return EURO.Substring(0, EURO.Length - 2);
        }
    }
}
