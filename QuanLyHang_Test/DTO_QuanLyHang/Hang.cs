using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyHang
{
    public class Hang
    {
        private string _MaH;
        private string _TenH;
        private string _DonGia;
        private string _GhiChu;
        public string MaH { get => _MaH; set => _MaH = value; }
        public string TenH { get => _TenH; set => _TenH = value; }
        public string DonGia { get => _DonGia; set => _DonGia = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public Hang(string MaH, string TenH, string DonGia, string GhiChu) {
            this._MaH = MaH;
            this._TenH = TenH;
            this._DonGia = DonGia;
            this._GhiChu = GhiChu;
        }
    }
}
