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
            tbMaSV = new TextBox();
            tbTenSV = new TextBox();
            tbDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            label6 = new Label();
            tbTimKiem = new TextBox();
            dgSinhVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(108, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(108, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "Mã sinh viên:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(126, 141);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(149, 178);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ:";
            // 
            // tbMaSV
            // 
            tbMaSV.Anchor = AnchorStyles.Top;
            tbMaSV.BorderStyle = BorderStyle.FixedSingle;
            tbMaSV.Location = new Point(233, 53);
            tbMaSV.Name = "tbMaSV";
            tbMaSV.Size = new Size(351, 29);
            tbMaSV.TabIndex = 5;
            // 
            // tbTenSV
            // 
            tbTenSV.Anchor = AnchorStyles.Top;
            tbTenSV.BorderStyle = BorderStyle.FixedSingle;
            tbTenSV.Location = new Point(233, 94);
            tbTenSV.Name = "tbTenSV";
            tbTenSV.Size = new Size(351, 29);
            tbTenSV.TabIndex = 6;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Anchor = AnchorStyles.Top;
            tbDiaChi.BorderStyle = BorderStyle.FixedSingle;
            tbDiaChi.Location = new Point(233, 176);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(351, 29);
            tbDiaChi.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Top;
            dtpNgaySinh.CustomFormat = "";
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(232, 135);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(351, 29);
            dtpNgaySinh.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(233, 226);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 36);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(359, 226);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(98, 36);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(485, 226);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 36);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(132, 283);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 12;
            label6.Text = "Tìm kiếm:";
            // 
            // tbTimKiem
            // 
            tbTimKiem.Anchor = AnchorStyles.Top;
            tbTimKiem.BorderStyle = BorderStyle.FixedSingle;
            tbTimKiem.Location = new Point(233, 281);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(351, 29);
            tbTimKiem.TabIndex = 13;
            tbTimKiem.TextChanged += tbTimKiem_TextChanged;
            // 
            // dgSinhVien
            // 
            dgSinhVien.AllowUserToAddRows = false;
            dgSinhVien.AllowUserToDeleteRows = false;
            dgSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSinhVien.Location = new Point(12, 345);
            dgSinhVien.MultiSelect = false;
            dgSinhVien.Name = "dgSinhVien";
            dgSinhVien.ReadOnly = true;
            dgSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSinhVien.Size = new Size(736, 281);
            dgSinhVien.TabIndex = 14;
            dgSinhVien.CellClick += dgSinhVien_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 630);
            Controls.Add(dgSinhVien);
            Controls.Add(tbTimKiem);
            Controls.Add(label6);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(dtpNgaySinh);
            Controls.Add(tbDiaChi);
            Controls.Add(tbTenSV);
            Controls.Add(tbMaSV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD Database";
            FormClosing += Form_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbMaSV;
        private TextBox tbTenSV;
        private TextBox tbDiaChi;
        private DateTimePicker dtpNgaySinh;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Label label6;
        private TextBox tbTimKiem;
        private DataGridView dgSinhVien;
    }
}
