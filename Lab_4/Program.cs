using System;
using System.Text;

namespace Lab_4
{
    class Program
    {
        static void Menu()
        {
            int lc;
            do
            {
                Console.WriteLine("Lab_4 - Lập trình .NET");
                Console.WriteLine("1. Bài 1");
                Console.WriteLine("2. Bài 2");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn: ");
                lc = Convert.ToInt32(Console.ReadLine());

                switch (lc)
                {
                    case 1:
                        Person person1 = new Person("Nguyễn Văn Hải", 030203002184, "Hải Dương", "Default");
                        Person person2 = new Person("Nguyễn Văn A", 030203002199, "Hải Phòng", "Default");
                        Person person3 = new Person("Nguyễn Thị B", 030203002391, "Hà Nội", "Default");

                        Console.WriteLine(person1.ToString());
                        Console.WriteLine(person2.ToString());
                        Console.WriteLine(person3.ToString());
                        Console.ReadKey();
                        break;
                    case 2:
                        Sv1 sv1 = new Sv1("Lương Thị Huyền", 030203002183, "Hải Dương", "Default", 20210864);
                        Console.WriteLine(sv1.ToString());

                        Sv2 sv2 = new Sv2("Nguyễn Văn E", 030203001192, "Hải Dương", "Default", 20210222);
                        Console.WriteLine(sv2.ToString());
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("GoodBye!");
                        Console.ReadKey();
                        break;
                }
            } while (lc > 0 && lc < 3);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu();
        }
    }
}

