using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace PRT
{
    public partial class fHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        HocsinhDAO hsDao = new HocsinhDAO();
        public fHocSinh()
        {
            InitializeComponent();
        }
        private void bt_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            this.dsHS.DataSource = hsDao.LayDanhSachSinhVien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Hocsinh hs = new Hocsinh(txtMasv.Text, txtTen.Text, txtQuequan.Text, dtpNgaysinh.Value.Date, txtDiem.Text, txtSdt.Text, txtEmail.Text, txtCmnd.Text);
            hsDao.Them(hs);
            HienThiDanhSach();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Hocsinh hs = new Hocsinh(txtMasv.Text, txtTen.Text, txtQuequan.Text, dtpNgaysinh.Value.Date, txtDiem.Text, txtSdt.Text, txtEmail.Text, txtCmnd.Text);
            hsDao.Xoa(hs);
            HienThiDanhSach();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Hocsinh hs = new Hocsinh(txtMasv.Text, txtTen.Text, txtQuequan.Text, dtpNgaysinh.Value.Date, txtDiem.Text, txtSdt.Text, txtEmail.Text, txtCmnd.Text);
            hsDao.Sua(hs);
            HienThiDanhSach();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            fGiaoVien fgv = new fGiaoVien();
            fgv.ShowDialog();
        }

        private void dsHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtMasv.Text = dsHS.Rows[index].Cells["MaHS"].Value.ToString();
                    txtTen.Text = dsHS.Rows[index].Cells["Hoten"].Value.ToString();
                    txtQuequan.Text = dsHS.Rows[index].Cells["Quequan"].Value.ToString();
                    txtCmnd.Text = dsHS.Rows[index].Cells["Cmnd"].Value.ToString();
                    dtpNgaysinh.Text = dsHS.Rows[index].Cells["Ngaysinh"].Value.ToString();
                    txtEmail.Text = dsHS.Rows[index].Cells["Email"].Value.ToString();
                    txtSdt.Text = dsHS.Rows[index].Cells["Sdt"].Value.ToString();
                    //txtDiem.Value = Convert.ToDecimal(dsHS.Rows[index].Cells["Diem"].Value);
                }
        }
    }
}
