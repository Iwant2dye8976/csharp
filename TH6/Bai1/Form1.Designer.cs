namespace Bai1
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
            label6 = new Label();
            label7 = new Label();
            tbMaSV = new TextBox();
            tbHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            cbNoiSinh = new ComboBox();
            cbKhoa = new ComboBox();
            cbLop = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgSV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(66, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(66, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(66, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(66, 180);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(438, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 4;
            label5.Text = "Nơi sinh";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(438, 80);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 5;
            label6.Text = "Khoa";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(438, 130);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 6;
            label7.Text = "Lớp";
            // 
            // tbMaSV
            // 
            tbMaSV.Anchor = AnchorStyles.Top;
            tbMaSV.BorderStyle = BorderStyle.FixedSingle;
            tbMaSV.Location = new Point(152, 28);
            tbMaSV.Name = "tbMaSV";
            tbMaSV.Size = new Size(200, 29);
            tbMaSV.TabIndex = 7;
            // 
            // tbHoTen
            // 
            tbHoTen.Anchor = AnchorStyles.Top;
            tbHoTen.BorderStyle = BorderStyle.FixedSingle;
            tbHoTen.Location = new Point(152, 78);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(200, 29);
            tbHoTen.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Top;
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(153, 174);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 29);
            dtpNgaySinh.TabIndex = 10;
            // 
            // rbNam
            // 
            rbNam.Anchor = AnchorStyles.Top;
            rbNam.AutoSize = true;
            rbNam.Location = new Point(152, 128);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 25);
            rbNam.TabIndex = 11;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.Anchor = AnchorStyles.Top;
            rbNu.AutoSize = true;
            rbNu.Location = new Point(266, 128);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(49, 25);
            rbNu.TabIndex = 12;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // cbNoiSinh
            // 
            cbNoiSinh.Anchor = AnchorStyles.Top;
            cbNoiSinh.FormattingEnabled = true;
            cbNoiSinh.Items.AddRange(new object[] { "Hà Nội", "Đà Nẵng", "TP.Hồ Chí Minh" });
            cbNoiSinh.Location = new Point(514, 27);
            cbNoiSinh.Name = "cbNoiSinh";
            cbNoiSinh.Size = new Size(201, 29);
            cbNoiSinh.TabIndex = 13;
            // 
            // cbKhoa
            // 
            cbKhoa.Anchor = AnchorStyles.Top;
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Items.AddRange(new object[] { "CNTT", "Kinh tế", "Luật", "Công trình" });
            cbKhoa.Location = new Point(514, 77);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(201, 29);
            cbKhoa.TabIndex = 14;
            // 
            // cbLop
            // 
            cbLop.Anchor = AnchorStyles.Top;
            cbLop.FormattingEnabled = true;
            cbLop.Items.AddRange(new object[] { "64KTPM5" });
            cbLop.Location = new Point(514, 127);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(201, 29);
            cbLop.TabIndex = 15;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(438, 180);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 34);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(540, 180);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 34);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(635, 180);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 34);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgSV
            // 
            dgSV.AllowUserToAddRows = false;
            dgSV.AllowUserToDeleteRows = false;
            dgSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSV.Location = new Point(12, 232);
            dgSV.MultiSelect = false;
            dgSV.Name = "dgSV";
            dgSV.ReadOnly = true;
            dgSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSV.Size = new Size(779, 283);
            dgSV.TabIndex = 19;
            dgSV.CellContentClick += dgSV_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 519);
            Controls.Add(dgSV);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cbLop);
            Controls.Add(cbKhoa);
            Controls.Add(cbNoiSinh);
            Controls.Add(rbNu);
            Controls.Add(rbNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(tbHoTen);
            Controls.Add(tbMaSV);
            Controls.Add(label7);
            Controls.Add(label6);
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
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)dgSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbMaSV;
        private TextBox tbHoTen;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private ComboBox cbNoiSinh;
        private ComboBox cbKhoa;
        private ComboBox cbLop;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgSV;
    }
}
