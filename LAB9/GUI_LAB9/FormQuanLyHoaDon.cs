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
    public partial class FormQuanLyHoaDon : Form
    {
        BUS_HoaDon BUS_HoaDon = new BUS_HoaDon();
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            dtGridHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridHoaDon.DataSource = BUS_HoaDon.GetDataHoaDon();
        }
        private bool CheckTextBox()
        {
            if(string.IsNullOrWhiteSpace(txtMHD.Text))
            {
                MessageBox.Show("Chưa nhập mã hóa đơn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(string.IsNullOrWhiteSpace(txtMKH.Text))
            {
                MessageBox.Show("Chưa nhập mã khách hàng", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(string.IsNullOrWhiteSpace(txtGC.Text))
            {
                MessageBox.Show("Chưa nhập ghi chú", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                return true;
            }
            return false;
        }
        private void ClearText()
        {
            txtMHD.Clear();
            txtMKH.Clear();
            txtGC.Clear();
        }
        private void dtGridHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMHD.Text = dtGridHoaDon.SelectedCells[0].Value.ToString();
            txtMKH.Text = dtGridHoaDon.SelectedCells[1].Value.ToString();
            dateTimeHD.Value = DateTime.Parse(dtGridHoaDon.SelectedCells[2].Value.ToString());
            txtGC.Text = dtGridHoaDon.SelectedCells[3].Value.ToString();
        }

        // Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(CheckTextBox())
            {
                DateTime NgayHD = dateTimeHD.Value;
                HoaDon HoaDon = new HoaDon(txtMHD.Text, txtMKH.Text, NgayHD.ToString(), txtGC.Text);
                if(BUS_HoaDon.AddRow(HoaDon))
                {
                    BUS_HoaDon.AddRow(HoaDon);
                    MessageBox.Show("Thêm thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    ClearText();
                } else
                {
                    MessageBox.Show("Thêm thất bại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if (CheckTextBox())
                {
                    DateTime NgayHD = dateTimeHD.Value;
                    HoaDon HoaDon = new HoaDon(txtMHD.Text, txtMKH.Text, NgayHD.ToString(), txtGC.Text);
                    if (BUS_HoaDon.EditRow(HoaDon))
                    {
                        BUS_HoaDon.EditRow(HoaDon);
                        MessageBox.Show("Sửa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid();
                        ClearText();
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
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (CheckTextBox())
                {
                    DateTime NgayHD = dateTimeHD.Value;
                    HoaDon HoaDon = new HoaDon(txtMHD.Text, txtMKH.Text, NgayHD.ToString(), txtGC.Text);
                    if (BUS_HoaDon.DeleteRow(HoaDon))
                    {
                        BUS_HoaDon.DeleteRow(HoaDon);
                        MessageBox.Show("Xóa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid();
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
