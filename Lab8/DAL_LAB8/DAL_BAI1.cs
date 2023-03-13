using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_LAB8;

namespace DAL_LAB8
{
    public class DAL_BAI1 : DBConnect
    {
        public DataTable GetData()
        {
            string querySelect = "Select * from BAI1";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, connString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int TinhTong(Bai1 bai1)
        {
            bai1.Result = bai1.So1 + bai1.So2;
            return bai1.Result;
        }
        public bool InsertRow(Bai1 bai1)
        {
            SqlConnection conn = new SqlConnection(connString); ;
            try
            {
                conn.Open();
                string queryInsert = "Insert into BAI1 Values(@So1, @So2, @Result)";
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.Parameters.AddWithValue("So1", bai1.So1);
                cmd.Parameters.AddWithValue("So2", bai1.So2);
                cmd.Parameters.AddWithValue("Result", bai1.Result);
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
