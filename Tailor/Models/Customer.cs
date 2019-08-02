using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Models
{
    public class Customer
    {
        //5 Method 
        public int C_ID { get; set; }
        public double C_no { get; set; }
        public string C_Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string naamee { get; set; }


        public void CutomerAdd()
        {
            SqlCommand cmd = new SqlCommand("CustomerAdd", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@C_no", C_no);
            cmd.Parameters.AddWithValue("@C_Name", C_Name);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.ExecuteNonQuery();
        }
        public void CustomerDelete()
        {
            SqlCommand cmd = new SqlCommand("CustomerDelete", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@C_ID", C_ID);
            cmd.ExecuteNonQuery();
        }
        public List<Customer> CustomerShowAll()
        {
            SqlCommand cmd = new SqlCommand("CustomerShowAll", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@C_no", C_no);
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Customer> lst = new List<Customer>();
            while (sdr.Read())
            {
                Customer cs = new Customer() { };
                cs.C_no = (int)sdr["C_no"];
                cs.C_Name = (string)sdr["C_Name"];
                cs.ContactNo = (string)sdr["ContactNo"];
                cs.Address = (string)sdr["Address"];
                lst.Add(cs);
            }

            sdr.Close();
            return lst;
        }
        public static int Get_Customer_NO()
        {
            SqlCommand cmd = new SqlCommand("Get_Customer_NO", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return (int)cmd.ExecuteScalar();
        }
        public void CustomerUpdate()
        {
            SqlCommand cmd = new SqlCommand("CustomerUpdate", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@C_ID", C_ID);
            cmd.Parameters.AddWithValue("@C_Name", C_Name);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@Address", Address);

            cmd.ExecuteNonQuery();
        }
        public DataTable CustomerLOV()
        {
            DataTable dt;
            SqlCommand cmd = new SqlCommand("CustomerLOV",Connection.Get());
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                
                //Fill the DataTable with records from Table.
                dt = new DataTable();
                sda.Fill(dt);

            }
            return dt;
        }
    }
}


