namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadListView();
            LoadPictureBox();
        }
        // Hàm tạo PictureBox bằng code
        void LoadPictureBox()
        {
            // Hình ảnh hiển thị mặc định trong picture box
            pictureBox.Image = Image.FromFile("D:\\Workspace\\C#\\WindowsForm\\Lab7\\Lab7\\Img\\1.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Hàm tạo listView bằng code
        void LoadListView()
        {
            listViewSv.View = View.Details;     // Set view của listView là Details
            listViewSv.FullRowSelect = true;    
            listViewSv.GridLines = true;        // Kẻ dòng


            // Thêm các cột
            listViewSv.Columns.Add("STT");
            listViewSv.Columns.Add("Mã sinh viên");
            listViewSv.Columns.Add("Họ tên sinh viên");
            listViewSv.Columns.Add("Giới tính");
            listViewSv.Columns.Add("Lớp");
            listViewSv.Columns.Add("Url Hình ảnh");

            // nếu click vào hàng thì kiểm tra url có đúng ko, Nếu đúng hiển thị hình ảnh trong pictureBox
            listViewSv.Click += delegate
            {
                string url = listViewSv.SelectedItems[0].SubItems[5].Text;

                if(url != "")
                {
                    pictureBox.Image = Image.FromFile(url);
                } else
                {
                    MessageBox.Show("Không có url hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            // Autosize theo header
            listViewSv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        // Biến stt lưu số thứ tự trong listView
        int stt = 1;
        // Button Add
        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa nhập đủ dữ liệu thì bật thông báo lỗi
            if (string.IsNullOrEmpty(textMsv.Text) || string.IsNullOrEmpty(textName.Text) || 
                string.IsNullOrEmpty(textGt.Text) || string.IsNullOrEmpty(textClass.Text))
            {
                MessageBox.Show("Vui lòng điền đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            } else
            {
                // Tạo đối tượng sinh viên và thêm vào listView
                SinhVien sv = new SinhVien(textMsv.Text, textName.Text, textGt.Text, textClass.Text);

                ListViewItem item = new ListViewItem();
                item.Text = stt.ToString();

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sv.maSv });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sv.hoTen });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sv.gioiTinh });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sv.lop });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = textUrlImg.Text});

                listViewSv.Items.Add(item);

                // Mỗi khi click button sẽ xóa dữ liệu vừa nhập trong các textBox
                textMsv.Clear();
                textName.Clear();
                textGt.Clear();
                textClass.Clear();
                textUrlImg.Clear();
                textMsv.Focus();
                ++stt;
            }
        }

        // Button xóa listView  (Xóa hết)
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa hết?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                listViewSv.Items.Clear();
                pictureBox.Image = Image.FromFile("D:\\Workspace\\C#\\WindowsForm\\Lab7\\Lab7\\Img\\1.png");
            }
        }

        // Show dialog chọn đường dẫn đến url hình ảnh trong thư mục
        private void btnUrlImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.RestoreDirectory = true;
            if(fdlg.ShowDialog() == DialogResult.OK)
            {
                textUrlImg.Text = fdlg.FileName;
            }
        }
    }
}