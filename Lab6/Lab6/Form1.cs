using System.Transactions;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhanSo phanSo = new PhanSo();
            PhanSo psA = new PhanSo(Convert.ToInt32(tSoA.Text), Convert.ToInt32(mSoA.Text));
            PhanSo psB = new PhanSo(Convert.ToInt32(tSoB.Text), Convert.ToInt32(mSoB.Text));

            MessageBox.Show((psA + psB).ToString());
            MessageBox.Show((psA - psB).ToString());
            MessageBox.Show((psA * psB).ToString());
            MessageBox.Show((psA / psB).ToString());
        }
    }
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public PhanSo() { }
        public PhanSo(int tSo, int mSo) 
        {
            TuSo = tSo;
            MauSo = mSo;
        }
        public static PhanSo operator +(PhanSo pSoA, PhanSo pSoB)
        {
            PhanSo c = new PhanSo();
            c.MauSo = pSoA.MauSo * pSoB.MauSo;
            c.TuSo = pSoA.TuSo * pSoB.MauSo + pSoA.MauSo * pSoB.TuSo;
            return c;
        }
        public static PhanSo operator -(PhanSo pSoA, PhanSo pSoB)
        {
            PhanSo c = new PhanSo();
            c.MauSo = pSoA.MauSo * pSoB.MauSo;
            c.TuSo = pSoA.TuSo * pSoB.MauSo - pSoA.MauSo * pSoB.TuSo;
            return c;
        }
        public static PhanSo operator *(PhanSo pSoA, PhanSo pSoB)
        {
            PhanSo c = new PhanSo();
            c.TuSo = pSoA.TuSo * pSoB.TuSo;
            c.MauSo = pSoA.MauSo * pSoB.MauSo;
            return c;
        }
        public static PhanSo operator /(PhanSo pSoA, PhanSo pSoB)
        {
            PhanSo c = new PhanSo();
            c.TuSo = pSoA.TuSo * pSoB.MauSo;
            c.MauSo = pSoA.MauSo * pSoB.TuSo;
            return c;
        }
        public override string ToString()
        {
            string s;
            if(TuSo == MauSo)
            {
                s = "1";
            } else if(TuSo == 0 || MauSo == 0)
            {
                s = "0";
            } else
            {
                s = $"{TuSo} / {MauSo}";
            }
            return s;
        }
    }
}