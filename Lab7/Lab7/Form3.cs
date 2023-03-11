using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form3 : Form
    {
        List<SinhVien> listSv;

        public Form3()
        {
            InitializeComponent();
            LoadGridView();
        }
        void LoadGridView()
        {
            dataGridSv.Columns.Add("MaSv", "Mã sinh viên");
            dataGridSv.Columns.Add("HoTen", "Họ và tên");
            dataGridSv.Columns.Add("GioiTinh", "Giới tính");
            dataGridSv.Columns.Add("Lop", "Lớp");

            dataGridSv.ReadOnly = true;

            dataGridSv.Columns[0].DataPropertyName = "maSv";
            dataGridSv.Columns[1].DataPropertyName = "hoTen";
            dataGridSv.Columns[2].DataPropertyName = "gioiTinh";
            dataGridSv.Columns[3].DataPropertyName = "lop";

            listSv = new List<SinhVien>()
            {
                new SinhVien("20210864", "Nguyễn Văn Hải", "Nam", "IT3"),
                new SinhVien("20210442", "Nguyễn Thị Hoa", "Nữ", "IT3"),
                new SinhVien("20210111", "Nguyễn Văn Nam", "Nam","IT3")
            };
            LoadDataSource();
        }

        void LoadDataSource()
        {
            dataGridSv.DataSource = null;
            dataGridSv.DataSource = listSv;
            dataGridSv.Refresh();
        }

        // Button Add
        private void btnAddGridView_Click(object sender, EventArgs e)
        {   
            if(string.IsNullOrWhiteSpace(tbMsv.Text) || string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbGioiTinh.Text) || string.IsNullOrWhiteSpace(tbClass.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                SinhVien sv = new SinhVien(tbMsv.Text, tbName.Text, tbGioiTinh.Text, tbClass.Text);
                listSv.Add(sv);

                LoadDataSource();

                tbMsv.Clear();
                tbName.Clear();
                tbGioiTinh.Clear();
                tbClass.Clear();
            }
        }

        // Button sửa
        private void btnSuaGrid_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result ==  DialogResult.Yes)
            {
                if (index >= 0)
                {
                    listSv[index].maSv = tbMsv.Text;
                    listSv[index].hoTen = tbName.Text;
                    listSv[index].gioiTinh = tbGioiTinh.Text;
                    listSv[index].lop = tbClass.Text;

                    LoadDataSource();
                    tbMsv.Clear();
                    tbName.Clear();
                    tbGioiTinh.Clear();
                    tbClass.Clear();
                }
            }
        }

        // event sell click dataGridView (Lấy ra chỉ mục được chọn trong DataGridView)
        int index;
        private void dataGridSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMsv.Text = listSv[index].maSv;
                tbName.Text = listSv[index].hoTen;
                tbGioiTinh.Text = listSv[index].gioiTinh;
                tbClass.Text = listSv[index].lop;
            }
        }

        // Button xóa
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    
            if(result == DialogResult.Yes)
            {
                if (index >= 0)
                {
                    listSv.Remove(listSv[index]);
                    LoadDataSource();

                    tbMsv.Clear();
                    tbName.Clear();
                    tbGioiTinh.Clear();
                    tbClass.Clear();
                }
            }
        }

        // Button sắp xếp theo họ tên
        private void btnSort_Click(object sender, EventArgs e)
        {
            listSv.Sort((a, b) => a.hoTen.CompareTo(b.hoTen));
            LoadDataSource();
        }
    }
}
