using DTO_LAB8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_LAB8;
using System.Data;
using System.Data.SqlClient;

namespace DAL_LAB8
{
    public class DAL_TamGiac : DBConnect
    {
        public DataTable GetData()
        {
            string querySelect = "Select * from BAI2";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, connString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Check tam giác
        public bool CheckTamGiac(TamGiac TamGiac)
        {
            double a = TamGiac.CanhA;
            double b = TamGiac.CanhB;
            double c = TamGiac.CanhC;
            if(a + b > c && b + c > a && c + a > b)
            {
                return true;
            }
            return false;
        }
        public string LoaiTamGiac(TamGiac TamGiac)
        {
            string str = "";
            double a = TamGiac.CanhA;
            double b = TamGiac.CanhB;
            double c = TamGiac.CanhC;
            if (CheckTamGiac(TamGiac))
            {
                if (a == b && b == c)
                {
                    str += "Tam giác đều";
                }
                else if ((a == b) || (b == c) || (a == c))
                {
                    str += "Tam giác cân";
                }
                else if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == b * b + a * a))
                {
                    str += "Tam giác vuông";
                }
                else if ((a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b))
                {
                    str += "Tam giác tù";
                }
                else
                {
                    str += "Tam giác đều";
                }
            }
            return str;
        }
        public double ChuVi(TamGiac TamGiac)
        {
            double a = TamGiac.CanhA;
            double b = TamGiac.CanhB;
            double c = TamGiac.CanhC;
            double p = 0;
            if(CheckTamGiac(TamGiac))
            {
                p = a + b + c;
            }
            return p;
        }
        public double DienTich(TamGiac TamGiac)
        {
            double a = TamGiac.CanhA;
            double b = TamGiac.CanhB;
            double c = TamGiac.CanhC;
            double s = 0, p = 0;
            if (CheckTamGiac(TamGiac))
            {
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c));
            }
            return s;
        }
        // Thêm các giá trị của lớp tam giác vào database (CSDL)
        public bool InsertTamGiac(TamGiac TamGiac)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string queryInsert = "Insert into BAI2 values (@CanhA, @CanhB, @CanhC, @isTamGiac, @LoaiTamGiac, @ChuVi, @DienTich)";
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.Parameters.AddWithValue("CanhA", TamGiac.CanhA);
                cmd.Parameters.AddWithValue("CanhB", TamGiac.CanhB);
                cmd.Parameters.AddWithValue("CanhC", TamGiac.CanhC);
                cmd.Parameters.AddWithValue("isTamGiac", TamGiac.IsTamGiac);
                cmd.Parameters.AddWithValue("LoaiTamGiac", TamGiac.LoaiTamGiac);
                cmd.Parameters.AddWithValue("ChuVi", TamGiac.ChuVi);
                cmd.Parameters.AddWithValue("DienTich", TamGiac.DienTich);
                if(cmd.ExecuteNonQuery() > 0) 
                {
                    return true;
                }
            }
            catch { } 
            finally { conn.Close(); }
            return false;
        }
    }
}
