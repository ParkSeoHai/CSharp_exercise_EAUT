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
    public class DAL_HoaDon : DBConnect
    {
        public DataTable GetDataHoaDon()
        {
            string querySelect = "Select * from HoaDon";
            SqlDataAdapter adapter = new SqlDataAdapter(querySelect, connString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Thêm
        public bool AddRow(HoaDon HoaDon)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string queryInsert = "Insert into HoaDon Values (@MaHD, @MaKH, @NgayHD, @GhiChu)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.Parameters.AddWithValue("MaHD", HoaDon.MaHD);
                cmd.Parameters.AddWithValue("MaKH", HoaDon.MaKH);
                cmd.Parameters.AddWithValue("NgayHD", HoaDon.NgayHD);
                cmd.Parameters.AddWithValue("GhiChu", HoaDon.GhiChu);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            } catch { }
            finally { conn.Close(); }
            return false;
        }
        // Sửa
        public bool EditRow(HoaDon HoaDon)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string queryUpdate = "Update HoaDon Set MaKH = @MaKH, NgayHD = @NgayHD, GhiChu = @GhiChu where MaHD = @MaHD";
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                cmd.Parameters.AddWithValue("MaHD", HoaDon.MaHD);
                cmd.Parameters.AddWithValue("MaKH", HoaDon.MaKH);
                cmd.Parameters.AddWithValue("NgayHD", HoaDon.NgayHD);
                cmd.Parameters.AddWithValue("GhiChu", HoaDon.GhiChu);
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
        public bool DeleteRow(HoaDon HoaDon)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string queryUpdate = "Delete HoaDon where MaHD = @MaHD";
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                cmd.Parameters.AddWithValue("MaHD", HoaDon.MaHD);
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
