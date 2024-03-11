namespace Bai5
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
            label1 = new Label();
            gbChucNang = new GroupBox();
            btnThoat = new Button();
            btnTraMay = new Button();
            btnLamMoi = new Button();
            btnDatMay = new Button();
            gbDanhSachMay = new GroupBox();
            lvDanhsachMay = new ListView();
            chSomay = new ColumnHeader();
            chTrangthai = new ColumnHeader();
            chBatDau = new ColumnHeader();
            chSuDung = new ColumnHeader();
            chThanhtien = new ColumnHeader();
            lbGia = new Label();
            gbChucNang.SuspendLayout();
            gbDanhSachMay.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(267, 31);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(476, 37);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ QUÁN HỌC THÊM GAMING";
            // 
            // gbChucNang
            // 
            gbChucNang.Anchor = AnchorStyles.None;
            gbChucNang.Controls.Add(btnThoat);
            gbChucNang.Controls.Add(btnTraMay);
            gbChucNang.Controls.Add(btnLamMoi);
            gbChucNang.Controls.Add(btnDatMay);
            gbChucNang.Location = new Point(525, 624);
            gbChucNang.Name = "gbChucNang";
            gbChucNang.Size = new Size(447, 45);
            gbChucNang.TabIndex = 1;
            gbChucNang.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ScrollBar;
            btnThoat.Location = new Point(337, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(104, 43);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTraMay
            // 
            btnTraMay.BackColor = SystemColors.ScrollBar;
            btnTraMay.Location = new Point(227, 0);
            btnTraMay.Name = "btnTraMay";
            btnTraMay.Size = new Size(104, 43);
            btnTraMay.TabIndex = 2;
            btnTraMay.Text = "Trả máy";
            btnTraMay.UseVisualStyleBackColor = false;
            btnTraMay.Click += btnTraMay_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ScrollBar;
            btnLamMoi.Location = new Point(116, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(104, 43);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnDatMay
            // 
            btnDatMay.BackColor = SystemColors.ScrollBar;
            btnDatMay.Location = new Point(6, 0);
            btnDatMay.Name = "btnDatMay";
            btnDatMay.Size = new Size(104, 43);
            btnDatMay.TabIndex = 0;
            btnDatMay.Text = "Đặt máy";
            btnDatMay.UseVisualStyleBackColor = false;
            btnDatMay.Click += btnDatMay_Click;
            // 
            // gbDanhSachMay
            // 
            gbDanhSachMay.Anchor = AnchorStyles.None;
            gbDanhSachMay.Controls.Add(lvDanhsachMay);
            gbDanhSachMay.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDanhSachMay.Location = new Point(12, 93);
            gbDanhSachMay.Name = "gbDanhSachMay";
            gbDanhSachMay.Size = new Size(960, 525);
            gbDanhSachMay.TabIndex = 2;
            gbDanhSachMay.TabStop = false;
            gbDanhSachMay.Text = "Danh sách máy";
            // 
            // lvDanhsachMay
            // 
            lvDanhsachMay.BorderStyle = BorderStyle.FixedSingle;
            lvDanhsachMay.Columns.AddRange(new ColumnHeader[] { chSomay, chTrangthai, chBatDau, chSuDung, chThanhtien });
            lvDanhsachMay.FullRowSelect = true;
            lvDanhsachMay.GridLines = true;
            lvDanhsachMay.Location = new Point(6, 32);
            lvDanhsachMay.Name = "lvDanhsachMay";
            lvDanhsachMay.Size = new Size(948, 480);
            lvDanhsachMay.TabIndex = 0;
            lvDanhsachMay.UseCompatibleStateImageBehavior = false;
            lvDanhsachMay.View = View.Details;
            // 
            // chSomay
            // 
            chSomay.Text = "Số máy";
            chSomay.Width = 80;
            // 
            // chTrangthai
            // 
            chTrangthai.Text = "Trạng thái";
            chTrangthai.Width = 120;
            // 
            // chBatDau
            // 
            chBatDau.Text = "Bắt đầu";
            chBatDau.Width = 220;
            // 
            // chSuDung
            // 
            chSuDung.Text = "Thời gian sử dụng(phút)";
            chSuDung.TextAlign = HorizontalAlignment.Center;
            chSuDung.Width = 220;
            // 
            // chThanhtien
            // 
            chThanhtien.Text = "Thành tiền";
            chThanhtien.TextAlign = HorizontalAlignment.Center;
            chThanhtien.Width = 308;
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.Location = new Point(843, 65);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(118, 25);
            lbGia.TabIndex = 3;
            lbGia.Text = "Giá: 5k/tiếng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 681);
            Controls.Add(lbGia);
            Controls.Add(gbDanhSachMay);
            Controls.Add(gbChucNang);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý quán";
            gbChucNang.ResumeLayout(false);
            gbDanhSachMay.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbChucNang;
        private GroupBox gbDanhSachMay;
        private ListView lvDanhsachMay;
        private ColumnHeader chSomay;
        private ColumnHeader chTrangthai;
        private ColumnHeader chBatDau;
        private ColumnHeader chSuDung;
        private Button btnDatMay;
        private Button btnThoat;
        private Button btnTraMay;
        private Button btnLamMoi;
        private ColumnHeader chThanhtien;
        private Label lbGia;
    }
}
