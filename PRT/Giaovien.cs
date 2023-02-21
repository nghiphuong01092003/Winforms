using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT
{
    public class Giaovien
    {
        public string magv;
        public string hoten;
        public string quequan;
        public string sdt;
        public string email;
        public DateTime ngaysinh;
        public Giaovien(string magv, string hoten, string quequan, string sdt, string email, DateTime ngaysinh)
        {
            this.magv = magv;
            this.hoten = hoten;
            this.quequan = quequan;
            this.sdt = sdt;
            this.email = email;
            this.ngaysinh = ngaysinh;
        }
    }
}
