using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Test
{
    class HoaDon
    {
        public HangHoa hangHoa;
        public KhachHang khachHang;
        public HoaDon(HangHoa hangHoa, KhachHang khachHang) 
        {
            this.hangHoa = hangHoa;
            this.khachHang = khachHang;
        }
        public void PrintHD()
        {
            Console.WriteLine("Don hang: {0} {1} {2}\nThong tin khach mua: {3} {4} {5}\n", hangHoa.MaH, hangHoa.TenH, hangHoa.DonGia, khachHang.MaK, khachHang.TenK, khachHang.DiaChi);
        }
    }
}
