using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Data.SqlClient;

namespace web_veri_cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sql _sql = new sql();
     
        ilan iln;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'web_botDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.web_botDataSet.data);
            // TODO: This line of code loads data into the 'web_botDataSet.ilan' table. You can move, or remove it, as needed.
            this.ilanTableAdapter.Fill(this.web_botDataSet.ilan);
            // TODO: This line of code loads data into the 'web_botDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.web_botDataSet.data);
            // TODO: This line of code loads data into the 'web_botDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.web_botDataSet.data);
            // TODO: This line of code loads data into the 'web_botDataSet.ilan' table. You can move, or remove it, as needed.
            this.ilanTableAdapter.Fill(this.web_botDataSet.ilan);
            // TODO: This line of code loads data into the 'web_botDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.web_botDataSet.data);
            // TODO: This line of code loads data into the 'web_botDataSet.ilan' table. You can move, or remove it, as needed.
            this.ilanTableAdapter.Fill(this.web_botDataSet.ilan);







            _sql.Baglan($"Data Source=DESKTOP-6IIAJLV\\SQLEXPRESS;Initial Catalog=web_bot;Integrated Security=True");
            ilanSirala();
            ilanfiyat();
            MailGonder();
            timer1.Start();
        }
        private void ilanSirala() 
        {
            
            iln = new ilan();
            if (dataGIlan.Rows.Count-1 != listUrl.Items.Count)
            {

                foreach (var item in listUrl.Items)
                {
                    iln._url = item.ToString();
                    iln._Xpath = "//*[@id='js-hook-for-observer-detail']/div[2]/ul";
                    iln.dataRead();

                    string key = "";
                    if (iln.vals.TryGetValue("İlan No:", out key))
                    {

                        int index = 0;
                        if (web_botDataSet.ilan.Rows.Count > 0)
                        {
                            foreach (var item2 in web_botDataSet.ilan)
                            {
                                if (key.Contains(item2.no.ToString()))
                                {
                                    index++;
                                }
                            }
                        }

                        string sqlValues = "";
                        string sqlInto = "";
                        if (index == 0)
                        {

                            string dt = "";

                            foreach (KeyValuePair<string, string> item3 in iln.vals)
                            {
                                dt = "";

                                switch (item3.Key)
                                {
                                    case "İlan No:":
                                        dt = "no";
                                        break;
                                    case "İlan Tarihi:":

                                        dt = "tarihi";

                                        break;
                                    case "Marka:":

                                        dt = "marka";

                                        break;
                                    case "Seri:":

                                        dt = "seri";

                                        break;
                                    case "Model:":

                                        dt = "model";

                                        break;
                                    case "Yıl:":

                                        dt = "yil";

                                        break;
                                    case "Yakıt Tipi:":

                                        dt = "yakit";

                                        break;
                                    case "Kilometre:":

                                        dt = "km";

                                        break;

                                }
                                if (dt != "")
                                {
                                  
                                    sqlInto +="["+ dt + "],";
                                    sqlValues +="'"+ item3.Value+"',";

                                    
                                }



                            }
                            sqlValues = sqlValues.Substring(0, sqlValues.Length - 1);
                            sqlInto = sqlInto.Substring(0, sqlInto.Length - 1);


                                _sql.YeniSatirEkle("ilan",sqlInto, sqlValues);//,tarihi,marka,seri,model,yil,yakit,vites,motorH,motorG,km,degisen,takas,kimden
                            this.ilanTableAdapter.Fill(this.web_botDataSet.ilan);

                        }





                    }



                }
            }
            this.ilanTableAdapter.Fill(this.web_botDataSet.ilan);
            
        }

        private void ilanfiyat()
        {

            for (int i = 0; i < listUrl.Items.Count; i++)
            {
                iln._url = listUrl.Items[i].ToString();
                iln._Xpath = "//*[@id='js-hook-for-observer-detail']/div[2]/div[1]/div/span";
                iln.dataRead();
                if (iln.vals.TryGetValue("", out string val))
                {
                    _sql.YeniSatirEkle("data", "[ilan_id],[fiyat],date,[goruntulenme]",Convert.ToInt32( dataGIlan.Rows[i].Cells[0].Value) +",'"+val+ "','"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Görüntülenme bilgisi sitede mevcut değil'");
                }
            }
            this.dataTableAdapter.Fill(this.web_botDataSet.data);

        }


        private void btnUrlEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                foreach (var item in listUrl.Items)
                {
                    if (txtUrlEkle.Text == item)
                    {
                        index++;
                        MessageBox.Show("URL ZATEN MEVCUT");
                    }

                }
                if (index == 0)
                {
                    listUrl.Items.Add(txtUrlEkle.Text);
                    ilanSirala();
                }
            }
                    
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ilanSirala();
            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (listUrl.SelectedIndex!=-1)
            {

                _sql.sil("data", "ilan_id", dataGIlan.Rows[listUrl.SelectedIndex].Cells[0].Value.ToString());
                _sql.sil("ilan","id",dataGIlan.Rows[listUrl.SelectedIndex].Cells[0].Value.ToString());
                
                
                listUrl.Items.Remove(listUrl.SelectedItem);
                ilanSirala();
            }
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {

                ilanSirala();
                ilanfiyat();

            MailGonder();

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
        List<int> _IDilan = new List<int>();
        List<string> _Fiyatilan = new List<string>();
        private void lblFiyat_Click(object sender, EventArgs e)
        {


        }
        private void MailGonder()
        {


            List<int> idSon = new List<int>();
            List<string> fiyatSon = new List<string>();
            _sql.VeriGetir(ref idSon, ref fiyatSon);



                if (txtSifre.Text != "" && txtGonderici.Text != "" && txtAlici.Text != "" && txtYuzde.Text != "")
                {
                txtYuzde.BackColor = txtAlici.BackColor = txtGonderici.BackColor = txtSifre.BackColor = Color.White;
                for (int i = 0; i < fiyatSon.Count; i++)
                {

                    fiyatSon[i] = fiyatSon[i].Replace("TL", "");
                    fiyatSon[i] = fiyatSon[i].Replace(" ", "");
                    //fiyatSon[i] = fiyatSon[i].Replace(".", "");

                    if (_IDilan.Count == idSon.Count)
                    {
                        if (_IDilan[i] == idSon[i])
                        {

                            double yuzde = (Convert.ToDouble(_Fiyatilan[i])) * (double.Parse(txtYuzde.Text.ToString())) / 100;
                            if (Convert.ToDouble(_Fiyatilan[i]) - yuzde >= Convert.ToDouble(fiyatSon[i]) || Convert.ToDouble(_Fiyatilan[i]) + yuzde <= Convert.ToDouble(fiyatSon[i]))
                            {
                                try
                                {

                                    System.Net.NetworkCredential cred = new System.Net.NetworkCredential(txtGonderici.Text, txtSifre.Text);
                                    // mail göndermek için oturum açtık

                                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                                    mail.From = new System.Net.Mail.MailAddress(txtGonderici.Text);
                                    mail.To.Add(txtAlici.Text); // mail gönderilecek adres
                                    mail.Subject = dataGIlan.Rows[i].Cells[1].Value.ToString() + " Nolu İlan Hk."; // mailin konusu
                                    mail.IsBodyHtml = true; // mail içeriği html olarak gönderilsin
                                    mail.Body = dataGIlan.Rows[i].Cells[1].Value.ToString() + " Nolu ilanın Fiyatı: " + fiyatSon[i] + " TL oldu"; // mailin içeriği
                                    mail.Attachments.Clear(); // mail eklerini temizledik




                                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587); // smtp servere bağlandık
                                    smtp.UseDefaultCredentials = false; // varsayılan girişi kullanmadık
                                    smtp.EnableSsl = true; // ssl kullanımına izin verdik
                                    smtp.Credentials = cred; // server üzerindeki oturumumuzu yukarıda belirttiğimiz NetworkCredential üzerinden sağladık.

                                    smtp.Send(mail); // mailimizi gönderdik.
                                                     // smtp yani Simple Mail Transfer Protocol üzerinden maili gönderiyoruz.


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("HATALI GİRİŞ");
                                }

                            }

                        }
                    }
                }




                _IDilan = idSon;
                _Fiyatilan = fiyatSon;
            }
                else
            {
                txtYuzde.BackColor = txtAlici.BackColor = txtGonderici.BackColor = txtSifre.BackColor = Color.Pink;
                MessageBox.Show("zorunlu alanları doldurunuz");
            }

        }

    }
}
