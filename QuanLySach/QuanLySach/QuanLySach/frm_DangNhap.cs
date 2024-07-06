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

namespace QuanLySach
{
    public partial class frm_DangNhap : Form
    {
        string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\lập trình.net\QuanLySach\QuanLySach\QuanLySach\QLSach.mdf;Integrated Security=True";
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\lập trình.net\QuanLySach\QuanLySach\QuanLySach\QLSach.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            try
            {
                conn.Open();
                string tk = txt_TenTaiKhoan.Text;
                string mk = txt_MatKhau.Text;
                string sql = "Select* from TaiKhoan where TenDN = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader dat = comm.ExecuteReader();
                if (dat.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Trangchu home = new frm_Trangchu();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !!!", "Thông Báo");

            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}




    