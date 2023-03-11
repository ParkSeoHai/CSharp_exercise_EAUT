using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Test
{
    class HangHoa
    {
        public string MaH;
        public string TenH;
        public double DonGia;
        public HangHoa() { }
        public HangHoa(string maH, string tenH, double donGia) 
        {
            MaH = maH;
            TenH = tenH;
            DonGia = donGia;
        }
        // Phương thức thêm
        public void Add(HangHoa[] array, HangHoa item)
        {
            int Length = array.Length;
            for(var i = 0; i < Length; ++i)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    break;
                }
            }
        }
        // Phương thức xóa
        public void Remove(HangHoa[] array, HangHoa item)
        {
            int Length = array.Length;
            for(var i = 0; i < Length; ++i)
            {
                if (array[i] == item)
                {
                    array[i] = null;
                }
            }
        }
        // Phương thức tìm kiếm hàng có đơn giá cao nhất
        public double MaxDonGia(HangHoa[] array)
        {
            double max = 0;
            foreach(HangHoa i in array)
            {
                if(i == null)
                {
                    continue;
                }
                if (i.DonGia > max)
                {
                    max = i.DonGia;
                }
            }
            return max;
        }
        // Phương thức in hàng có đơn giá cao nhất
        public void Print_MaxDonGia(HangHoa[] array)
        {
            for(var i = 0; i < array.Length; ++i)
            {
                if (array[i] == null)
                {
                    continue;
                }
                if (array[i].DonGia == MaxDonGia(array))
                {
                    Console.WriteLine("\nHang hoa co don gia cao nhat:\n{0} {1} {2}", array[i].MaH, array[i].TenH, array[i].DonGia);
                }
            }
        }
        // Phương thức hiển thị
        public void Print(HangHoa[] array)
        {
            Console.WriteLine("===================");
            Console.WriteLine("Danh sach hang hoa:");
            foreach (HangHoa i in array)
            {
                if(i == null)
                {
                    Console.Write("");
                } else
                {
                    Console.WriteLine("{0} {1} {2}", i.MaH, i.TenH, i.DonGia);
                }
            }
        }
    }
}
