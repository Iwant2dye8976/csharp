namespace QLSACH_Json
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
            rbGiaoTrinh = new RadioButton();
            gbTheLoai = new GroupBox();
            rbSThamKhao = new RadioButton();
            rbSChuyenKhao = new RadioButton();
            rbTapChi = new RadioButton();
            tbMaSach = new TextBox();
            tbTenSach = new TextBox();
            tbTacGia = new TextBox();
            tbTimKiem = new TextBox();
            label5 = new Label();
            cbNgonNgu = new ComboBox();
            dgSach = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnReset = new Button();
            btnXoa = new Button();
            label6 = new Label();
            gbTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(46, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(46, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(46, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Tác giả";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(467, 79);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "Ngôn ngữ";
            // 
            // rbGiaoTrinh
            // 
            rbGiaoTrinh.AutoSize = true;
            rbGiaoTrinh.Location = new Point(6, 28);
            rbGiaoTrinh.Name = "rbGiaoTrinh";
            rbGiaoTrinh.Size = new Size(97, 25);
            rbGiaoTrinh.TabIndex = 4;
            rbGiaoTrinh.TabStop = true;
            rbGiaoTrinh.Text = "Giáo trình";
            rbGiaoTrinh.UseVisualStyleBackColor = true;
            // 
            // gbTheLoai
            // 
            gbTheLoai.Anchor = AnchorStyles.Top;
            gbTheLoai.Controls.Add(rbSThamKhao);
            gbTheLoai.Controls.Add(rbGiaoTrinh);
            gbTheLoai.Controls.Add(rbSChuyenKhao);
            gbTheLoai.Controls.Add(rbTapChi);
            gbTheLoai.Location = new Point(467, 133);
            gbTheLoai.Name = "gbTheLoai";
            gbTheLoai.Size = new Size(285, 114);
            gbTheLoai.TabIndex = 5;
            gbTheLoai.TabStop = false;
            gbTheLoai.Text = "Thể loại";
            gbTheLoai.Enter += gbTheLoai_Enter;
            // 
            // rbSThamKhao
            // 
            rbSThamKhao.AutoSize = true;
            rbSThamKhao.Location = new Point(126, 74);
            rbSThamKhao.Name = "rbSThamKhao";
            rbSThamKhao.Size = new Size(139, 25);
            rbSThamKhao.TabIndex = 8;
            rbSThamKhao.TabStop = true;
            rbSThamKhao.Text = "Sách tham khảo";
            rbSThamKhao.UseVisualStyleBackColor = true;
            // 
            // rbSChuyenKhao
            // 
            rbSChuyenKhao.AutoSize = true;
            rbSChuyenKhao.Location = new Point(126, 28);
            rbSChuyenKhao.Name = "rbSChuyenKhao";
            rbSChuyenKhao.Size = new Size(153, 25);
            rbSChuyenKhao.TabIndex = 7;
            rbSChuyenKhao.TabStop = true;
            rbSChuyenKhao.Text = "Sách chuyên khảo";
            rbSChuyenKhao.UseVisualStyleBackColor = true;
            // 
            // rbTapChi
            // 
            rbTapChi.AutoSize = true;
            rbTapChi.Location = new Point(6, 74);
            rbTapChi.Name = "rbTapChi";
            rbTapChi.Size = new Size(77, 25);
            rbTapChi.TabIndex = 6;
            rbTapChi.TabStop = true;
            rbTapChi.Text = "Tạp chí";
            rbTapChi.UseVisualStyleBackColor = true;
            // 
            // tbMaSach
            // 
            tbMaSach.Anchor = AnchorStyles.Top;
            tbMaSach.BorderStyle = BorderStyle.FixedSingle;
            tbMaSach.Location = new Point(131, 80);
            tbMaSach.Name = "tbMaSach";
            tbMaSach.Size = new Size(243, 29);
            tbMaSach.TabIndex = 6;
            // 
            // tbTenSach
            // 
            tbTenSach.Anchor = AnchorStyles.Top;
            tbTenSach.BorderStyle = BorderStyle.FixedSingle;
            tbTenSach.Location = new Point(131, 143);
            tbTenSach.Name = "tbTenSach";
            tbTenSach.Size = new Size(243, 29);
            tbTenSach.TabIndex = 7;
            // 
            // tbTacGia
            // 
            tbTacGia.Anchor = AnchorStyles.Top;
            tbTacGia.BorderStyle = BorderStyle.FixedSingle;
            tbTacGia.Location = new Point(131, 206);
            tbTacGia.Name = "tbTacGia";
            tbTacGia.Size = new Size(243, 29);
            tbTacGia.TabIndex = 8;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Anchor = AnchorStyles.Bottom;
            tbTimKiem.BorderStyle = BorderStyle.FixedSingle;
            tbTimKiem.Location = new Point(307, 266);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(243, 29);
            tbTimKiem.TabIndex = 9;
            tbTimKiem.TextChanged += tbTimKiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 266);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 10;
            label5.Text = "Tìm sách";
            // 
            // cbNgonNgu
            // 
            cbNgonNgu.Anchor = AnchorStyles.Top;
            cbNgonNgu.FormattingEnabled = true;
            cbNgonNgu.Items.AddRange(new object[] { "Tiếng Việt", "Tiếng Anh", "Tiếng Pháp" });
            cbNgonNgu.Location = new Point(554, 75);
            cbNgonNgu.Name = "cbNgonNgu";
            cbNgonNgu.Size = new Size(198, 29);
            cbNgonNgu.TabIndex = 11;
            // 
            // dgSach
            // 
            dgSach.AllowUserToAddRows = false;
            dgSach.AllowUserToDeleteRows = false;
            dgSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSach.Location = new Point(46, 301);
            dgSach.MultiSelect = false;
            dgSach.Name = "dgSach";
            dgSach.ReadOnly = true;
            dgSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSach.Size = new Size(706, 155);
            dgSach.TabIndex = 12;
            dgSach.CellContentClick += dgSach_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(99, 462);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 39);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.Location = new Point(258, 462);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 39);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom;
            btnReset.Location = new Point(417, 462);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 39);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.Location = new Point(576, 462);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 39);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(344, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 30);
            label6.TabIndex = 17;
            label6.Text = "Quản Lý Sách";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 553);
            Controls.Add(label6);
            Controls.Add(btnXoa);
            Controls.Add(btnReset);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgSach);
            Controls.Add(cbNgonNgu);
            Controls.Add(label5);
            Controls.Add(tbTimKiem);
            Controls.Add(tbTacGia);
            Controls.Add(tbTenSach);
            Controls.Add(tbMaSach);
            Controls.Add(gbTheLoai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
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
        private RadioButton rbGiaoTrinh;
        private GroupBox gbTheLoai;
        private RadioButton rbTapChi;
        private RadioButton rbSChuyenKhao;
        private RadioButton rbSThamKhao;
        private TextBox tbMaSach;
        private TextBox tbTenSach;
        private TextBox tbTacGia;
        private TextBox tbTimKiem;
        private Label label5;
        private ComboBox cbNgonNgu;
        private DataGridView dgSach;
        private Button btnThem;
        private Button btnSua;
        private Button btnReset;
        private Button btnXoa;
        private Label label6;
    }
}
