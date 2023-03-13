using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyHang;
using BUS_QuanLyHang;

namespace GUI_QuanLyHang
{
    public partial class FormQuanLyHang : Form
    {
        BUS_Hang BUS_Hang = new BUS_Hang(); 
        public FormQuanLyHang()
        {
            InitializeComponent();
        }
        private void LoadGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = BUS_Hang.GetData();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }
        private void FormQuanLyHang_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadGridView();
        }
        private void ClearText()
        {
            txtMH.Clear();
            txtTH.Clear();
            txtDG.Clear();
            txtGC.Clear();
        }
        private bool CheckValueTextBox()
        {
            if(string.IsNullOrWhiteSpace(txtMH.Text))
            {
                MessageBox.Show("Chưa nhập mã hàng", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMH.Focus();
            } else if(string.IsNullOrWhiteSpace(txtTH.Text))
            {
                MessageBox.Show("Chưa nhập tên hàng", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTH.Focus();
            } else if(string.IsNullOrWhiteSpace(txtDG.Text))
            {
                MessageBox.Show("Chưa nhập đơn giá", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDG.Focus();
            } else if(string.IsNullOrWhiteSpace(txtGC.Text))
            {
                MessageBox.Show("Chưa nhập ghi chú", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGC.Focus();
            } else
            {
                return true;
            }
            return false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMH.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtTH.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtDG.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtGC.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        // Thêm dữ liệu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckValueTextBox())
            {
                Hang hang = new Hang(txtMH.Text, txtTH.Text, txtDG.Text, txtGC.Text);
                if (BUS_Hang.AddRow(hang))
                {
                    BUS_Hang.AddRow(hang);
                    MessageBox.Show("Thêm thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Sửa dữ liệu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(CheckValueTextBox())
            {
                Hang hang = new Hang(txtMH.Text, txtTH.Text, txtDG.Text, txtGC.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (BUS_Hang.EditRow(hang))
                    {
                        BUS_Hang.EditRow(hang);
                        MessageBox.Show("Sửa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Xóa dữ liệu
        private void btndelete_Click(object sender, EventArgs e)
        {
            if(CheckValueTextBox())
            {
                Hang hang = new Hang(txtMH.Text, txtTH.Text, txtDG.Text, txtGC.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (BUS_Hang.DeleteRow(hang))
                    {
                        BUS_Hang.DeleteRow(hang);
                        MessageBox.Show("Xóa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
