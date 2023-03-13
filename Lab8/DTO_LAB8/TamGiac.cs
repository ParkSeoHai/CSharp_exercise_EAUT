using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_LAB8
{
    public class TamGiac
    {
        private double _CanhA;
        private double _CanhB;
        private double _CanhC;
        private double _ChuVi;
        private double _DienTich;
        private string _isTamGiac;
        private string _LoaiTamGiac;

        public double CanhA { get => _CanhA; set => _CanhA = value; }
        public double CanhB { get => _CanhB; set => _CanhB = value; }
        public double CanhC { get => _CanhC; set => _CanhC = value; }
        public double ChuVi { get => _ChuVi; set => _ChuVi = value; }
        public double DienTich { get => _DienTich; set => _DienTich = value; }
        public string IsTamGiac { get => _isTamGiac; set => _isTamGiac = value; }
        public string LoaiTamGiac { get => _LoaiTamGiac; set => _LoaiTamGiac = value; }
        public TamGiac(string CanhA, string CanhB, string CanhC)
        {
            this._CanhA = Convert.ToDouble(CanhA);
            this._CanhB = Convert.ToDouble(CanhB);
            this._CanhC = Convert.ToDouble(CanhC);
        }
        public TamGiac(double CanhA, double CanhB, double CanhC)
        {
            this._CanhA = CanhA;
            this._CanhB = CanhB;
            this._CanhC = CanhC;
        }

        public TamGiac( string CanhA, string CanhB, string CanhC, string IsTamGiac, string LoaiTamGiac, string ChuVi, string DienTich) 
        {
            this._CanhA = Convert.ToDouble(CanhA);
            this._CanhB = Convert.ToDouble(CanhB);
            this._CanhC = Convert.ToDouble(CanhC);
            this._isTamGiac = IsTamGiac;
            this._LoaiTamGiac = LoaiTamGiac;
            this._ChuVi = Convert.ToDouble(ChuVi);
            this._DienTich = Convert.ToDouble(DienTich);
        }
        
        public TamGiac(double CanhA, double CanhB, double CanhC, string IsTamGiac, string LoaiTamGiac, double ChuVi, double DienTicnh)
        {
            this._CanhA = CanhA;
            this._CanhB = CanhB;
            this._CanhC = CanhC;
            this._isTamGiac = IsTamGiac;
            this._LoaiTamGiac = LoaiTamGiac;
            this._ChuVi = ChuVi;
            this._DienTich = DienTicnh;
        }
    }
}
