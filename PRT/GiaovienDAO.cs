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
    public class GiaovienDAO
    {
        DBConnection dbconn = new DBConnection();
        public DataTable LayDanhSachGiaoVien()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien");
            return dbconn.LayDanhSach(sqlStr);
        }
        public void Them(Giaovien gv)
        {
            string sqlStr = string.Format("INSERT INTO Giaovien(magv, hoten, quequan, sdt, email, ngaysinh) VALUES ('{0}', '{1}', '{2}', '{3}','{4}', '{5}')", gv.Magv, gv.Hoten, gv.Quequan, gv.Sdt, gv.Email, gv.Ngaysinh);
            dbconn.Thucthi(sqlStr, "them");
        }
        public void Xoa(Giaovien gv)
        {
            string sqlStr = string.Format("DELETE FROM Giaovien WHERE hoten = '{0}'", gv.Hoten);
            dbconn.Thucthi(sqlStr, "xoa");
        }
        public void Sua(Giaovien gv)
        {
            string sqlStr = string.Format("UPDATE Giaovien SET hoten = '{0}' WHERE quequan = '{1}'", gv.Hoten, gv.Quequan);
            dbconn.Thucthi(sqlStr, "sua");
        }
    }
}
