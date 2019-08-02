using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Models
{
    class Booking
    {
        public int B_id { get; set; }
        public int C_id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Due_Date  { get; set; }
        public DateTime Trail_Date  { get; set; }
        public decimal Advance { get; set; }
        public decimal Balance { get; set; }
        public decimal Total{ get; set; }

        public int  BookingAdd()
        {
            SqlCommand cmd = new SqlCommand("BookingAdd", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@C_id", C_id);

            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Due_Date", Due_Date);
            cmd.Parameters.AddWithValue("@Trail_Date", Trail_Date);
            cmd.Parameters.AddWithValue("@Advance", Advance);
            cmd.Parameters.AddWithValue("@Balance", Balance);
            cmd.Parameters.AddWithValue("@Total", Total);
            return Convert.ToInt32((decimal)cmd.ExecuteScalar());
        }
        



    }
}
