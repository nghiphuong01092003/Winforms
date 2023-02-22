using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRT
{
    public partial class fGiaoVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiaovienDAO gvDao = new GiaovienDAO();
        public fGiaoVien()
        {
            InitializeComponent();
        }
        private void QLGV_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            this.dsGV.DataSource = gvDao.LayDanhSachGiaoVien();
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Giaovien gv = new Giaovien(txtMaGV.Text, txtTen.Text, txtQuequan.Text, txtSdt.Text, txtEmail.Text, dtpNgaysinh.Value.Date);
            gvDao.Them(gv);
            HienThiDanhSach();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            Giaovien gv = new Giaovien(txtMaGV.Text, txtTen.Text, txtQuequan.Text, txtSdt.Text, txtEmail.Text, dtpNgaysinh.Value.Date);
            gvDao.Xoa(gv);
            HienThiDanhSach();
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Giaovien gv = new Giaovien(txtMaGV.Text, txtTen.Text, txtQuequan.Text, txtSdt.Text, txtEmail.Text, dtpNgaysinh.Value.Date);
            gvDao.Sua(gv);
            HienThiDanhSach();
        }
    }
}
