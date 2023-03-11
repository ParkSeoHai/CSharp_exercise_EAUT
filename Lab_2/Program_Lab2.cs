using System;
using System.Text;

namespace Lab_2 
{
    class Lab_2 
    {
        static void Menu()
        {
            int luachon;
            do
            {
                Console.WriteLine("\nLab 2 - Lập trình .NET");
                Console.WriteLine("1. Bài tập 1");
                Console.WriteLine("2. Bài tập 2");
                Console.WriteLine("3. Bài tập 3");
                Console.WriteLine("4. Bài tập 4");
                Console.WriteLine("5. Bài tập 5");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("------------");

                Console.Write("Nhập lựa chọn của bạn: ");
                luachon = int.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        Bai_1();
                        break;
                    case 2:
                        Bai_2();
                        break;
                    case 3:
                        Bai_3();
                        break;
                    case 4:
                        Bai_4();
                        break;
                    case 5:
                        Bai_5();
                        break;
                    default:
                        Console.WriteLine("GoodBye!");
                        Console.ReadKey();
                        break;
                }
            } while (luachon > 0 && luachon < 6);
        }

        // Bài 1:
        static void Bai_1() {
            int n, s = 0;
            Console.Write("Nhập vào số nguyên dương: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++) {
                if (i % 2 == 0) {
                    s += i;
                }
            }
            Console.WriteLine(s + n);
            Console.ReadKey();
        }

        // Bài 2:
        static void Bai_2() {
            float s = 0f;

            Console.Write("Nhập vào số nguyên dương: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                s += 1 / (float) i;
            }

            Console.WriteLine(s.ToString("N2"));    // Lấy 2 số sau dấu phẩy
            Console.ReadKey();
        }

        // Bài 3:
        static void Bai_3() {
            Console.Write("Nhập vào số nguyên dương: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 2 || n == 3) {
                Console.WriteLine("Là số nguyên tố");
            } else if (n <= 1) {
                Console.WriteLine("Không phải số nguyên tố");
            } else {
                for (int i = 2; i <= Math.Sqrt(n); i++) {
                    if (n % i == 0) {
                        Console.WriteLine("Không phải số nguyên tố");
                        break;
                    } else {
                        Console.WriteLine("Là số nguyên tố");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }

        // Bài 4:
        static void Bai_4() {
            int a, b, c;
            Console.Write("Nhập vào 3 cạnh tam giác: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if ((a + b > c) && (b + c > a) && (c + b > a)) {
                Console.WriteLine("Đây là hình tam giác");
                if (a == b && b == c) {
                    Console.WriteLine("Tam giác đều");
                } else if ((a == b) || (b == c) || (a == c)) {
                    Console.WriteLine("Tam giác cân");
                } else if ((a*a == b*b + c*c) || (b*b == a*a + c*c) || (c*c == b*b + a*a)) {
                    Console.WriteLine("Tam giác vuông");
                } else if ((a*a > b*b + c*c || b*b > a*a + c*c || c*c > a*a + b*b)) {
                    Console.WriteLine("Tam giác tù");
                }
            } else 
                Console.WriteLine("Không phải hình tam giác");
            
            Console.ReadKey();
        }

        // Bài 5
        static void Bai_5() {
            int n, f1 = 1, f2 = 1, f;

            Console.Write("Nhập vào số nguyên dương: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 2) {
                Console.WriteLine("Lỗi, n lớn hơn 2, nhập lại!");
            } else {
                Console.Write("{0,3} {1,2} {2, 2}",0, f1, f2);
                for (int i = 3; i <= n; i++) {
                    f = f1 + f2;
                    Console.Write("{0,3}", f);
                    f1 = f2;
                    f2 = f;
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args) {
            // Get UTF-8 and UTF-16 encoders.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu();
        }
    }
}