using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT
{
    public class Hocsinh
    {
        public string masv;
        public string hoten;
        public string quequan;
        public DateTime ngaysinh;
        public string cmnd;
        public string email;
        public string sdt;
        public Hocsinh(string masv, string hoten, string quequan, DateTime ngaysinh, string cmnd, string email, string sdt)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.quequan = quequan;
            this.ngaysinh = ngaysinh;
            this.cmnd = cmnd;
            this.email = email;
            this.sdt = sdt;
        }
    }
}
