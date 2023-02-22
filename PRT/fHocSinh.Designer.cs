namespace PRT
{
    partial class fHocSinh
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblQuequan = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.dsHS = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Mahs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsHS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(21, 60);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            // 
            // lblQuequan
            // 
            this.lblQuequan.AutoSize = true;
            this.lblQuequan.Location = new System.Drawing.Point(20, 102);
            this.lblQuequan.Name = "lblQuequan";
            this.lblQuequan.Size = new System.Drawing.Size(65, 16);
            this.lblQuequan.TabIndex = 1;
            this.lblQuequan.Text = "Quê quán";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Location = new System.Drawing.Point(20, 141);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(47, 16);
            this.lblCmnd.TabIndex = 2;
            this.lblCmnd.Text = "CMND";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(404, 147);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(132, 16);
            this.lblNgaysinh.TabIndex = 2;
            this.lblNgaysinh.Text = "Ngày tháng năm sinh";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(178, 23);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 22);
            this.txtTen.TabIndex = 3;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(178, 96);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(200, 22);
            this.txtQuequan.TabIndex = 4;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(178, 141);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(200, 22);
            this.txtCmnd.TabIndex = 5;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(562, 147);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaysinh.TabIndex = 6;
            // 
            // dsHS
            // 
            this.dsHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahs,
            this.Hoten,
            this.Quequan,
            this.Cmnd,
            this.Sdt,
            this.Email,
            this.Ngaysinh});
            this.dsHS.Location = new System.Drawing.Point(59, 206);
            this.dsHS.Name = "dsHS";
            this.dsHS.RowHeadersWidth = 51;
            this.dsHS.RowTemplate.Height = 24;
            this.dsHS.Size = new System.Drawing.Size(674, 164);
            this.dsHS.TabIndex = 7;
            this.dsHS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsHS_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(188, 459);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(330, 459);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(491, 459);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(713, 508);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(21, 26);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(47, 16);
            this.lblMaHS.TabIndex = 12;
            this.lblMaHS.Text = "Mã SV";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(177, 54);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(200, 22);
            this.txtMasv.TabIndex = 13;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(562, 57);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(200, 22);
            this.txtSdt.TabIndex = 15;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(404, 57);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(34, 16);
            this.lblSdt.TabIndex = 14;
            this.lblSdt.Text = "SĐT";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(562, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(404, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // Mahs
            // 
            this.Mahs.DataPropertyName = "Mahs";
            this.Mahs.HeaderText = "Mã HS";
            this.Mahs.MinimumWidth = 6;
            this.Mahs.Name = "Mahs";
            this.Mahs.Width = 125;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ Tên";
            this.Hoten.MinimumWidth = 6;
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 125;
            // 
            // Quequan
            // 
            this.Quequan.DataPropertyName = "Quequan";
            this.Quequan.HeaderText = "Quê quán";
            this.Quequan.MinimumWidth = 6;
            this.Quequan.Name = "Quequan";
            this.Quequan.Width = 125;
            // 
            // Cmnd
            // 
            this.Cmnd.DataPropertyName = "Cmnd";
            this.Cmnd.HeaderText = "CMND";
            this.Cmnd.MinimumWidth = 6;
            this.Cmnd.Name = "Cmnd";
            this.Cmnd.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(562, 23);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(200, 22);
            this.txtDiem.TabIndex = 19;
            // 
            // fHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dsHS);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.txtQuequan);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblCmnd);
            this.Controls.Add(this.lblQuequan);
            this.Controls.Add(this.lblTen);
            this.Name = "fHocSinh";
            this.Text = "fHocSinh";
            this.Load += new System.EventHandler(this.bt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblQuequan;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.DataGridView dsHS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiem;
    }
}

