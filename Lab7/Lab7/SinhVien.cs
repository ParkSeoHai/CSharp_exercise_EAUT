using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class SinhVien
    {
        private string MaSv;
        public string maSv { get; set; }

        private string HoTen;
        public string hoTen { get; set; }

        private string GioiTinh;
        public string gioiTinh { get; set; }

        private string Lop;
        public string lop { get; set; }

        public SinhVien(string MaSv, string HoTen, string GioiTinh, string Lop)
        {
            this.maSv = MaSv;
            this.hoTen = HoTen;
            this.gioiTinh = GioiTinh;
            this.lop = Lop;
        }
    }
}
