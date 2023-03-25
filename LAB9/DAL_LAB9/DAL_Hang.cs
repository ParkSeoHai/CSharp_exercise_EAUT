using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_LAB9;

namespace DAL_LAB9
{
    public class DAL_Hang : DBConnect
    {
        public DataTable GetData()
        {
            string querySelect = "Select * from Hang";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, connString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Thêm
        public bool AddRow(Hang Hang)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string queryInsert = "Insert into Hang values (@MaH, @TenH, @DonGia, @GhiChu)";
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.Parameters.AddWithValue("MaH", Hang.MaH);
                cmd.Parameters.AddWithValue("TenH", Hang.TenH);
                cmd.Parameters.AddWithValue("DonGia", Hang.DonGia);
                cmd.Parameters.AddWithValue("GhiChu", Hang.GhiChu);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Sửa
        public bool UpdateRow(Hang Hang)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string queryUpdate = "Update Hang set TenH = @TenH, DonGia = @DonGia, GhiChu = @GhiChu where MaH = @MaH";
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                cmd.Parameters.AddWithValue("MaH", Hang.MaH);
                cmd.Parameters.AddWithValue("TenH", Hang.TenH);
                cmd.Parameters.AddWithValue("DonGia", Hang.DonGia);
                cmd.Parameters.AddWithValue("GhiChu", Hang.GhiChu);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Xóa
        public bool DeleteRow(Hang Hang)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string queryDelete = "Delete Hang where MaH = @MaH";
                SqlCommand cmd = new SqlCommand(queryDelete, conn);
                cmd.Parameters.AddWithValue("MaH", Hang.MaH);
                if (cmd.ExecuteNonQuery() > 0)
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
