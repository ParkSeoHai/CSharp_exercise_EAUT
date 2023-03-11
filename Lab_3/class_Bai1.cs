using System;
class Bai1 
{
    public void Tong (double a, double b) {
        Console.WriteLine("Tổng: {0}", a + b);
    }
    public void Hieu (double a, double b) {
        Console.WriteLine("Hiệu: {0}", a - b);
    }
    public void Tich (double a, double b) {
        Console.WriteLine("Tích: {0}", a * b);
    }
    public void Thuong (double a, double b) {
        Console.WriteLine("Thương: {0}", (a / b).ToString("N2"));
    }
}