///ChuyenvienPhantich.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class ChuyenvienPhantich : Nhanvien
    {
        public ChuyenvienPhantich() : base() { }
        public ChuyenvienPhantich(String maso, String hoten, Double luongCB)
            : base(maso, hoten, luongCB) { }
        public override String ToString()
        {
            return $"{base.ToString()}, loaiNV: PTV";
        }
    }
}
