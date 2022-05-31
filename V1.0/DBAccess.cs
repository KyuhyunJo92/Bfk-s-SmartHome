using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UniversalServer.Model
{
    public delegate EventHandler ErrorEventHandler(string msg);
    public class DBAccess
    {
        
        public DBAccess()
        {
            //Hier die Verbindung zur DB herstellen. Siehe Info-Pool
            //Verbindungsdaten dürfen "hard codiert" werden.
            
        }

        //public void DBStart()
        //{
        //    con.Open();
        //}

        ///Diese Methode für den Datensatz in die Datenbank ein. Siehe Info-Pool      
         public void InsertData(TempValue t, HumidValue h, PressureValue p, DateTime dt, string ipa)
        {
            MySqlConnection con;
            con = new MySqlConnection(@"SERVER = 127.0.0.1;DATABASE=dbTEMP;UID=root;PASSWORD=;");
            con.Open();

            string insert =
                "INSERT INTO dbtemp.tblTEMP(Temp,Humid,Press,DTime,IPA) "+
                "VALUES(12.5, 12.2,123.3, 'asd', 'aad');";
                /*"VALUES(" + t.ToString() + "," + h.ToString() + "," + p.ToString() + ",'123','" + ipa + "');";*/
/*CREATE TABLE IF NOT EXISTS tblTEMP(int Temp,int Humid,int Press,varchar(20) DTime,varchar(20) IPA); */
/*VALUES(12.5, 12.2,123.3, 'asd', 'aad');";*/
/*" + dt.ToString() + "*/
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = insert;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            //con.Close();
        }

        public string Show(TempValue t, HumidValue h, PressureValue p, DateTime dt, string ipa)
        {
            string dummy = t.ToString() + "," + h.ToString() + "," + p.ToString() + "," + dt.ToString() + ",'" + ipa + "')";

            return dummy;
        }

    }
}
