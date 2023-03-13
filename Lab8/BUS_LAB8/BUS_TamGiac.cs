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
    public class BUS_TamGiac
    {
        DAL_TamGiac DAL_TamGiac = new DAL_TamGiac();
        public DataTable GetData()
        {
            return DAL_TamGiac.GetData();
        }
        public bool CheckTamGiac(TamGiac TamGiac)
        {
            if(DAL_TamGiac.CheckTamGiac(TamGiac))
            {
                return true;
            }
            return false;
        }
        public string LoaiTamGiac(TamGiac TamGiac)
        {
            return DAL_TamGiac.LoaiTamGiac(TamGiac);
        }
        public double ChuVi(TamGiac TamGiac)
        {
            return DAL_TamGiac.ChuVi(TamGiac);
        }
        public double DienTich(TamGiac TamGiac)
        {
            return DAL_TamGiac.DienTich(TamGiac) ;
        }
        public bool InsertTamGiac(TamGiac TamGiac)
        {
            if(DAL_TamGiac.InsertTamGiac(TamGiac))
            {
                return true;
            }
            return false;
        }
    }
}
