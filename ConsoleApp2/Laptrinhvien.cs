///Laptrinhvien.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Laptrinhvien : Nhanvien
    {
        public Laptrinhvien(String maso, String hoten, Double luongCB)
            : base(maso, hoten, luongCB)
        {
            //Lop con ke thua lai cha
            //phat huy them cac thuoc tinh
        }
        public Laptrinhvien() : base()
        {
        }
        public override String ToString()
        {
            return $"{base.ToString()}, loaiNV: LTV";
        }
    }
}