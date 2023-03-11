using System;
using System.Text;

namespace Lab_3 {
    class Program 
    {
        static void Menu()
        {
            int luachon;
            do
            {
                Console.WriteLine("\nLab 3 - Lập trình .NET");
                Console.WriteLine("1. Bài tập 1");
                Console.WriteLine("2. Bài tập 2");
                Console.WriteLine("3. Bài tập 3");
                Console.WriteLine("4. Bài tập 4");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("------------");
                Console.Write("Nhập lựa chọn của bạn: ");
                luachon = int.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        Bai1 bai1 = new Bai1();
                        Console.Write("Nhập a: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhập b: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        
                        bai1.Tong(a, b);
                        bai1.Hieu(a, b);
                        bai1.Tich(a, b);
                        bai1.Thuong(a, b);
                        Console.ReadKey();
                        break;
                    case 2:
                        Bai2 bai2 = new Bai2();
                        Console.Write("Nhập độ dài cạnh đáy: ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhập độ dài 2 cạnh: ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        double z = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhập độ dài chiều cao: ");
                        double h = Convert.ToDouble(Console.ReadLine());

                        bai2.dien_tich(x, h);
                        bai2.chu_vi(x, y, z);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Nhập mã sinh viên: ");
                        int maSv = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhập họ tên sinh viên: ");
                        string hoTenSv = Convert.ToString(Console.ReadLine());
                        Console.Write("Nhập tuổi sinh viên: ");
                        int tuoiSv = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhập giới tính sinh viên: ");
                        string gioiTinhSv = Convert.ToString(Console.ReadLine());
                        Console.Write("Nhập quê quán sinh viên: ");
                        string queQuanSv = Convert.ToString(Console.ReadLine());

                        sinhVien SV = new sinhVien(maSv, hoTenSv, tuoiSv, gioiTinhSv, queQuanSv);
                        sinhVien.printSv(maSv, hoTenSv, tuoiSv, gioiTinhSv, queQuanSv);
                        Console.ReadKey();
                        break;
                    case 4:
                        Bai4 DIEM1 = new Bai4(1, 2);
                        Bai4 DIEM2 = new Bai4(5, 3);
                        
                        double kc = Bai4.KhoangCach(DIEM1, DIEM2);
                        Console.WriteLine("Khoảng cách 2 điểm là " + kc);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("GoodBye!");
                        Console.ReadKey();
                        break;
                }
            } while (luachon > 0 && luachon < 5);
        }
        static void Main(string[] args) {
            // Get UTF-8 and UTF-16 encoders.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu();
        }
    }
}