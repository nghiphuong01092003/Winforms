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
            string sqlStr = string.Format("INSERT INTO Giaovien(magv, ten, quequan, sdt, email, ngaysinh) VALUES ('{0}', '{1}', '{2}', '{3}','{4}', '{5}')", gv.magv, gv.hoten, gv.quequan, gv.sdt, gv.email, gv.ngaysinh);
            dbconn.Thucthi(sqlStr, "them");
        }
        public void Xoa(Giaovien gv)
        {
            string sqlStr = string.Format("DELETE FROM Giaovien WHERE Ten = '{0}'", gv.hoten);
            dbconn.Thucthi(sqlStr, "xoa");
        }
        public void Sua(Giaovien gv)
        {
            string sqlStr = string.Format("UPDATE Giaovien SET Ten = '{0}' WHERE Quequan = '{1}'", gv.hoten, gv.quequan);
            dbconn.Thucthi(sqlStr, "sua");
        }
    }
}
