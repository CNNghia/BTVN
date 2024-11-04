///NhanvienFactory.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NhanvienFactory : INhanvienFactory
    {
        /// <summary>
        /// Factory Nhanvien by loaiNV
        /// </summary>
        /// <param name="maso"></param>
        /// <param name="hoten"></param>
        /// <param name="luongCB"></param>
        /// <param name="loaiNV"></param>
        /// <returns></returns>
        /// <remarks>
        /// loaiNV = [LTV, KTV, PTV, NKT]
        /// Laptrinhvien, Ketoanvien, ChuyenvienPhantich, NhanvienKiemthu
        /// </remarks>
        /// <exception cref="NotImplementedException"></exception>
        public Nhanvien createNhanvien(string maso, string hoten, double luongCB, string loaiNV)
        {
            Nhanvien nv;
            switch (loaiNV)
            {
                case "LTV":
                    nv = new Laptrinhvien(maso, hoten, luongCB);
                    break;
                case "KTV":
                    nv = new Ketoanvien(maso, hoten, luongCB);
                    break;
                case "PTV":
                    nv = new ChuyenvienPhantich(maso, hoten, luongCB);
                    break;
                case "NKT":
                    nv = new NhanvienKiemthu(maso, hoten, luongCB);
                    break;
                default:
                    throw new ArgumentException();
            
            }
            return nv;
        }

        /// <summary>
        /// Factory Nhanvien by loaiNV
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// loaiNV = [LTV, KTV, PTV, NKT]
        /// Laptrinhvien, Ketoanvien, ChuyenvienPhantich, NhanvienKiemthu
        /// </remarks>
        /// <exception cref="NotImplementedException"></exception>

        public Nhanvien createNhanvien(string loaiNV)
        {
            Nhanvien nv;
            switch (loaiNV)
            {
                case "LTV":
                    nv = new Laptrinhvien();
                    break;
                case "KTV":
                    nv = new Ketoanvien();
                    break;
                case "PTV":
                    nv = new ChuyenvienPhantich();
                    break;
                case "NKT":
                    nv = new NhanvienKiemthu();
                    break;
                default:
                    throw new ArgumentException();

            }
            return nv;

        }
    }
}
