using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportQLHD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Model
            HoaDonModel hoaDonModel = new HoaDonModel();
            // Tạo list Hóa đơn
            List<HOADON> listHD = hoaDonModel.HOADON.ToList();

            // Tạo list report
            List<HoaDonReport> listReport = new List<HoaDonReport>();

            // Lặp list hóa đơn và gán giá trị cho HoaDonReport
            foreach(HOADON hd in listHD)
            {
                HoaDonReport temp = new HoaDonReport();
                temp.MaKH = hd.MaKH;
                temp.TenKH = hd.KHACHHANG.HoTen;
                temp.MaSP = hd.MaSP;
                temp.TenSP = hd.SANPHAM.TenSP;
                temp.NgayMua = hd.NgayMua.ToString();
                temp.SoLuong = Convert.ToInt32(hd.SoLuong);

                // Sau khi có đủ thông tin thì add vào listReport
                listReport.Add(temp);
            }

            // Gán giá trị vào reportViewer
            reportViewer1.LocalReport.ReportPath = "rbpHoaDon.rdlc";
            var source = new ReportDataSource("dsHoaDon", listReport);        // Tên dataSet, list report
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
