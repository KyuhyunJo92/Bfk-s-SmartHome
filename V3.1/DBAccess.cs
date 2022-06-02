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
         public void InsertData(TempValue t, HumidValue h, PressureValue p, DateTime dt/*string dt*/, string ipa)
        {
            MySqlConnection con;
            con = new MySqlConnection(@"SERVER = 127.0.0.1;DATABASE=dbTEMP;UID=root;PASSWORD=;");
            con.Open();

            string insert =
                //kwid = ? -> Auto INCREMENT
                "INSERT INTO dbtemp.tblklimawert(temp, lfeuchte, druck, zeitpunkt, fksensid) VALUES('" + t.Value + "','" + h.Value + "','" + p.Value + "','"+dt.ToString("yyyy-MM-dd hh:mm:ss") + "',"+getSensId(ipa)+");";

            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = insert;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int getSensId(string ipa)
        {
            int i = 0;
            string dummyIP_1 = "192.168.1.145";
            string dummyIP_2 = "112.168.1.143";
            string dummyIP_3 = "127.1.1.154";

            if (ipa.Equals(dummyIP_1))
            { i = 1; return i; }
            else if (ipa.Equals(dummyIP_2))
            { i = 2; return i; }
            else if (ipa.Equals(dummyIP_3))
            { i = 3; return i; }
            else
            {
                i = 9999; return i;//error }
            }

        }
    }
}
