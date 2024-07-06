using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class frm_Trangchu : Form
    {
        public frm_Trangchu()
        {
            InitializeComponent();
        }

        public Form currentFormChild;

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Sach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Sach());
            lbl_home.Text = btn_Sach.Text;
        }

        private void btn_TacGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TacGia());
            lbl_home.Text = btn_TacGia.Text;
        }

        private void btn_TheLoai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TheLoai());
            lbl_home.Text = btn_TheLoai.Text;
        }

        private void btn_NSB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NXB());
            lbl_home.Text = btn_NSB.Text;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                frm_DangNhap dangNhap = new frm_DangNhap();
                dangNhap.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl_home.Text = "Trang Chủ";
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl_home.Text = btn_Home.Text;
        }
    }
}
