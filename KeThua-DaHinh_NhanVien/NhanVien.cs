using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh_NhanVien
{
    public class NhanVien
    {
        protected string maNV;
        protected string tenNV;
        protected double heSoLuong;
        protected string phongBan;
        protected double soNgayLamViec;

        public NhanVien()
        {
            maNV = string.Empty;
            tenNV = string.Empty;
            heSoLuong = 0;
            phongBan = string.Empty;
            soNgayLamViec = 0;
        }
        public NhanVien(string maNV, string tenNV, double heSoLuong, string phongBan, double soNgayLamViec)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.heSoLuong = heSoLuong;
            this.phongBan = phongBan;
            this.soNgayLamViec = soNgayLamViec;
        }
        public string XepLoai()
        {
            if(soNgayLamViec >25)
                return "A";
            else if(soNgayLamViec > 22)
                return "B";
            else 
                return "C";
        }
        public float HeSoThiDua()
        {
            if(XepLoai() == "A")
                return 1f;
            else if(XepLoai() == "B")
                return 0.75f;
            else 
                return 0.5f;
        }
        public virtual double TinhLuong()
        {
            return heSoLuong * 1210 * HeSoThiDua();
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: ");
            tenNV = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            heSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap phong ban: ");
            phongBan = Console.ReadLine();
            Console.Write("Nhap so ngay lam viec: ");
            soNgayLamViec = double.Parse(Console.ReadLine());

        }
        public virtual void Xuat()
        {
            Console.WriteLine("\nMa nhan vien: " + maNV);
            Console.WriteLine("Ten nhan vien: " + tenNV);
            Console.WriteLine("He so luong: " + heSoLuong);
            Console.WriteLine("Phong ban: " + phongBan);
            Console.WriteLine("So ngay lam viec: " + soNgayLamViec);
            Console.WriteLine("Luong cua nhan vien la: " + TinhLuong());

        }
    }
}
