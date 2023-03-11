using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6v2
{
    public delegate void delSendData(string value);
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSend4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            HangHoa hangHoa = new HangHoa(textMaH.Text, textTenH.Text, textGiaH.Text);

            delSendData delMH = new delSendData(f5.DataMH);
            delMH(this.textMaH.Text);

            delSendData delTH = new delSendData(f5.DataTH);
            delTH(this.textTenH.Text);

            delSendData delDG = new delSendData(f5.DataDG);
            delDG(this.textGiaH.Text);

            f5.ShowDialog();
        }
    }
}