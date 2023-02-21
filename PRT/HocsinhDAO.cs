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
            string sqlStr = string.Format("INSERT INTO Hocsinh(masv, hoten, quequan, cmnd, sdt, email, ngaysinh) VALUES ('{0}', '{1}', '{2}', '{3}','{4}','{5}', '{6}')", hs.masv, hs.hoten, hs.quequan, hs.cmnd, hs.sdt, hs.email, hs.ngaysinh);
            dbconn.Thucthi(sqlStr,"them");
        }
        public void Xoa(Hocsinh hs)
        {
            string sqlStr = string.Format("DELETE FROM Hocsinh WHERE Ten = '{0}'", hs.hoten);
            dbconn.Thucthi(sqlStr, "xoa");
        }
        public void Sua(Hocsinh hs)
        {
            string sqlStr = string.Format("UPDATE Hocsinh SET Ten = '{0}' WHERE CMND = '{1}'", hs.hoten, hs.cmnd);
            dbconn.Thucthi(sqlStr, "sua");
        }
    }
}
