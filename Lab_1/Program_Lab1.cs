
using System;
using System.Text;
namespace Lab1
{
    class Lab1 {
        static void Menu()
        {
            int luachon;
            do
            {
                Console.WriteLine("\nLab 1 - Lập trình .NET");
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
                    default:
                        Console.WriteLine("GoodBye!");
                        Console.ReadKey();
                        break;
                }
            } while (luachon > 0 && luachon < 5);
        }

        // Bài tập 1:
        static void Bai_1()
        {
            string line1 = "\nRằm Tháng Riêng\n";
            string line2 = "Rằm xuân lồng lộng trăng soi\n";
            string line3 = "Sông xuân nước lẫn màu trời thêm xuân\n";
            string line4 = "Giữa dòng bàn bạc việc quân\n";
            string line5 = "Khuy về bát ngát trăng ngân đầu thuyền\n";
            string line6 = "Hồ Chí Minh";
            Console.WriteLine(line1 + line2 + line3 + line4 + line5 + line6);
        }

        // Bài tập 2: Viết chương trình nhập chiều cao, bán kính của hình trụ, 
        //tính diện tích xung quanh, thể tích của hình Trụ.
        static void Bai_2() 
        {
            double PI = 3.14159D, r, h, s, v;
            Console.Write("Nhập chiều cao: ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập bán kính: ");
            r = Convert.ToDouble(Console.ReadLine());

            s = 2 * PI * r * h;
            v = PI * (r * r) * h;

            Console.WriteLine("Diện tích xung quanh của hình trụ là: " + (float) s);
            Console.WriteLine("Thể tích của hình trụ là: " + (float) v);
        }

        // Bài tập 3:Viết chương trình sử dụng kiểu liệt kê và switch case 
        //để khi nhập 1 số bất kỳ, hiển thị trên màn hình cách đọc số đó. Ví dụ: 56 (năm sáu)
        static void Bai_3()
        {
            Console.Write("Nhập số nguyên (1 - 5): ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Một");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bốn");
                    break;
                case 5:
                    Console.WriteLine("Năm");
                    break;
                default:
                    Console.WriteLine("Hello");
                    break;
            }
        }

        // Bài tập 4: Nhập vào menu hiển thị hỉnh, (vẽ bằng dấu *)
        //    1 tam giác vuông đặc,
        //    2 tam giác vuông rỗng,
        //    3 là hình vuông rỗng.
        static void Bai_4()
        {
            int n, height;

            do
            {
                Console.WriteLine("\n******Bạn muốn vẽ loại hình nào******");
                Console.WriteLine("1. Tam giác vuông đặc.");
                Console.WriteLine("2. Tam giác vuông rỗng.");
                Console.WriteLine("3. Hình vuông rỗng.");
                Console.WriteLine("0. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.Write("Nhập chiều cao: ");
                        height = Convert.ToInt32(Console.ReadLine());
                        for (int row = 0; row < height; row++)
                        {
                            for (int col = 0; col <= row; col++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.Write("Nhập chiều cao: ");
                        height = Convert.ToInt32(Console.ReadLine());
                        for (int row = 0; row < height; row++)
                        {
                            for (int col = 0; col <= row; col++)
                            {
                                if (row == 0 || row == 1 || row == height - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    if (col == 0 || col == row)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                        Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.Write("Nhập chiều cao: ");
                        height = Convert.ToInt32(Console.ReadLine());
                        for (int row = 0; row < height; row++)
                        {
                            for (int col = 0; col < height; col++)
                            {
                                if (row == 0 || row == height - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    if (col == 0 || col == height - 1)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                        Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.Write("GoodBye!");
                        Console.ReadKey();
                        break;
                }
            } while (n > 0 && n < 4);
        }

        static void Main(string[] args) {
            // Get UTF-8 and UTF-16 encoders.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu();
        }
    }
}