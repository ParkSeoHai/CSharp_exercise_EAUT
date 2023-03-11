using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Test
{
    // Bài 1
    class PhanSo
    {
        public int TuSo;
        public int MauSo;
        public PhanSo()
        {
            this.MauSo = 1;
        }
        public void NhapPS(PhanSo phanSo)
        {
            Console.Write("\nNhập tử số: ");
            phanSo.TuSo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            phanSo.MauSo = Convert.ToInt32(Console.ReadLine());
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            c.MauSo = a.MauSo * b.MauSo;
            return c;
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.MauSo = a.MauSo * b.MauSo;
            c.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            return c;
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.TuSo;
            c.MauSo = a.MauSo * b.MauSo;
            return c;
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.TuSo = a.TuSo * b.MauSo;
            c.MauSo = a.MauSo * b.TuSo;
            return c;
        }
        public override string ToString()
        {
            if (this.TuSo == 0 || this.MauSo == 0)
            {
                return "0";
            }
            else if (this.TuSo == this.MauSo)
            {
                return "1";
            }
            else
                return this.TuSo + " / " + this.MauSo;
        }
    }
    // Bài 2
    class Number
    {
        public float number;
        public Number()
        {
            this.number = 0;
        }
        public Number(float num)
        {
            this.number = num;
        }
        public static Number operator +(Number a, Number b)
        {
            Number c = new Number();
            c.number = a.number + b.number;
            return c;
        }
        public static Number operator -(Number a, Number b)
        {
            Number c = new Number();
            c.number = a.number - b.number;
            return c;
        }
        public static Number operator *(Number a, Number b)
        {
            Number c = new Number();
            c.number = a.number * b.number;
            return c;
        }
        public static Number operator /(Number a, Number b)
        {
            Number c = new Number();
            c.number = a.number / b.number;
            return c;
        }
        // Phương thức kiểm tra số nguyên tố
        public bool check_Ngto()
        {
            bool isNgto = false;
            if (this.number > 1 && this.number < 4)
            {
                isNgto = true;
                return isNgto;
            }

            for (var i = 2; i <= Math.Sqrt(this.number); ++i)
            {
                if (this.number % i == 0)
                {
                    isNgto = false;
                    return isNgto;
                }
                else
                {
                    isNgto = true;
                }
            }
            return isNgto;
        }
        // Phương thức kiểm tra số chẵn, lẻ
        public void Check_Chan_Le()
        {
            if (this.number % 2 == 0)
            {
                Console.WriteLine("Là số chẵn");
            }
            else
                Console.WriteLine("Là số lẻ");
        }
        public override string ToString() => $"{this.number}";
    }
    internal class Program
    {
        static void Menu()
        {
            int lc;
            do
            {
                Console.WriteLine("Lab5 - Lap trinh .NET");
                Console.WriteLine("1. Bai 1");
                Console.WriteLine("2. Bai 2");
                Console.WriteLine("3. Bai 3");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");
                lc = Convert.ToInt32(Console.ReadLine());
                switch(lc)
                {
                    case 1:
                        PhanSo PhanSo = new PhanSo();
                        // Tạo 2 phân số và gọi phương thức nhập phân số
                        PhanSo a = new PhanSo();
                        PhanSo.NhapPS(a);
                        PhanSo b = new PhanSo();
                        PhanSo.NhapPS(b);
                        // Phương thức nạp chồng toán tử cộng, trừ, nhân, chia 2 phân số
                        Console.WriteLine("Ket qua: {0}", a + b);
                        Console.WriteLine("Ket qua: {0}", a - b);
                        Console.WriteLine("Ket qua: {0}", a * b);
                        Console.WriteLine("Ket qua: {0}", a / b);
                        break;
                    case 2:
                        Number Number = new Number();
                        // Tạo 2 đối tượng số
                        Number x = new Number(1);
                        Number y = new Number(2);
                        // Phương thức nạp chồng tính cộng, trừ, nhân, chia 2 số
                        Console.WriteLine("Ket qua: {0}", x + y);
                        Console.WriteLine("Ket qua: {0}", x - y);
                        Console.WriteLine("Ket qua: {0}", x * y);
                        Console.WriteLine("Ket qua: {0}", x / y);
                        // Kiểm tra các kết quả có là số nguyên tố không
                        Console.WriteLine((x + y).check_Ngto() ? "La so nguyen to" : "Khong la so nguyen to");
                        Console.WriteLine((x - y).check_Ngto() ? "La so nguyen to" : "Khong la so nguyen to");
                        Console.WriteLine((x * y).check_Ngto() ? "La so nguyen to" : "Khong la so nguyen to");
                        Console.WriteLine((x / y).check_Ngto() ? "La so nguyen to" : "Khong la so nguyen to");
                        // Kiểm tra các kết quả là số chẵn hay lẻ
                        (x + y).Check_Chan_Le();
                        (x - y).Check_Chan_Le();
                        (x * y).Check_Chan_Le();
                        (x / y).Check_Chan_Le();
                        break;
                    case 3:
                        HangHoa hangHoa = new HangHoa();
                        HangHoa Hang1 = new HangHoa("H01", "Mi Tom", 12000);
                        HangHoa Hang2 = new HangHoa("H02", "Bim Bim", 20000);
                        HangHoa Hang3 = new HangHoa("H03", "Mi Cay", 15000);

                        // Tạo một mảng chứa các hàng hóa
                        HangHoa[] ListHH = new HangHoa[5] { Hang1, Hang2, Hang3, null, null };
                        Console.WriteLine("\nDanh sach hang hoa ban dau: ");
                        hangHoa.Print(ListHH);

                        // Tạo đối tượng Hang4 và Hang5 sau đó thêm vào mảng ListHH
                        HangHoa Hang4 = new HangHoa("H04", "Banh Mi", 14000);
                        hangHoa.Add(ListHH, Hang4);
                        HangHoa Hang5 = new HangHoa("H05", "Cay Cay", 11000);
                        hangHoa.Add(ListHH, Hang5);
                        Console.WriteLine("\nDanh sach hang hoa sau khi them: ");
                        hangHoa.Print(ListHH);

                        // Xóa đối tượng Hang5 ra khỏi ListHH
                        hangHoa.Remove(ListHH, Hang4);
                        Console.WriteLine("\nDanh sach hang hoa sau khi xoa: ");
                        hangHoa.Print(ListHH);

                        // Tìm và hiển thị hàng có giá cao nhất trong ListHH
                        hangHoa.Print_MaxDonGia(ListHH);

                        // Tạo 2 đối tượng khách hàng
                        KhachHang kh1 = new KhachHang("Kh01", "Nguyen Van A", "Hai Duong");
                        KhachHang kh2 = new KhachHang("Kh02", "Nguyen Van B", "Hai Phong");

                        // Tạo đối tượng hóa đơn 1
                        HoaDon hoaDon1 = new HoaDon(Hang1, kh2);
                        Console.WriteLine("\nHien thi hoa don cua khach hang: ");
                        hoaDon1.PrintHD();
                        break;
                    default:
                        Console.WriteLine("Goodbye");
                        break;
                }
            } while (lc > 0 && lc < 4);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu();
            Console.ReadKey();
        }
    }
}
