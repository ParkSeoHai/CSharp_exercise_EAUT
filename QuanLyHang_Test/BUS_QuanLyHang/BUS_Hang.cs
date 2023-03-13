using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyHang;
using DAL_QuanLyHang;
using System.Data;
using DTO_QuanLyHang;

namespace BUS_QuanLyHang
{
    public class BUS_Hang
    {
        DAL_Hang DAL_Hang = new DAL_Hang();
        public DataTable GetData()
        {
            return DAL_Hang.GetValue();
        }
        public bool AddRow(Hang Hang)
        {
            if(DAL_Hang.AddRow(Hang))
            {
                return true;
            } else
            {
                return false;
            }
        }
        public bool EditRow(Hang Hang)
        {
            if(DAL_Hang.EditRow(Hang))
            {
                return true;
            } else
            {
                return false;
            }
        }
        public bool DeleteRow(Hang Hang)
        {
            if(DAL_Hang.DeleteRow(Hang))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
