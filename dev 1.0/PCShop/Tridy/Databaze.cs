using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Reflection;
using System.IO;
using System.Data.SqlClient;

namespace PCShop
{
    class Databaze
    {
        private SqlConnection dbPripojeni;
        private SqlCommand dbPrikaz;
        //private SqlDataReader reader;
        private string ConnectionString;

        public Databaze()
        {
            string exec = Assembly.GetExecutingAssembly().Location;
            string cesta = (Path.GetDirectoryName(exec));
            AppDomain.CurrentDomain.SetData("DataDirectory", cesta);
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\databaze.mdf;Integrated Security=True;Connect Timeout=30";
            dbPripojeni = new SqlConnection(ConnectionString);
            dbPripojeni.Open();
        }

        public bool zavritDB
        {
            get
            {
                try
                {
                    dbPripojeni.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public int ZkontrolujPrihlaseni(string login, string heslo) //vystupy: id uzivatele=udaje ok, -1=spatne udaje
        {
            string passwd = md5_encrypt(heslo);
            dbPrikaz = new SqlCommand("SELECT COUNT(*) FROM app_login WHERE login=@Login AND password=@Passwd", dbPripojeni);
            dbPrikaz.Parameters.Add("@Login", System.Data.SqlDbType.NVarChar).Value = login;
            dbPrikaz.Parameters.Add("@Passwd", System.Data.SqlDbType.NVarChar).Value = passwd;
            if((int)dbPrikaz.ExecuteScalar() == 1)
            {
                dbPrikaz = new SqlCommand("SELECT id FROM app_login WHERE login=@Login AND password=@Passwd", dbPripojeni);
                dbPrikaz.Parameters.Add("@Login", System.Data.SqlDbType.NVarChar).Value = login;
                dbPrikaz.Parameters.Add("@Passwd", System.Data.SqlDbType.NVarChar).Value = passwd;
                return (int)dbPrikaz.ExecuteScalar();
            }
            else
                return -1;
        }

        /* private string md5_decrypt(string text)
         {
             if ((text == null) || (text.Length == 0))
                 return string.Empty;

             //Calculate MD5 hash. This requires that the string is splitted into a byte[].
             MD5 md5 = new MD5CryptoServiceProvider();
             byte[] textToHash = Encoding.Default.GetBytes(text);
             byte[] vysledek = md5.ComputeHash(textToHash);

             //konverze bitoveho pole zpatky na string
             return BitConverter.ToString(vysledek);
         }*/

        private string md5_encrypt(string text)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
