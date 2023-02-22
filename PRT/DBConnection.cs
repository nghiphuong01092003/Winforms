using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRT
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public bool checkdata(TextBox txtMasv, TextBox txtTen, TextBox txtQuequan, TextBox txtCmnd, TextBox txtSdt, TextBox txtEmail)
        {
            if (string.IsNullOrEmpty(txtMasv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học sinh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên học sinh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtQuequan.Text))
            {
                MessageBox.Show("Bạn chưa nhập que quan học sinh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuequan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCmnd.Text))
            {
                MessageBox.Show("Bạn chưa nhập sdt học sinh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCmnd.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập sdt học sinh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Bạn chưa nhập email học sinh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            return true;
        }
        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable dtds = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtds);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtds;
        }
        public void Thucthi(string sqlStr, string lenh)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(lenh + " thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(lenh + " that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
