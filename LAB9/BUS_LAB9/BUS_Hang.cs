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
    public class BUS_Hang
    {
        DAL_Hang DAL_Hang = new DAL_Hang();
        public DataTable GetData()
        {
            return DAL_Hang.GetData();
        }
        // Thêm
        public bool AddRow(Hang Hang)
        {
            if(DAL_Hang.AddRow(Hang))
            {
                return true;
            }
            return false;
        }
        // Sửa
        public bool UpdateRow(Hang Hang)
        {
            if(DAL_Hang.UpdateRow(Hang))
            {
                return true;
            }
            return false;
        }
        // Xóa
        public bool DeleteRow(Hang Hang)
        {
            if(DAL_Hang.DeleteRow(Hang))
            {
                return true;
            }
            return false;
        }
    }
}
