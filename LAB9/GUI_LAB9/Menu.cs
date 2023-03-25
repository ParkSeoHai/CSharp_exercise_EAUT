using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_LAB9
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(radioQLH.Checked)
            {
                FormQuanLyHang fQLH = new FormQuanLyHang();
                fQLH.ShowDialog();
            } else if(radioQLHD.Checked)
            {
                FormQuanLyHoaDon fQLHD = new FormQuanLyHoaDon();
                fQLHD.ShowDialog();
            } else if(radioQLKH.Checked)
            {
                FormQuanLyKhachHang fQLKH = new FormQuanLyKhachHang();
                fQLKH.ShowDialog();
            }
        }
    }
}
