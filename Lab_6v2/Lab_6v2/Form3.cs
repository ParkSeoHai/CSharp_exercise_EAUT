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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Button chọn
        private void btnLc_Click(object sender, EventArgs e)
        {
            if(radioBt1.Checked)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            } else if(radioBt2.Checked)
            {
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
        }

        // Button thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
