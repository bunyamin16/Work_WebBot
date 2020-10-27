using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_veri_cekme
{
   public class sql
    {
        
        
        public SqlConnection conn;
        public void YeniSatirEkle(string database ,string CreateCol,string CreateVal)
        {
            try
            {
                if (conn.State.ToString() == "Open")
                    conn.Close();
                conn.Open();

                SqlCommand kmt = new SqlCommand("INSERT INTO " + database + "(" + CreateCol + ") VALUES(" + CreateVal + ")", conn);
                kmt.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {

               
            }
            finally
            {
                conn.Close();
            }

        }
        public void Baglan(string connString)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connString;
            
        }
        public void sil(string deleteDbase,string deleteCol, string deleteVal)
        {
            try
            {
                if (conn.State.ToString() == "Open")
                    conn.Close();
                conn.Open();

                SqlCommand kmt = new SqlCommand("DELETE " + deleteDbase + " where " + deleteCol + "=" + deleteVal, conn);
                kmt.ExecuteNonQuery();
            }
            catch (Exception)
            {

               
            }
            finally
            {
                conn.Close();
            }


     

        }
        public void VeriGetir(ref List<int> _ilan_id, ref List<string> _fiyat)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select ilan_id,fiyat from data where date=(select max(date)from data as x where x.ilan_id=data.ilan_id) order by ilan_id", conn);
                if (conn.State.ToString() == "Open")
                    conn.Close();
                conn.Open();
                SqlDataReader dRead ;
                dRead = cmd.ExecuteReader();
               
                List<int> aa = new List<int>();
                while (dRead.Read())
                {
                   _ilan_id.Add(dRead.GetInt32(0));
                   _fiyat.Add (dRead.GetString(1)) ;
                
                }
            }
            catch (Exception ex)
            {

               
            }
            finally
            {
                conn.Close();
            }



          
        }
    }
}
