using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_LAB8
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioBT1.Checked)
            {
                FormBT1 bt1 = new FormBT1();
                bt1.ShowDialog();
            } else if(radioBT2.Checked)
            {
                FormBT2 bt2 = new FormBT2();
                bt2.ShowDialog();
            }
        }
    }
}
