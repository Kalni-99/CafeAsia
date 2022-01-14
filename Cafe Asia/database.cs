using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cafe_Asia
{
    class database
    {
        
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public database()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Cafe_Asia;Integrated Security=True");

        }

        public int save_update_delete(string a)
        {
            con.Open();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataTable getData(string a)
        {
            con.Open();
            da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void dbclose()
        {
            con.Close();
        }
    }
}