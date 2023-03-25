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
    public class DAL_KhachHang : DBConnect
    {
        public DataTable GetData()
        {
            string queryInsert = "Select * from KhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(queryInsert, connString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Thêm
        public bool AddRow(KhachHang KhachHang)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string queryInsert = "Insert into KhachHang values (@MaKH, @TenKH, @Sdt, @GhiChu)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.Parameters.AddWithValue("MaKH", KhachHang.MaKH);
                cmd.Parameters.AddWithValue("TenKH", KhachHang.TenKH);
                cmd.Parameters.AddWithValue("Sdt", KhachHang.Sdt);
                cmd.Parameters.AddWithValue("GhiChu", KhachHang.GhiChu);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            } catch { }
            finally { conn.Close(); }
            return false;
        }
        // Sửa
        public bool EditRow(KhachHang KhachHang)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string queryUpdate = "Update KhachHang Set TenKH = @TenKH, SDT = @Sdt, GhiChu = @GhiChu where MaKH = @MaKH";
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                cmd.Parameters.AddWithValue("MaKH", KhachHang.MaKH);
                cmd.Parameters.AddWithValue("TenKH", KhachHang.TenKH);
                cmd.Parameters.AddWithValue("Sdt", KhachHang.Sdt);
                cmd.Parameters.AddWithValue("GhiChu", KhachHang.GhiChu);
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
        public bool DeleteRow(KhachHang KhachHang)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string queryUpdate = "Delete KhachHang where MaKH = @MaKH";
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                cmd.Parameters.AddWithValue("MaKH", KhachHang.MaKH);
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
