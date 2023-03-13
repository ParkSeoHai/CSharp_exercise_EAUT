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
    public partial class FormBT1 : Form
    {
        BUS_BAI1 BUS_BAI1 = new BUS_BAI1();
        public FormBT1()
        {
            InitializeComponent();
        }
        private void FormBT1_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
        private void LoadGridView()
        {
            dtGridViewBT1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridViewBT1.DataSource = BUS_BAI1.GetDaTa();
        }
        private void ClearText()
        {
            txtSoA.Clear();
            txtSoB.Clear();
            txtResult.Clear();
        }
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1(txtSoA.Text, txtSoB.Text);
            txtResult.Text = BUS_BAI1.TinhTong(bai1).ToString();
            if(BUS_BAI1.InsertRow(bai1))
            {
                BUS_BAI1.InsertRow(bai1);
                MessageBox.Show("Đã thêm kết quả vào database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView();
                ClearText();
            } else
            {
                MessageBox.Show("Thêm không thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
