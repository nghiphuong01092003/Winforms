using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRT
{
    public class HocsinhDAO
    {
        DBConnection dbconn = new DBConnection();
        public DataTable LayDanhSachSinhVien()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");
            return dbconn.LayDanhSach(sqlStr);
        }
        public void Them(Hocsinh hs)
        {
            string sqlStr = string.Format("INSERT INTO Hocsinh(mahs, hoten, quequan, cmnd, diem, sdt, email, ngaysinh) VALUES ('{0}', '{1}', '{2}', '{3}','{4}','{5}', '{6}', '{7}')", hs.Mahs, hs.Hoten, hs.Quequan, hs.Diem, hs.Cmnd, hs.Sdt, hs.Email, hs.Ngaysinh);
            dbconn.checkdata(txtMasv,txtTen, txtQuequan, txtCmnd, txtSdt, txtEmail);
            dbconn.Thucthi(sqlStr,"Them");
        }
        public void Xoa(Hocsinh hs)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE hoten = '{0}'", hs.Hoten);
            dbconn.Thucthi(sqlStr, "Xoa");
        }
        public void Sua(Hocsinh hs)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET hoten = '{0}' WHERE cmnd = '{1}'", hs.Hoten, hs.Cmnd);
            dbconn.Thucthi(sqlStr, "Sua");
        }
    }
}
