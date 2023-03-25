using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_LAB9;
using DTO_LAB9;

namespace BUS_LAB9
{
    public class BUS_HoaDon
    {
        DAL_HoaDon DAL_HoaDon = new DAL_HoaDon();
        public DataTable GetDataHoaDon()
        {
            return DAL_HoaDon.GetDataHoaDon();
        }
        // Thêm
        public bool AddRow(HoaDon HoaDon)
        {
            if(DAL_HoaDon.AddRow(HoaDon)) {
                return true;
            }
            return false;
        }
        // Sửa
        public bool EditRow(HoaDon HoaDon)
        {
            if(DAL_HoaDon.EditRow(HoaDon))
            {
                return true;
            }
            return false;
        } 
        // Xóa
        public bool DeleteRow(HoaDon HoaDon)
        {
            if(DAL_HoaDon.DeleteRow(HoaDon))
            {
                return true;
            }
            return false;
        }
    }
}
