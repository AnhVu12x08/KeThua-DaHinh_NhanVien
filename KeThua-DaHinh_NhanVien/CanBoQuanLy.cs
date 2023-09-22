using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh_NhanVien
{
    internal class CanBoQuanLy : NhanVien
    {
        private string ChucVu;
        private int HeSoChucVu;

        public CanBoQuanLy() : base()
        {
            ChucVu = string.Empty;
            HeSoChucVu = 0;
        }
        public CanBoQuanLy(string maNV, string tenNV, double heSoLuong, string phongBan, double soNgayLamViec, string chucVu, int heSoChucVu) : base(maNV, tenNV, heSoLuong, phongBan, soNgayLamViec)
        {
            ChucVu = chucVu;
            HeSoChucVu = heSoChucVu;
        }
        public override double TinhLuong()
        {
            return base.TinhLuong() + HeSoChucVu * 1100;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap he so chuc vu: ");
            HeSoChucVu = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("\nMa nhan vien: " + maNV);
            Console.WriteLine("Ten nhan vien: " + tenNV);
            Console.WriteLine("He so luong: " + heSoLuong);
            Console.WriteLine("Phong ban: " + phongBan);
            Console.WriteLine("So ngay lam viec: " + soNgayLamViec);
            Console.WriteLine("Chuc Vu la: " + ChucVu);
            Console.WriteLine("He so chuc vu: " + HeSoChucVu);
            Console.WriteLine("Luong cua can bo quan ly la: {0}", TinhLuong());
        }

    }
}
