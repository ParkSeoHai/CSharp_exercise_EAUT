using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_LAB9
{
    public class KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private string _Sdt;
        private string _GhiChu;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }

        public KhachHang(string MaKH, string TenKH, string Sdt, string GhiChu)
        {
            this._MaKH = MaKH;
            this._TenKH = TenKH;
            this._Sdt = Sdt;
            this._GhiChu = GhiChu;
        }
    }
}
