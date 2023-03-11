using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6v2
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public PhanSo() { }
        public PhanSo(int tSo, int mSo)
        {
            TuSo = tSo;
            MauSo = mSo;
        }
        // Rút gọn phân số
        public void RutGon()
        {
            bool isTuSo = false;
            bool isMauSo = false;
            int ucln = 1;
            if(this.TuSo < 0)
            {
                this.TuSo *= -1;
                isTuSo = true;
            }
            if(this.MauSo < 0)
            {
                this.MauSo *= -1;
                isMauSo = true;
            }
            if(this.TuSo == 0)
            {
                ucln = this.TuSo + this.MauSo;
            }
            for (var i = 1; i <= this.TuSo; ++i)
            {
                for (var j = 1; j <= this.MauSo; ++j)
                {
                    if (this.TuSo % i == 0 && this.MauSo % j == 0 && i == j)
                    {
                        ucln = i;
                        break;
                    }
                }
            }
            this.TuSo = this.TuSo / ucln;
            this.MauSo = this.MauSo / ucln;
            if(isTuSo)
            {
                this.TuSo *= -1;
            }
            if(isMauSo)
            {
                this.TuSo *= -1;
            }
            if(isTuSo && isMauSo)
            {
                this.TuSo *= -1;
                this.MauSo *= -1;
            }
        }
        // Nap chong toan tu
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            c.MauSo = a.MauSo * b.MauSo;
            c.RutGon();
            return c;
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.MauSo - a.MauSo * b.TuSo;
            c.MauSo = a.MauSo * b.MauSo;
            c.RutGon();
            return c;
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.TuSo;
            c.MauSo = a.MauSo * b.MauSo;
            c.RutGon();
            return c;
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.MauSo;
            c.MauSo = a.MauSo * b.TuSo;
            c.RutGon();
            return c;
        }
        public override string ToString()
        {
            if (this.TuSo == 0 || this.MauSo == 0)
            {
                return "0";
            }
            else if (this.TuSo == this.MauSo)
            {
                return "1";
            }
            else if (this.MauSo == 1)
            {
                return $"{this.TuSo}";
            }
            else
                return TuSo.ToString() + " / " + MauSo.ToString();
        }
    }
}
