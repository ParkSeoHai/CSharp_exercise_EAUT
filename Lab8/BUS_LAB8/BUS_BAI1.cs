using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_LAB8;
using DAL_LAB8;
using System.Data;

namespace BUS_LAB8
{
    public class BUS_BAI1
    {
        DAL_BAI1 DAL_BAI1 = new DAL_BAI1();
        public DataTable GetDaTa()
        {
            return DAL_BAI1.GetData();
        }
        public int TinhTong(Bai1 bai1)
        {
            return DAL_BAI1.TinhTong(bai1);
        }
        public bool InsertRow(Bai1 bai1)
        {
            if(DAL_BAI1.InsertRow(bai1))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
