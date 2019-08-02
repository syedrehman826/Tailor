using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Models
{
    class Lower
    {
        public int L_id { get; set; }
        public string Waist { get; set; }
        public string Hip { get; set; }
        public string Length { get; set; }
        public string Bottom { get; set; }
        public string Knee { get; set; }
        public string Thai { get; set; }
        public string FullFly { get; set; }
        public int B_id { get; set; }
        public int U_id { get; set; } = 0;
        public string Particular { get; set; }
        public string Material { get; set; }
        public bool isLace { get; set; }
        public bool isPiping { get; set; }
        public string picPath { get; set; } = "";
        public string Comments { get; set; } = "";


        public string particular { get; set; }
        public int LowerAdd() {
            SqlCommand sc =new  SqlCommand("LowerAdd",Connection.Get());
            sc.CommandType=System.Data.CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("Waist", Waist);
            sc.Parameters.AddWithValue("Hip", Hip);
            sc.Parameters.AddWithValue("Length", Length);
            sc.Parameters.AddWithValue("Bottom", Bottom);
            sc.Parameters.AddWithValue("Knee", Knee);
            sc.Parameters.AddWithValue("Thai", Thai);
            sc.Parameters.AddWithValue("FullFly", FullFly);

            sc.Parameters.AddWithValue("B_id", B_id);
            sc.Parameters.AddWithValue("Particular", Particular);
            sc.Parameters.AddWithValue("Material", Material);
            sc.Parameters.AddWithValue("isLace", isLace);
            sc.Parameters.AddWithValue("isPiping", isPiping);
            sc.Parameters.AddWithValue("picPath", picPath == null ? "":picPath);
            sc.Parameters.AddWithValue("Comments", Comments==null?"":Comments);
            
            return Convert.ToInt32(sc.ExecuteScalar());
        }
        public Lower Lower_Search(string particular, int C_id)
        {
            SqlCommand sc = new SqlCommand("Lower_Search", Connection.Get());
            sc.CommandType = System.Data.CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@part", particular);
            sc.Parameters.AddWithValue("@c_id", C_id);
            SqlDataReader sdr = sc.ExecuteReader();  
            Lower u = new Lower();
            while (sdr.Read())
            {
                u.U_id = (int)sdr["U_id"];
                u.Length = (string)sdr["Length"];
                u.Waist= (string)sdr["Waist"];
                u.Hip= (string)sdr["Hip"];
                u.Bottom= (string)sdr["Bottom"];
                u.Knee= (string)sdr["Knee"];
                u.Thai= (string)sdr["Thai"];
                u.FullFly = (string)sdr["FullFly"];
            }
            sdr.Close();
            if(return u==null){
               
            };
        }

    }
}
