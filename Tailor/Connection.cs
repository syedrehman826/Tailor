using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor
{
    class Connection
    {
        public static SqlConnection sc;

        public static SqlConnection Get() {
            if (sc==null) {
                sc=new SqlConnection();
                sc.ConnectionString = @"Data source=DESKTOP-Q78RQP5\SQLEXPRESS;initial catalog=TMSystem;integrated Security=SSPi";
                sc.Open();
            }
            return sc;

        }

    }
}
