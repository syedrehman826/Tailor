using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Models
{
    class Stitching
    {
        public int B_id { get; set; }
        public int U_id { get; set; } = 0;
        public int L_id { get; set; } = 0;
        public string Particular { get; set; }
        public string Material { get; set; }
        public bool isLace { get; set; }
        public bool isPiping{ get; set; }
        public string picPath { get; set; } = "";
        public string Comments { get; set; }

        public void StitchingAdd() {
            SqlCommand sc = new SqlCommand("StitchingAdd",Connection.Get());
            sc.CommandType = System.Data.CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("B_id", B_id);
            sc.Parameters.AddWithValue("L_id", L_id);
            sc.Parameters.AddWithValue("U_id", U_id);
            sc.Parameters.AddWithValue("Particular", Particular);
            sc.Parameters.AddWithValue("Material", Material);
            sc.Parameters.AddWithValue("isLace", isLace);
            sc.Parameters.AddWithValue("isPiping", isPiping);
            sc.Parameters.AddWithValue("picPath", picPath);
            sc.Parameters.AddWithValue("Comments", Comments);
            sc.ExecuteNonQuery();

        }
    }
}
