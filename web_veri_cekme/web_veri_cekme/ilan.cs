using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_veri_cekme
{
    public class ilan
    {
        public string _url { get; set; }
        public string _Xpath { get; set; }


        public Dictionary<string, string> vals;
       
        public void dataRead()
        {
            try
            {
                var url = new Uri(_url);
                var client = new WebClient();
                client.Encoding = Encoding.UTF8;
                var html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                HtmlNode nodeData1 = doc.DocumentNode.SelectSingleNode(_Xpath);
                vals = new Dictionary<string, string>();
                try
                {
                    for (int i = 1; i < 20; i++)
                    {

                        HtmlNode nodeData = doc.DocumentNode.SelectSingleNode(_Xpath + "/li[" + i + "]");
                        vals.Add(nodeData.InnerText.Substring(0, nodeData.InnerText.IndexOf(":") + 1), nodeData.InnerText.Substring(nodeData.InnerText.IndexOf(":") + 1));
                    }
                }
                catch (Exception)
                {
                    vals.Add("", nodeData1.InnerText);

                }


            }
            catch (Exception ex) 
            {
                if(!ex.Message.Contains("zaten"))
                    MessageBox.Show(ex.Message);
            }


            
        }

    }
}

