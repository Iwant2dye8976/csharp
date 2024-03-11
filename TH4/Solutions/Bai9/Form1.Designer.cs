namespace Bai9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb = new Label();
            gbThongTinChiTiet = new GroupBox();
            dtpNgaysinh = new DateTimePicker();
            tbDiachi = new TextBox();
            tbDienthoai = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbHoten = new TextBox();
            label3 = new Label();
            label2 = new Label();
            gbThaoTac = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            gbThongTinChung = new GroupBox();
            lvThongTin = new ListView();
            cH_hoten = new ColumnHeader();
            cH_ngaysinh = new ColumnHeader();
            cH_diachi = new ColumnHeader();
            cH_sdt = new ColumnHeader();
            gbThongTinChiTiet.SuspendLayout();
            gbThaoTac.SuspendLayout();
            gbThongTinChung.SuspendLayout();
            SuspendLayout();
            // 
            // lb
            // 
            lb.Anchor = AnchorStyles.None;
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb.ForeColor = SystemColors.HotTrack;
            lb.Location = new Point(263, 9);
            lb.Name = "lb";
            lb.Size = new Size(431, 50);
            lb.TabIndex = 0;
            lb.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // gbThongTinChiTiet
            // 
            gbThongTinChiTiet.Anchor = AnchorStyles.None;
            gbThongTinChiTiet.Controls.Add(dtpNgaysinh);
            gbThongTinChiTiet.Controls.Add(tbDiachi);
            gbThongTinChiTiet.Controls.Add(tbDienthoai);
            gbThongTinChiTiet.Controls.Add(label4);
            gbThongTinChiTiet.Controls.Add(label5);
            gbThongTinChiTiet.Controls.Add(tbHoten);
            gbThongTinChiTiet.Controls.Add(label3);
            gbThongTinChiTiet.Controls.Add(label2);
            gbThongTinChiTiet.Font = new Font("Segoe UI", 12F);
            gbThongTinChiTiet.Location = new Point(35, 92);
            gbThongTinChiTiet.Name = "gbThongTinChiTiet";
            gbThongTinChiTiet.Size = new Size(922, 172);
            gbThongTinChiTiet.TabIndex = 11;
            gbThongTinChiTiet.TabStop = false;
            gbThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Location = new Point(120, 91);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(296, 29);
            dtpNgaysinh.TabIndex = 8;
            // 
            // tbDiachi
            // 
            tbDiachi.BorderStyle = BorderStyle.FixedSingle;
            tbDiachi.Location = new Point(580, 94);
            tbDiachi.Name = "tbDiachi";
            tbDiachi.Size = new Size(296, 29);
            tbDiachi.TabIndex = 7;
            // 
            // tbDienthoai
            // 
            tbDienthoai.BorderStyle = BorderStyle.FixedSingle;
            tbDienthoai.Location = new Point(580, 50);
            tbDienthoai.Name = "tbDienthoai";
            tbDienthoai.Size = new Size(296, 29);
            tbDienthoai.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 97);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 5;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 53);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 4;
            label5.Text = "Điện thoại";
            // 
            // tbHoten
            // 
            tbHoten.BorderStyle = BorderStyle.FixedSingle;
            tbHoten.Location = new Point(120, 49);
            tbHoten.Name = "tbHoten";
            tbHoten.Size = new Size(296, 29);
            tbHoten.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 96);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 52);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // gbThaoTac
            // 
            gbThaoTac.Anchor = AnchorStyles.None;
            gbThaoTac.Controls.Add(btnXoa);
            gbThaoTac.Controls.Add(btnSua);
            gbThaoTac.Controls.Add(btnThoat);
            gbThaoTac.Controls.Add(btnThem);
            gbThaoTac.Location = new Point(531, 290);
            gbThaoTac.Name = "gbThaoTac";
            gbThaoTac.Size = new Size(426, 57);
            gbThaoTac.TabIndex = 12;
            gbThaoTac.TabStop = false;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(113, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 39);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(219, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 39);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(325, 12);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 39);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(7, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 39);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // gbThongTinChung
            // 
            gbThongTinChung.Anchor = AnchorStyles.None;
            gbThongTinChung.Controls.Add(lvThongTin);
            gbThongTinChung.Location = new Point(41, 373);
            gbThongTinChung.Name = "gbThongTinChung";
            gbThongTinChung.Size = new Size(916, 296);
            gbThongTinChung.TabIndex = 13;
            gbThongTinChung.TabStop = false;
            gbThongTinChung.Text = "Thông tin chung";
            // 
            // lvThongTin
            // 
            lvThongTin.BorderStyle = BorderStyle.FixedSingle;
            lvThongTin.Columns.AddRange(new ColumnHeader[] { cH_hoten, cH_ngaysinh, cH_diachi, cH_sdt });
            lvThongTin.FullRowSelect = true;
            lvThongTin.GridLines = true;
            lvThongTin.Location = new Point(24, 33);
            lvThongTin.Name = "lvThongTin";
            lvThongTin.Size = new Size(865, 257);
            lvThongTin.TabIndex = 0;
            lvThongTin.UseCompatibleStateImageBehavior = false;
            lvThongTin.View = View.Details;
            lvThongTin.SelectedIndexChanged += lvThongTin_SelectedIndexChanged;
            // 
            // cH_hoten
            // 
            cH_hoten.Text = "Họ Tên";
            cH_hoten.Width = 320;
            // 
            // cH_ngaysinh
            // 
            cH_ngaysinh.Text = "Ngày sinh";
            cH_ngaysinh.Width = 181;
            // 
            // cH_diachi
            // 
            cH_diachi.Text = "Địa chỉ";
            cH_diachi.Width = 181;
            // 
            // cH_sdt
            // 
            cH_sdt.Text = "Điện thoại";
            cH_sdt.Width = 181;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(984, 681);
            Controls.Add(gbThongTinChung);
            Controls.Add(gbThaoTac);
            Controls.Add(gbThongTinChiTiet);
            Controls.Add(lb);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            gbThongTinChiTiet.ResumeLayout(false);
            gbThongTinChiTiet.PerformLayout();
            gbThaoTac.ResumeLayout(false);
            gbThongTinChung.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb;
        private GroupBox gbThongTinChiTiet;
        private TextBox tbHoten;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgaysinh;
        private TextBox tbDiachi;
        private TextBox tbDienthoai;
        private Label label4;
        private Label label5;
        private GroupBox gbThaoTac;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
        private GroupBox gbThongTinChung;
        private ListView lvThongTin;
        private ColumnHeader cH_hoten;
        private ColumnHeader cH_ngaysinh;
        private ColumnHeader cH_diachi;
        private ColumnHeader cH_sdt;
    }
}
