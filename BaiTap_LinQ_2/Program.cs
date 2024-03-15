using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LinQ_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var listsvkhoa = Khoa.GetAllKhoa().Join(
                             SinhVien.GetAllSinhVien(),
                             khoa => khoa.IdKhoa,
                             sinhvien => sinhvien.IdKhoa,
                             (khoa, sinhvien) => new { 
                                khoa,sinhvien 
                             });
            foreach (var result in listsvkhoa)
                Console.WriteLine($"{result.khoa.NameKhoa} - {result.sinhvien.TenSinhVien}");
            var listsvten = SinhVien.GetAllSinhVien().OrderBy(s => s.TenSinhVien);
            Console.WriteLine("\nSap xep sinh vien theo ten:");
            foreach (var result in listsvten)
                Console.WriteLine($"{result.TenSinhVien} - {result.DiemTb}");


            Console.WriteLine("\nDanh sach sinh vien co diem trung binh > 7:");
            var listsvdtb7 = SinhVien.GetAllSinhVien().Where(s => s.DiemTb > 7);
            foreach (var result in listsvdtb7)
                Console.WriteLine($"{result.TenSinhVien} - {result.DiemTb}");


            Console.WriteLine("\nDanh sach sinh vien co diem trung binh < 4:");
            var listsvdtb4 = SinhVien.GetAllSinhVien().Where(s => s.DiemTb < 4);
            foreach (var result in listsvdtb4)
                Console.WriteLine($"{result.TenSinhVien} - {result.DiemTb}");

            Console.WriteLine("\nDanh sach sinh vien co thong tin khoa:");
            foreach (var result in listsvkhoa)
                Console.WriteLine($"{result.sinhvien.IdSinhVien} - {result.sinhvien.TenSinhVien} - {result.sinhvien.DiemTb} -{result.khoa.NameKhoa}");

            Console.WriteLine("\nSinh vien gioi nhat trong danh sach:");
            var svgioinhat = SinhVien.GetAllSinhVien().Max(s => s.DiemTb);

            Console.WriteLine(svgioinhat);

            Console.ReadLine();
        }
        
    }
   
}
