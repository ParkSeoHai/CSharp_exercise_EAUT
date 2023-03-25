using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_LAB9
{
    public class HoaDon
    {
        private string _MaHD;
        private string _MaKH;
        private string _NgayHD;
        private string _GhiChu;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string NgayHD { get => _NgayHD; set => _NgayHD = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }

        public HoaDon(string MaHD, string MaKH, string NgayHD, string GhiChu)
        {
            this._MaHD = MaHD;
            this._MaKH = MaKH;
            this._NgayHD = NgayHD;
            this._GhiChu = GhiChu;
        }
    }
}
