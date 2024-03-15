using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LinQ_2
{
    class SinhVien
    {
        public int IdSinhVien { get; set; }
        public int IdKhoa { get; set; }
        public string TenSinhVien { get; set; }
        public double DiemTb { get; set; }

        public static List<SinhVien> GetAllSinhVien()
        {
            return new List<SinhVien>()
            {
                new SinhVien{IdSinhVien = 1, IdKhoa = 1,TenSinhVien = "Doan Nguyen Thanh Giang", DiemTb = 8.9},
                new SinhVien{IdSinhVien = 2, IdKhoa = 1,TenSinhVien = "Nguyen Hung Hanh", DiemTb = 7.9},
                new SinhVien{IdSinhVien = 3, IdKhoa = 1,TenSinhVien = "Cao Nguyen Vu", DiemTb = 8.2},
                new SinhVien{IdSinhVien = 4, IdKhoa = 2,TenSinhVien = "Nguyen Nhu Hien", DiemTb = 6.9},
                new SinhVien{IdSinhVien = 5, IdKhoa = 2,TenSinhVien = "Vo Quoc Dat", DiemTb = 3.9},
                new SinhVien{IdSinhVien = 6, IdKhoa = 3,TenSinhVien = "Nguyen Van Nhat", DiemTb = 5.9},
                new SinhVien{IdSinhVien = 7, IdKhoa = 3,TenSinhVien = "Nguyen Hoang Vu", DiemTb = 6.5}
            };
        }

        public SinhVien(int idSinhVien, int idKhoa, string tenSinhVien, double diemTb)
        {
            IdSinhVien = idSinhVien;
            IdKhoa = idKhoa;
            TenSinhVien = tenSinhVien;
            DiemTb = diemTb;
        }

        public SinhVien()
        {
        }
    }
}
