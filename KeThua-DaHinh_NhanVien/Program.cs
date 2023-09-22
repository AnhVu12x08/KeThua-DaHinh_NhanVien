using KeThua_DaHinh_NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            nv.Nhap();
            nv.Xuat();
            CanBoQuanLy cbql = new CanBoQuanLy();
            cbql.Nhap();
            cbql.Xuat();
        }
    }
}