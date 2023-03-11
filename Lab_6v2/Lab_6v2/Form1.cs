namespace Lab_6v2
{
    public partial class Form1 : Form
    {
        public delegate void delPassData(string result);
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            PhanSo psA = new PhanSo(Convert.ToInt32(textTsA.Text), Convert.ToInt32(textMsA.Text));
            PhanSo psB = new PhanSo(Convert.ToInt32(textTsB.Text), Convert.ToInt32(textMsB.Text));

            delPassData delTong = new delPassData(f2.DataTong);
            string tong = (psA + psB).ToString();
            delTong("Tong: " + tong);

            delPassData delHieu = new delPassData(f2.DataHieu);
            string hieu = (psA - psB).ToString();
            delHieu("Hieu: " + hieu);

            delPassData delTich = new delPassData(f2.DataTich);
            string tich = (psA * psB).ToString();
            delTich("Tich: " + tich);

            delPassData delThuong = new delPassData(f2.DataThuong);
            string thuong = (psA / psB).ToString();
            delThuong("Thuong: " + thuong);

            f2.Show();
        }
    }
}