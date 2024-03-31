namespace QLSACH_Sql
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbMaS = new TextBox();
            tbTenS = new TextBox();
            tbTacGia = new TextBox();
            tbTimKiem = new TextBox();
            cbNgonNgu = new ComboBox();
            gbTheLoai = new GroupBox();
            rbSThamKhao = new RadioButton();
            rbSChuyenKhao = new RadioButton();
            rbTapChi = new RadioButton();
            rbGiaoTrinh = new RadioButton();
            label6 = new Label();
            dgSach = new DataGridView();
            btnThem = new Button();
            btnReset = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            gbTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 64);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 112);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 171);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Tác giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 64);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "Ngôn ngữ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 228);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm";
            // 
            // tbMaS
            // 
            tbMaS.BorderStyle = BorderStyle.FixedSingle;
            tbMaS.Location = new Point(154, 61);
            tbMaS.Name = "tbMaS";
            tbMaS.Size = new Size(209, 29);
            tbMaS.TabIndex = 5;
            // 
            // tbTenS
            // 
            tbTenS.BorderStyle = BorderStyle.FixedSingle;
            tbTenS.Location = new Point(154, 110);
            tbTenS.Name = "tbTenS";
            tbTenS.Size = new Size(209, 29);
            tbTenS.TabIndex = 6;
            // 
            // tbTacGia
            // 
            tbTacGia.BorderStyle = BorderStyle.FixedSingle;
            tbTacGia.Location = new Point(154, 169);
            tbTacGia.Name = "tbTacGia";
            tbTacGia.Size = new Size(209, 29);
            tbTacGia.TabIndex = 7;
            // 
            // tbTimKiem
            // 
            tbTimKiem.BorderStyle = BorderStyle.FixedSingle;
            tbTimKiem.Location = new Point(285, 226);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(209, 29);
            tbTimKiem.TabIndex = 8;
            // 
            // cbNgonNgu
            // 
            cbNgonNgu.FormattingEnabled = true;
            cbNgonNgu.Items.AddRange(new object[] { "Tiếng Việt", "Tiếng Anh", "Tiếng Bồ Khổng Luồi" });
            cbNgonNgu.Location = new Point(477, 61);
            cbNgonNgu.Name = "cbNgonNgu";
            cbNgonNgu.Size = new Size(205, 29);
            cbNgonNgu.TabIndex = 9;
            // 
            // gbTheLoai
            // 
            gbTheLoai.Controls.Add(rbSThamKhao);
            gbTheLoai.Controls.Add(rbSChuyenKhao);
            gbTheLoai.Controls.Add(rbTapChi);
            gbTheLoai.Controls.Add(rbGiaoTrinh);
            gbTheLoai.Location = new Point(391, 110);
            gbTheLoai.Name = "gbTheLoai";
            gbTheLoai.Size = new Size(291, 98);
            gbTheLoai.TabIndex = 10;
            gbTheLoai.TabStop = false;
            gbTheLoai.Text = "Thể loại";
            // 
            // rbSThamKhao
            // 
            rbSThamKhao.AutoSize = true;
            rbSThamKhao.Location = new Point(120, 59);
            rbSThamKhao.Name = "rbSThamKhao";
            rbSThamKhao.Size = new Size(139, 25);
            rbSThamKhao.TabIndex = 14;
            rbSThamKhao.TabStop = true;
            rbSThamKhao.Text = "Sách tham khảo";
            rbSThamKhao.UseVisualStyleBackColor = true;
            // 
            // rbSChuyenKhao
            // 
            rbSChuyenKhao.AutoSize = true;
            rbSChuyenKhao.Location = new Point(120, 28);
            rbSChuyenKhao.Name = "rbSChuyenKhao";
            rbSChuyenKhao.Size = new Size(153, 25);
            rbSChuyenKhao.TabIndex = 13;
            rbSChuyenKhao.TabStop = true;
            rbSChuyenKhao.Text = "Sách chuyên khảo";
            rbSChuyenKhao.UseVisualStyleBackColor = true;
            // 
            // rbTapChi
            // 
            rbTapChi.AutoSize = true;
            rbTapChi.Location = new Point(6, 59);
            rbTapChi.Name = "rbTapChi";
            rbTapChi.Size = new Size(77, 25);
            rbTapChi.TabIndex = 12;
            rbTapChi.TabStop = true;
            rbTapChi.Text = "Tạp chí";
            rbTapChi.UseVisualStyleBackColor = true;
            // 
            // rbGiaoTrinh
            // 
            rbGiaoTrinh.AutoSize = true;
            rbGiaoTrinh.Location = new Point(6, 28);
            rbGiaoTrinh.Name = "rbGiaoTrinh";
            rbGiaoTrinh.Size = new Size(97, 25);
            rbGiaoTrinh.TabIndex = 11;
            rbGiaoTrinh.TabStop = true;
            rbGiaoTrinh.Text = "Giáo trình";
            rbGiaoTrinh.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(311, 9);
            label6.Name = "label6";
            label6.Size = new Size(161, 32);
            label6.TabIndex = 11;
            label6.Text = "Quản Lý Sách";
            // 
            // dgSach
            // 
            dgSach.AllowUserToAddRows = false;
            dgSach.AllowUserToDeleteRows = false;
            dgSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSach.Location = new Point(12, 262);
            dgSach.MultiSelect = false;
            dgSach.Name = "dgSach";
            dgSach.ReadOnly = true;
            dgSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSach.Size = new Size(742, 178);
            dgSach.TabIndex = 12;
            dgSach.CellContentClick += dgSach_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 446);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 40);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(227, 446);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 40);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(413, 446);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 40);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(599, 446);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 40);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 498);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnReset);
            Controls.Add(btnThem);
            Controls.Add(dgSach);
            Controls.Add(label6);
            Controls.Add(gbTheLoai);
            Controls.Add(cbNgonNgu);
            Controls.Add(tbTimKiem);
            Controls.Add(tbTacGia);
            Controls.Add(tbTenS);
            Controls.Add(tbMaS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gbTheLoai.ResumeLayout(false);
            gbTheLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbMaS;
        private TextBox tbTenS;
        private TextBox tbTacGia;
        private TextBox tbTimKiem;
        private ComboBox cbNgonNgu;
        private GroupBox gbTheLoai;
        private RadioButton rbSThamKhao;
        private RadioButton rbSChuyenKhao;
        private RadioButton rbTapChi;
        private RadioButton rbGiaoTrinh;
        private Label label6;
        private DataGridView dgSach;
        private Button btnThem;
        private Button btnReset;
        private Button btnSua;
        private Button btnXoa;
    }
}
