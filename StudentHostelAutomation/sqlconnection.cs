using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHostelAutomation
{
    internal class sqlconnection
    {
        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9H60TTH\\SERCANKURBAN;Initial Catalog=DbStudentHostel;User ID=WebMobile_302;Password=webmobile.302");
            conn.Open();
            return conn;
        }
    }
}
