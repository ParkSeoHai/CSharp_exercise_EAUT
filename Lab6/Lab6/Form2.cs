using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // List user (Tài khoản & Password)
        List<User> users = new List<User>()
            {
                new User("Admin1", "123"),
                new User("Admin2", "123"),
                new User("Admin3", "123")
            };

        // Phương thức kiểm tra tài khoản và mật khẩu
        public bool CheckUser()
        {
            bool isCheck = false;
            foreach (User user in users)
            {
                if(user.TaiKhoan == taiKhoan.Text && user.Password == password.Text)
                {
                    isCheck = true;
                    return isCheck;
                }
                else
                {
                    isCheck = false;
                }
            }
            return isCheck;
        }
        // Button Click đăng nhập
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            if (taiKhoan.Text != "" && password.Text != "")
            {
                if(CheckUser())
                {
                    form1.ShowDialog();
                } else
                {
                    MessageBox.Show("Tai khoan hoac mat khau khong dung", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(taiKhoan.Text == "")
                {
                    MessageBox.Show("Chua nhap tai khoan", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                } else if(password.Text == "")
                {
                    MessageBox.Show("Chua nhap mat khau", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show("Tai khoan va mat khau dang trong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        // Button Click đăng ký
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }

    // Class lưu thông tin tài khoản và mật khẩu của User
    public class User
    {
        public string TaiKhoan { get; set; }
        public string Password { get; set; }
        public User(string tk, string mk)
        {
            TaiKhoan = tk;
            Password = mk;
        }
    }
}
