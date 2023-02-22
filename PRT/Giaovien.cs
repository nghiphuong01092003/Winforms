using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT
{
    public class Giaovien
    {
        private string magv;
        private string hoten;
        private string quequan;
        private string sdt;
        private string email;
        private DateTime ngaysinh;
        public string Magv { get { return magv; } }
        public string Hoten { get { return hoten; } }
        public string Quequan { get { return quequan; } }
        public DateTime Ngaysinh { get { return ngaysinh; } }
        public string Email { get { return email; } }
        public string Sdt { get { return sdt; } }
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
