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
    public partial class Form2 : Form
    {
        public void DataTong(string value) { lbTong.Text = value; }
        public void DataHieu(string value) { lbHieu.Text = value; }
        public void DataTich(string value) { lbTich.Text = value; }
        public void DataThuong(string value) { lbThuong.Text = value; }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
