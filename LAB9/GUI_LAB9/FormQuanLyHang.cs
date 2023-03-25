using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_LAB9;
using DTO_LAB9;

namespace GUI_LAB9
{
    public partial class FormQuanLyHang : Form
    {
        BUS_Hang BUS_Hang = new BUS_Hang();
        public FormQuanLyHang()
        {
            InitializeComponent();
        }
        private void LoadDataGrid()
        {
            dtGridHang.DataSource = BUS_Hang.GetData();
        }
        private void FormQuanLyHang_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void ClearTextBox()
        {
            txtMH.Clear();
            txtTH.Clear();
            txtDG.Clear();
            txtGC.Clear();
        }
        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(txtMH.Text))
            {
                MessageBox.Show("Chưa nhập mã hàng");
                txtMH.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTH.Text))
            {
                MessageBox.Show("Chưa nhập tên hàng");
                txtTH.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtDG.Text))
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtDG.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtGC.Text))
            {
                MessageBox.Show("Chưa nhập ghi chú");
                txtGC.Focus();
            } else
            {
                return true;
            }
            return false;
        }
        private void dtGridHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMH.Text = dtGridHang.SelectedCells[0].Value.ToString();
            txtTH.Text = dtGridHang.SelectedCells[1].Value.ToString();
            txtDG.Text = dtGridHang.SelectedCells[2].Value.ToString();
            txtGC.Text = dtGridHang.SelectedCells[3].Value.ToString();
        }

        // Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(CheckTextBox())
            {
                Hang hang = new Hang(txtMH.Text, txtTH.Text, Convert.ToDouble(txtDG.Text), txtGC.Text);
                if(BUS_Hang.AddRow(hang))
                {
                    BUS_Hang.AddRow(hang);
                    MessageBox.Show("Thêm thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    LoadDataGrid();
                } else
                {
                    MessageBox.Show("Thêm thất bại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if (CheckTextBox())
                {
                    Hang hang = new Hang(txtMH.Text, txtTH.Text, Convert.ToDouble(txtDG.Text), txtGC.Text);
                    if (BUS_Hang.UpdateRow(hang))
                    {
                        BUS_Hang.UpdateRow(hang);
                        MessageBox.Show("Sửa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBox();
                        LoadDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (CheckTextBox())
                {
                    Hang hang = new Hang(txtMH.Text, txtTH.Text, Convert.ToDouble(txtDG.Text), txtGC.Text);
                    if (BUS_Hang.DeleteRow(hang))
                    {
                        BUS_Hang.DeleteRow(hang);
                        MessageBox.Show("Xóa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBox();
                        LoadDataGrid();
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
