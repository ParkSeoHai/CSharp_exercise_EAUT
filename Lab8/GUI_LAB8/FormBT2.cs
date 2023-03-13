using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_LAB8;
using BUS_LAB8;

namespace GUI_LAB8
{
    public partial class FormBT2 : Form
    {
        BUS_TamGiac BUS_TamGiac = new BUS_TamGiac();
        public FormBT2()
        {
            InitializeComponent();
        }
        private void LoadGridView()
        {
            dtGridViewBT2.DataSource = BUS_TamGiac.GetData();
        }
        private void ClearText()
        {
            txtCanhA.Clear();
            txtCanhB.Clear();
            txtCanhC.Clear();
        }
        private void FormBT2_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        string isTamGiac;   // Lưu giá trị có phải tam giác không
        string LoaiTamGiac; // Lưu giá trị loại tam giác
        double p = 0, s = 0; // Biến p lưu chu vi, biến s lưu diện tích
        // Xóa dữ liệu đã lưu trước đó nếu có
        public void ClearData()
        {
            isTamGiac = "";
            LoaiTamGiac = "";
            p = 0;
            s = 0;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            TamGiac TamGiac = new TamGiac(txtCanhA.Text, txtCanhB.Text, txtCanhC.Text);
            if(BUS_TamGiac.CheckTamGiac(TamGiac))
            {
                isTamGiac = "True";
                LoaiTamGiac = BUS_TamGiac.LoaiTamGiac(TamGiac);
            } else
            {
                isTamGiac = "False";
            }
            MessageBox.Show(isTamGiac + ". " + LoaiTamGiac);
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            TamGiac TamGiac = new TamGiac(txtCanhA.Text, txtCanhB.Text, txtCanhC.Text);
            if (BUS_TamGiac.CheckTamGiac(TamGiac))
            {
                s = BUS_TamGiac.DienTich(TamGiac);
                MessageBox.Show("Kết quả: " + s.ToString());
            }
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            TamGiac TamGiac = new TamGiac(txtCanhA.Text, txtCanhB.Text, txtCanhC.Text);
            if (BUS_TamGiac.CheckTamGiac(TamGiac))
            {
                p = BUS_TamGiac.ChuVi(TamGiac);
                MessageBox.Show("Kết quả: " + p.ToString());
            }
        }
        private void btnAddCSDL_Click(object sender, EventArgs e)
        {
            string CanhA = txtCanhA.Text;
            string CanhB = txtCanhB.Text;
            string CanhC = txtCanhC.Text;
            TamGiac TamGiac = new TamGiac(CanhA, CanhB, CanhC, isTamGiac, LoaiTamGiac, p.ToString(), s.ToString("N2"));
            if(BUS_TamGiac.InsertTamGiac(TamGiac))
            {
                BUS_TamGiac.InsertTamGiac(TamGiac);
                LoadGridView();
                MessageBox.Show("Thêm thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                ClearData();
            } else
            {
                MessageBox.Show("Thêm thất bại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
