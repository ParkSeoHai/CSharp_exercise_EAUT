using System;
using System.Text;

namespace Lab_5
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
            if(this.TuSo == 0 || this.MauSo == 0)
            {
                return "0";
            } else if(this.TuSo == this.MauSo)
            {
                return "1";
            }else
                return this.TuSo + " / " + this.MauSo;
        }
    }

    // Bài 2
    class Number
    {
        public float number;

        public Number() { 
            this.number = 0;
        }

        public Number (float num)
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

        // Method kiểm tra số nguyên tố
        public bool check_Ngto()
        {
            bool isNgto = false;
            if (this.number > 1 && this.number < 4)
            {
                isNgto = true;
            }

            for (var i = 2; i <= Math.Sqrt(this.number); ++i)
            {
                if (this.number % i == 0)
                {
                    isNgto = false;
                }
                else
                {
                    isNgto = true;
                }
            }
            return isNgto;
        }

        // Method kiểm tra số chẵn, lẻ
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

    // Bài 3
    class HangHoa
    {
        public string maH;
        public string tenH;
        public double donGia;

        public HangHoa(string MaH, string TenH, double DonGia)
        {
            this.maH = MaH;
            this.tenH = TenH;
            this.donGia = DonGia;
        }

        public HangHoa() { }
    }

    class KhachHang
    {
        public string maK;
        public string tenK;
        public string diaChi;

        public KhachHang(string MaK, string TenK, string DiaChi)
        {
            this.maK = MaK;
            this.tenK = TenK;
            this.diaChi = DiaChi;
        }

        public KhachHang() { } 
    }

    class HoaDon
    {
        public List<HangHoa> ListHH;
        public List<KhachHang> ListKH;

        public HoaDon(List<HangHoa> dsHH, List<KhachHang> dsKH) 
        {
            this.ListHH = dsHH;
            this.ListKH = dsKH;
        }
        public void MaxDonGia(List<HangHoa> ListHH) {
            int max = 0;
            foreach(var hangHoa in ListHH) { 
                if(hangHoa.DonGia > max) {
                    max = hangHoa.DonGia;
                }
            }
            return max;
        }

        // Phương thức in hàng hóa có giá cao nhất
        public void PrintMaxDonGia() {
            
        }
        public void PrintHH(List<HangHoa> ListHH)
        {
            Console.WriteLine("\nDanh sách hàng hóa: ");
            foreach (var hangHoa in ListHH)
            {
                Console.Write("{0} {1} {2}\n", hangHoa.maH, hangHoa.tenH, hangHoa.donGia);
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Menu()
        {
            int lc;
            do
            {
                Console.WriteLine("Lab 5 - Lập trình .NET");
                Console.WriteLine("1. Bài 1");
                Console.WriteLine("2. Bài 2");
                Console.WriteLine("3. Bài 3");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn: ");
                lc = Convert.ToInt32(Console.ReadLine());
                switch (lc)
                {
                    case 1:
                        PhanSo x = new PhanSo();
                        x.NhapPS(x);
                        PhanSo y = new PhanSo();
                        y.NhapPS(y);

                        Console.WriteLine("\nKet qua: {0}", x + y);
                        Console.WriteLine("Ket qua: {0}", x - y);
                        Console.WriteLine("Ket qua: {0}", x * y);
                        Console.WriteLine("Ket qua: {0}\n", x / y);
                        break;
                    case 2:
                        Number number1 = new Number(2);
                        Number number2 = new Number(3);

                        Console.WriteLine("\nKết quả: {0}", number1 + number2);
                        Console.WriteLine("Kết quả: {0}", number1 - number2);
                        Console.WriteLine("Kết quả: {0}", number1 * number2);
                        Console.WriteLine("Kết quả: {0}\n", number1 / number2);

                        Console.WriteLine((number1 + number2).check_Ngto() ? "Là số nguyên tố" 
                            : "Không là số nguyên tố");
                        Console.WriteLine((number1 - number2).check_Ngto() ? "Là số nguyên tố"
                            : "Không là số nguyên tố");
                        Console.WriteLine((number1 * number2).check_Ngto() ? "Là số nguyên tố"
                            : "Không là số nguyên tố");
                        Console.WriteLine((number1 / number2).check_Ngto() ? "Là số nguyên tố"
                            : "Không là số nguyên tố");
                        Console.WriteLine();

                        (number1 + number2).Check_Chan_Le();
                        (number1 - number2).Check_Chan_Le();
                        (number1 * number2).Check_Chan_Le();
                        (number1 / number2).Check_Chan_Le();
                        Console.WriteLine();
                        break;
                    case 3:
                        List<HangHoa> dsHH = new List<HangHoa>();
                        List<KhachHang> dsKH = new List<KhachHang>();
                        
                        HoaDon hoaDon = new HoaDon(dsHH, dsKH);
                        
                        HangHoa food1 = new HangHoa("001", "Mì tôm 3 miền", 4500);
                        HangHoa food2 = new HangHoa("002", "Mì tôm Hảo hảo", 5000);
                        HangHoa food3 = new HangHoa("003", "Mì tôm Phở gà", 3500);
                        dsHH.Add(food1);
                        dsHH.Add(food2);
                        dsHH.Add(food3);

                        hoaDon.PrintHH(dsHH);
                        
                        KhachHang khachHang1 = new KhachHang("001", "Nguyễn Văn A", "Hải Dương");
                        KhachHang khachHang2 = new KhachHang("002", "Nguyễn Thị B", "Hải Phòng");
                        KhachHang khachHang3 = new KhachHang("003", "Nguyễn Văn C", "Hưng Yên");
                        dsKH.Add(khachHang1);
                        dsKH.Add(khachHang2);
                        dsKH.Add(khachHang3);

                        dsHH.Clear();
                        dsKH.Clear();

                        break;
                    default:
                        Console.ReadKey();
                        break;
                }

            } while (lc > 0 && lc < 4);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu();
        }
    }
}