using System;
using System.Text;

class Bai4 
{
    public int hd;
    public int td;
    // Constructor
    public Bai4(int x, int y) {
        hd = x;
        td = y;
    }
    // Method
    public static double KhoangCach(Bai4 d1, Bai4 d2) {
        double kc;
        kc = Math.Sqrt((d1.hd*d1.hd - 2*d1.hd*d2.hd + d2.hd*d2.hd) + (d1.td*d1.td - 2*d1.td*d2.td + d2.td*d2.td));
        return kc;
    }
}