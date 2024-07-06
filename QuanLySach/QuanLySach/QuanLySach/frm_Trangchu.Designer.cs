namespace QuanLySach
{
    partial class frm_Trangchu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.btn_NSB = new System.Windows.Forms.Button();
            this.btn_TheLoai = new System.Windows.Forms.Button();
            this.btn_TacGia = new System.Windows.Forms.Button();
            this.btn_Sach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lbl_home = new System.Windows.Forms.Label();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.DarkGreen;
            this.panel_Menu.Controls.Add(this.btn_Home);
            this.panel_Menu.Controls.Add(this.lbl_Menu);
            this.panel_Menu.Controls.Add(this.btn_NSB);
            this.panel_Menu.Controls.Add(this.btn_TheLoai);
            this.panel_Menu.Controls.Add(this.btn_TacGia);
            this.panel_Menu.Controls.Add(this.btn_Sach);
            this.panel_Menu.Controls.Add(this.pictureBox1);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(200, 603);
            this.panel_Menu.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(12, 195);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(169, 57);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Trang chủ";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.ForeColor = System.Drawing.Color.White;
            this.lbl_Menu.Location = new System.Drawing.Point(33, 154);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(137, 23);
            this.lbl_Menu.TabIndex = 1;
            this.lbl_Menu.Text = "Menu Quản Lý";
            // 
            // btn_NSB
            // 
            this.btn_NSB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NSB.Location = new System.Drawing.Point(12, 480);
            this.btn_NSB.Name = "btn_NSB";
            this.btn_NSB.Size = new System.Drawing.Size(169, 62);
            this.btn_NSB.TabIndex = 4;
            this.btn_NSB.Text = "Quản lý nhà xuất bản";
            this.btn_NSB.UseVisualStyleBackColor = true;
            this.btn_NSB.Click += new System.EventHandler(this.btn_NSB_Click);
            // 
            // btn_TheLoai
            // 
            this.btn_TheLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TheLoai.Location = new System.Drawing.Point(12, 406);
            this.btn_TheLoai.Name = "btn_TheLoai";
            this.btn_TheLoai.Size = new System.Drawing.Size(169, 57);
            this.btn_TheLoai.TabIndex = 3;
            this.btn_TheLoai.Text = "Quản lý thể loại";
            this.btn_TheLoai.UseVisualStyleBackColor = true;
            this.btn_TheLoai.Click += new System.EventHandler(this.btn_TheLoai_Click);
            // 
            // btn_TacGia
            // 
            this.btn_TacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TacGia.Location = new System.Drawing.Point(12, 336);
            this.btn_TacGia.Name = "btn_TacGia";
            this.btn_TacGia.Size = new System.Drawing.Size(169, 57);
            this.btn_TacGia.TabIndex = 2;
            this.btn_TacGia.Text = "Quản lý tác giả";
            this.btn_TacGia.UseVisualStyleBackColor = true;
            this.btn_TacGia.Click += new System.EventHandler(this.btn_TacGia_Click);
            // 
            // btn_Sach
            // 
            this.btn_Sach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sach.Location = new System.Drawing.Point(12, 267);
            this.btn_Sach.Name = "btn_Sach";
            this.btn_Sach.Size = new System.Drawing.Size(169, 57);
            this.btn_Sach.TabIndex = 1;
            this.btn_Sach.Text = "Quản lý sách";
            this.btn_Sach.UseVisualStyleBackColor = true;
            this.btn_Sach.Click += new System.EventHandler(this.btn_Sach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::QuanLySach.Properties.Resources.sach;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DarkGreen;
            this.panel_Top.Controls.Add(this.lbl_home);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(200, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(724, 70);
            this.panel_Top.TabIndex = 1;
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.ForeColor = System.Drawing.Color.White;
            this.lbl_home.Location = new System.Drawing.Point(34, 24);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(99, 23);
            this.lbl_home.TabIndex = 0;
            this.lbl_home.Text = "Trang Chủ";
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Body.Controls.Add(this.btn_DangXuat);
            this.panel_Body.Controls.Add(this.pictureBox2);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(200, 70);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(724, 533);
            this.panel_Body.TabIndex = 2;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DangXuat.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_DangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Location = new System.Drawing.Point(554, 466);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(158, 55);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::QuanLySach.Properties.Resources.sach;
            this.pictureBox2.Location = new System.Drawing.Point(177, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 273);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // frm_Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 603);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Menu);
            this.Name = "frm_Trangchu";
            this.Text = "Quản lý cửa hàng sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_TacGia;
        private System.Windows.Forms.Button btn_Sach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button btn_NSB;
        private System.Windows.Forms.Button btn_TheLoai;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_Home;
    }
}

