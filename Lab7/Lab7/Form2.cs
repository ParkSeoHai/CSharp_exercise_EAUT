using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(radioBtnBt1.Checked)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            } else if(radioBtnBt2.Checked)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}