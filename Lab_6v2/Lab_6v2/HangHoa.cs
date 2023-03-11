using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6v2
{
    public class HangHoa
    {
        string maH;
        public string MaH { get; set; }
        string tenH;
        public string TenH { get; set; }
        string donGia;
        public string DonGia { get; set; }
        public HangHoa(string MaH, string TenH, string DonGia)
        {
            this.MaH = MaH;
            this.TenH = TenH;
            this.DonGia = DonGia;
        }
    }
}
