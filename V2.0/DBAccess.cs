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

        ///Diese Methode für den Datensatz in die Datenbank ein. Siehe Info-Pool      
        public void InsertData(TempValue t, HumidValue h, PressureValue p, DateTime dt, string ipa)
        {
            MySqlConnection con;
            con = new MySqlConnection(@"SERVER = 127.0.0.1;DATABASE=dbTEMP;UID=root;PASSWORD=;");
            con.Open();

            string insert =
                "CREATE TABLE IF NOT EXISTS tblklimawert(int kwid Primary Key NOT NULL AUTO INCREMENT, double temp, double lfeuchte, double druck,datetime zeitpunkt, varchar[20] fksensid);"+
               
                "INSERT INTO dbtemp.tblTEMP(kwid,temp, lfeuchte, druck, zeitpunkt, fksensid)"+
                 //kwid = ? -> Auto INCREMENT
                 "VALUES(?," + t.Value + "," + h.Value + "," + p.Value + "," + dt + ",'" + ipa + "');";
               
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = insert;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            //con.Close();

        }


    }
}
