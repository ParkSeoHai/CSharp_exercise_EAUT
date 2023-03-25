using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_LAB9;
using BUS_LAB9;

namespace GUI_LAB9
{
    public partial class FormQuanLyKhachHang : Form
    {
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            dtGridKhacHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridKhacHang.DataSource = BUS_KhachHang.GetData();
        }
        private void ClearText()
        {
            txtMKH.Clear();
            txtTKH.Clear();
            txtSDT.Clear();
            txtGC.Clear();
        }
        private bool CheckTextBox()
        {
            if(string.IsNullOrWhiteSpace(txtMKH.Text))
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                txtMKH.Focus();
            } else if(string.IsNullOrWhiteSpace(txtTKH.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                txtTKH.Focus();
            } else if(string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txtSDT.Focus();
            } else if(string.IsNullOrWhiteSpace(txtGC.Text))
            {
                MessageBox.Show("Chưa nhập ghi chú");
                txtGC.Focus();
            } else
            {
                return true;
            }
            return false;
        }
        private void dtGridKhacHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMKH.Text = dtGridKhacHang.SelectedCells[0].Value.ToString();
            txtTKH.Text = dtGridKhacHang.SelectedCells[1].Value.ToString();
            txtSDT.Text = dtGridKhacHang.SelectedCells[2].Value.ToString();
            txtGC.Text = dtGridKhacHang.SelectedCells[3].Value.ToString();
        }

        // Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckTextBox()) {
                KhachHang KH = new KhachHang(txtMKH.Text, txtTKH.Text, txtSDT.Text, txtGC.Text);
                if(BUS_KhachHang.AddRow(KH))
                {
                    BUS_KhachHang.AddRow(KH);
                    MessageBox.Show("Thêm thành công");
                    ClearText();
                    LoadDataGrid();
                } else
                {
                    MessageBox.Show("Thêm thất bại");
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
                    KhachHang KH = new KhachHang(txtMKH.Text, txtTKH.Text, txtSDT.Text, txtGC.Text);
                    if (BUS_KhachHang.EditRow(KH))
                    {
                        BUS_KhachHang.EditRow(KH);
                        MessageBox.Show("Sửa thành công");
                        ClearText();
                        LoadDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
        }
        // Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK) {
                if (CheckTextBox())
                {
                    KhachHang KH = new KhachHang(txtMKH.Text, txtTKH.Text, txtSDT.Text, txtGC.Text);
                    if (BUS_KhachHang.DeleteRow(KH))
                    {
                        BUS_KhachHang.DeleteRow(KH);
                        MessageBox.Show("Xóa thành công");
                        ClearText();
                        LoadDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }
    }
}