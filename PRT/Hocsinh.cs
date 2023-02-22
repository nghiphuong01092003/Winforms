using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRT
{
    public class Hocsinh
    {
        private string mahs;
        private string hoten;
        private string quequan;
        private DateTime ngaysinh;
        private int diem;
        private string cmnd;
        private string email;
        private string sdt;

        public string Mahs { get { return mahs; } }
        public string Hoten { get { return hoten; } }
        public string Quequan { get { return quequan; } }
        public DateTime Ngaysinh { get { return ngaysinh; } }
        public int Diem { get { return diem; } }
        public string Cmnd { get { return cmnd; } }
        public string Email { get { return email; } }
        public string Sdt { get { return sdt; } }

        public Hocsinh(string mahs, string hoten, string quequan, DateTime ngaysinh, int diem, string cmnd, string email, string sdt)
        {
            this.mahs = mahs;
            this.hoten = hoten;
            this.quequan = quequan;
            this.ngaysinh = ngaysinh;
            this.diem = diem;
            this.cmnd = cmnd;
            this.email = email;
            this.sdt = sdt;
        }
    }
}
