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
    public partial class Form5 : Form
    {
        public void DataMH(string value) { lbMH.Text = value; }
        public void DataTH(string value) { lbTenH.Text = value; }
        public void DataDG(string value) { lbGia.Text = value; }
        public Form5()
        {
            InitializeComponent();
        }
    }
}
