using System;
using System.Text;

namespace Lab_4
{
    public class Person
    {
        public String fullName { get; set; }
        public long cmnd { get; set; }
        public String queQuan { get; set; }
        public String ghiChu { get; set; }

        // Default constructor
        public Person()
        {
            fullName = "Default name";
            cmnd = 0;
            queQuan = "Default home towl";
            ghiChu = "Default node";
        }

        // Constructor
        public Person(String FullName, long CMND, String QueQuan, String GhiChu)
        {
            this.fullName = FullName;
            this.cmnd = CMND;
            this.queQuan = QueQuan;
            this.ghiChu = GhiChu;
        }
        // Method ToString
        public override String ToString() =>
            $"{this.fullName} - {this.cmnd} - {this.queQuan} - {this.ghiChu}";
    }
    public class Sv1 : Person
    {
        public int maSv { get; set; }

        // Default constructor
        public Sv1() { }

        public Sv1(String FullName, long CMND, String QueQuan, String GhiChu, int MaSv)
        {
            // Properties of Person
            this.fullName = FullName;
            this.cmnd = CMND;
            this.queQuan = QueQuan;
            this.ghiChu = GhiChu;

            // Property Sv1
            this.maSv = MaSv;
        }
        public override string ToString() => 
            $"{this.maSv} - {this.fullName} - {this.cmnd} - {this.queQuan} - {this.ghiChu}";

    }
    public class Sv2 : Sv1
    {
        public Sv2() { }

        public Sv2(String FullName, long CMND, String QueQuan, String GhiChu, int MaSv)
        {
            // Properties of Person
            this.fullName = FullName;
            this.cmnd = CMND;
            this.queQuan = QueQuan;
            this.ghiChu = GhiChu;

            // Property Sv1
            this.maSv = MaSv;
        }
    }
}