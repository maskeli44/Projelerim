using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace vize2
{
    class DataBaseKoprusu
    {
        
        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database4.mdb");
        public static OleDbDataAdapter adtr = new OleDbDataAdapter();
        public static DataSet ds = new DataSet();
        public static OleDbCommand komut = new OleDbCommand();
        public static OleDbCommand komut2 = new OleDbCommand();
    }
}
