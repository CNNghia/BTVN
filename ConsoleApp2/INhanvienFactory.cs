///INhanvienFactory.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface INhanvienFactory
    {
        Nhanvien createNhanvien(String maso, String hoten, Double luongCB, String loaiNV);
        Nhanvien createNhanvien(String loaiNV);

    }
}