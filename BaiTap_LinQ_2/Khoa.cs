using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LinQ_2
{
    class Khoa
    {
        public Khoa()
        {
        }

        public int IdKhoa { get; set; }
        public string NameKhoa { get; set; }

        public static List<Khoa> GetAllKhoa()
        {
            return new List<Khoa>()
            {
                new Khoa{IdKhoa =1, NameKhoa="Cong Nghe So"},
                new Khoa{IdKhoa =2, NameKhoa="Dien - Dien Tu"},
                new Khoa{IdKhoa =3, NameKhoa="Xay dung"}
            };
        }

        public Khoa(int idKhoa, string nameKhoa)
        {
            IdKhoa = idKhoa;
            NameKhoa = nameKhoa;
        }

    }
}
