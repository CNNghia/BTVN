///Nhanvien.cs (main.cs)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Nhanvien
    {
        private String maso;
        public String getMaso() { return maso; }
        public void setMaso(String maso) { this.maso = maso; }

        private String hoten;
        public String getHoten() { return hoten; }
        public void setHoten(String hoten) { this.hoten = hoten; }

        private Double luongCB;
        public Double getLuongCB() { return luongCB; }
        public void setLuongCB(double luongCB) { this.luongCB = luongCB; }

        private ITienthuong phuongthucTinhThuong;

        // Getter và Setter cho phuongthucTinhThuong
        public ITienthuong getPhuongThucTinhThuong() { return phuongthucTinhThuong; }
        public void setPhuongThucTinhThuong(ITienthuong phuongthucTinhThuong) { this.phuongthucTinhThuong = phuongthucTinhThuong; }

        public Double getTienthuong()
        {
            if (phuongthucTinhThuong != null)
            {
                return phuongthucTinhThuong.tinhTienThuong(luongCB);
            }
            return 0;
        }

        protected Nhanvien() {
            this.maso = string.Empty; 
            this.hoten = string.Empty; 
            this.luongCB = 0.0; 
            this.phuongthucTinhThuong = new TienthuongThongthuong();
        }

        protected Nhanvien(String maso, String hoten, Double luongCB)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongCB = luongCB;
            this.phuongthucTinhThuong = new TienthuongThongthuong();
        }

        public override String ToString()
        {
            return $"Ma so: {this.maso}, Ho ten: {this.hoten}, Luong co ban: {this.luongCB}, Tien thuong: {this.getTienthuong()}";
        }
    }
}
