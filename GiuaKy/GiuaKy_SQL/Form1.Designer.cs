namespace Slq_Method
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
            cbMaSV = new ComboBox();
            cbMonHoc = new ComboBox();
            tbDiem = new TextBox();
            btnCapNhat = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            dgDiem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDiem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(124, 75);
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
            label2.Location = new Point(124, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Môn Học";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(124, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 2;
            label3.Text = "Điểm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(362, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 37);
            label4.TabIndex = 3;
            label4.Text = "Quản Lý Điểm";
            // 
            // cbMaSV
            // 
            cbMaSV.Anchor = AnchorStyles.Top;
            cbMaSV.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbMaSV.FormattingEnabled = true;
            cbMaSV.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbMaSV.Location = new Point(213, 72);
            cbMaSV.MaxDropDownItems = 5;
            cbMaSV.Name = "cbMaSV";
            cbMaSV.Size = new Size(204, 29);
            cbMaSV.TabIndex = 4;
            // 
            // cbMonHoc
            // 
            cbMonHoc.Anchor = AnchorStyles.Top;
            cbMonHoc.FormattingEnabled = true;
            cbMonHoc.Items.AddRange(new object[] { "JavScript", "Suôi Bì", "Bảy cỏ" });
            cbMonHoc.Location = new Point(213, 122);
            cbMonHoc.Name = "cbMonHoc";
            cbMonHoc.Size = new Size(204, 29);
            cbMonHoc.TabIndex = 5;
            // 
            // tbDiem
            // 
            tbDiem.Anchor = AnchorStyles.Top;
            tbDiem.BorderStyle = BorderStyle.FixedSingle;
            tbDiem.Location = new Point(213, 175);
            tbDiem.Name = "tbDiem";
            tbDiem.Size = new Size(204, 29);
            tbDiem.TabIndex = 6;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Top;
            btnCapNhat.Location = new Point(541, 66);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(131, 38);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "Cập nhật điểm";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(541, 116);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 38);
            btnSua.TabIndex = 8;
            btnSua.Text = "Reset";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(541, 169);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 38);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(541, 222);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 38);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgDiem
            // 
            dgDiem.AllowUserToAddRows = false;
            dgDiem.AllowUserToDeleteRows = false;
            dgDiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDiem.Location = new Point(2, 268);
            dgDiem.MultiSelect = false;
            dgDiem.Name = "dgDiem";
            dgDiem.ReadOnly = true;
            dgDiem.Size = new Size(914, 201);
            dgDiem.TabIndex = 11;
            dgDiem.CellContentClick += dgDiem_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 472);
            Controls.Add(dgDiem);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnCapNhat);
            Controls.Add(tbDiem);
            Controls.Add(cbMonHoc);
            Controls.Add(cbMaSV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbMaSV;
        private ComboBox cbMonHoc;
        private TextBox tbDiem;
        private Button btnCapNhat;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private DataGridView dgDiem;
    }
}
