using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyHang;

namespace DAL_QuanLyHang
{
    public class DAL_Hang : DBconnect
    {
        public DataTable GetValue()
        {
            string query = "Select * from HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool AddRow(Hang Hang)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                string queryInsert = "Insert into HANG values (@MaH, @TenH, @DonGia, @GhiChu)";
                SqlCommand cmd = new SqlCommand(queryInsert, connection);
                cmd.Parameters.AddWithValue("MaH", Hang.MaH);
                cmd.Parameters.AddWithValue("TenH", Hang.TenH);
                cmd.Parameters.AddWithValue("DonGia", Hang.DonGia);
                cmd.Parameters.AddWithValue("GhiChu", Hang.GhiChu);
                // executeNonQuery trả về số dòng bị thay đổi
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool EditRow(Hang Hang)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string queryUpdate = "Update HANG set TenH = @TenH, DonGia = @DonGia, GhiChu = @GhiChu where MaH = @MaH";
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
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
        public bool DeleteRow(Hang Hang)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string queryDelete = "Delete HANG WHERE MaH = @MaH";
                SqlCommand cmd = new SqlCommand(queryDelete, conn);
                cmd.Parameters.AddWithValue("MaH", Hang.MaH);
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
