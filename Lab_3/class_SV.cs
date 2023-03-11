using System;
using System.Text;

class sinhVien 
{
    public int maSv;
    public string hoTenSv;
    public int tuoiSv;
    public string gioiTinhSv;
    public string queQuanSv;
    // Constructor
    public sinhVien(int modelMaSv, string modelHoTenSv, int modelTuoiSv, string modelGioiTinhSv, string modelQueQuanSv) {
        maSv = modelMaSv;
        hoTenSv = modelHoTenSv;
        tuoiSv = modelTuoiSv;
        gioiTinhSv = modelGioiTinhSv;
        queQuanSv = modelQueQuanSv;
    }
    // Method
    public static void printSv(int modelMaSv, string modelHoTenSv, int modelTuoiSv, string modelGioiTinhSv, string modelQueQuanSv) {
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("+ Mã sinh viên + Họ và tên      + Tuổi + Giới tính + Quê quán     +");
        Console.WriteLine("+ {0,-12} + {1,-14} + {2,-4} + {3,-9} + {4,-12} +", modelMaSv, modelHoTenSv, modelTuoiSv, modelGioiTinhSv, modelQueQuanSv);
        Console.WriteLine("-------------------------------------------------------------------");
    }
}