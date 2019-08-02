using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Models
{
    class Upper
    {
        public int U_id { get; set; }
        public string Length { get; set; }
        public string Shoulder { get; set; }
        public string Sleeve { get; set; }
        public string Chest { get; set; }
        public string Waist { get; set; }
        public string Hip { get; set; }
        public string Collor { get; set; }

        #region Stitching
        public string particular { get; set; }
        public int B_id { get; set; }
        public int L_id { get; set; } = 0;
        public string Particular { get; set; }
        public string Material { get; set; }
        public bool isLace { get; set; }
        public bool isPiping { get; set; }
        public string picPath { get; set; } = "";
        public string Comments { get; set; } = "";
        #endregion 


        public int UpperAdd()
        {
            SqlCommand cmd = new SqlCommand("UpperAdd", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Length", Length);
            cmd.Parameters.AddWithValue("@Shoulder", Shoulder);
            cmd.Parameters.AddWithValue("@Sleeve", Sleeve);
            cmd.Parameters.AddWithValue("@Chest", Chest);
            cmd.Parameters.AddWithValue("@Waist", Waist);
            cmd.Parameters.AddWithValue("@Hip", Hip);
            cmd.Parameters.AddWithValue("@Collor", Collor);

            cmd.Parameters.AddWithValue("Particular", Particular);
            cmd.Parameters.AddWithValue("Material", Material);
            cmd.Parameters.AddWithValue("B_id", B_id);
            cmd.Parameters.AddWithValue("isLace", isLace);
            cmd.Parameters.AddWithValue("isPiping", isPiping);
            cmd.Parameters.AddWithValue("picPath", picPath == null ? "" : picPath);
            cmd.Parameters.AddWithValue("Comments", Comments == null ? "" : Comments);
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            return a;
        }
        public Upper Upper_Search(string particular, int C_id)
        {
            SqlCommand sc = new SqlCommand("Upper_Search", Connection.Get());
            sc.CommandType = System.Data.CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@part", particular);
            sc.Parameters.AddWithValue("@c_id", C_id);
            SqlDataReader sdr = sc.ExecuteReader();
            Upper u = new Upper();
            while (sdr.Read())
            {
                u.U_id = (int)sdr["U_id"];
                u.Length = (string)sdr["Length"];
                u.Shoulder = (string)sdr["Shoulder"];
                u.Sleeve = (string)sdr["Sleeve"];
                u.Chest = (string)sdr["Chest"];
                u.Collor = (string)sdr["Collar"];
                u.Waist = (string)sdr["Waist"];
                u.Hip = (string)sdr["Hip"];
            }
            sdr.Close();
            return u;
        }
    }
}
