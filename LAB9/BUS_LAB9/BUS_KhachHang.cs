using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_LAB9;
using DAL_LAB9;
using System.Data;

namespace BUS_LAB9
{
    public class BUS_KhachHang
    {
        DAL_KhachHang DAL_KhachHang = new DAL_KhachHang();
        public DataTable GetData()
        {
            return DAL_KhachHang.GetData();
        }
        // Thêm
        public bool AddRow(KhachHang KhachHang)
        {
            if(DAL_KhachHang.AddRow(KhachHang))
            {
                return true;
            }
            return false;
        }
        // Sửa
        public bool EditRow(KhachHang KhachHang)
        {
            if(DAL_KhachHang.EditRow(KhachHang))
            {
                return true;
            }
            return false;
        }
        // Xóa
        public bool DeleteRow(KhachHang KhachHang)
        {
            if(DAL_KhachHang.DeleteRow(KhachHang))
            {
                return true;
            }
            return false;
        }
    }
}
