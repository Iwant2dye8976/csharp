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
            components = new System.ComponentModel.Container();
            lbla = new Label();
            lblb = new Label();
            lblc = new Label();
            txtBa = new TextBox();
            txtBb = new TextBox();
            txtBc = new TextBox();
            btnGiai = new Button();
            btnXoa = new Button();
            lblTitle = new Label();
            ctxtMenuEdit = new ContextMenuStrip(components);
            tsmDoiMau = new ToolStripMenuItem();
            tsmDoiFont = new ToolStripMenuItem();
            lblNghiem = new Label();
            ctxtMenuEdit.SuspendLayout();
            SuspendLayout();
            // 
            // lbla
            // 
            lbla.AutoSize = true;
            lbla.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbla.Location = new Point(32, 129);
            lbla.Name = "lbla";
            lbla.Size = new Size(34, 21);
            lbla.TabIndex = 0;
            lbla.Text = "a =";
            lbla.MouseClick += txtBa_MouseClick;
            // 
            // lblb
            // 
            lblb.AutoSize = true;
            lblb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblb.Location = new Point(32, 161);
            lblb.Name = "lblb";
            lblb.Size = new Size(35, 21);
            lblb.TabIndex = 1;
            lblb.Text = "b =";
            lblb.MouseClick += txtBa_MouseClick;
            // 
            // lblc
            // 
            lblc.AutoSize = true;
            lblc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblc.Location = new Point(32, 194);
            lblc.Name = "lblc";
            lblc.Size = new Size(33, 21);
            lblc.TabIndex = 2;
            lblc.Text = "c =";
            lblc.MouseClick += txtBa_MouseClick;
            // 
            // txtBa
            // 
            txtBa.BackColor = Color.Wheat;
            txtBa.Font = new Font("Segoe UI", 12F);
            txtBa.Location = new Point(108, 121);
            txtBa.Name = "txtBa";
            txtBa.Size = new Size(152, 29);
            txtBa.TabIndex = 3;
            txtBa.MouseClick += txtBa_MouseClick;
            // 
            // txtBb
            // 
            txtBb.BackColor = Color.Wheat;
            txtBb.Font = new Font("Segoe UI", 12F);
            txtBb.Location = new Point(108, 153);
            txtBb.Name = "txtBb";
            txtBb.Size = new Size(152, 29);
            txtBb.TabIndex = 4;
            txtBb.MouseClick += txtBa_MouseClick;
            // 
            // txtBc
            // 
            txtBc.BackColor = Color.Wheat;
            txtBc.Font = new Font("Segoe UI", 12F);
            txtBc.Location = new Point(108, 186);
            txtBc.Name = "txtBc";
            txtBc.Size = new Size(152, 29);
            txtBc.TabIndex = 5;
            txtBc.MouseClick += txtBa_MouseClick;
            // 
            // btnGiai
            // 
            btnGiai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGiai.Location = new Point(319, 121);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(96, 52);
            btnGiai.TabIndex = 6;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            btnGiai.MouseClick += txtBa_MouseClick;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(319, 186);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 30);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            btnXoa.MouseClick += txtBa_MouseClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(91, 75);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(333, 25);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Giải phương trình ax^2 + bx + c = 0";
            lblTitle.MouseClick += txtBa_MouseClick;
            // 
            // ctxtMenuEdit
            // 
            ctxtMenuEdit.BackColor = SystemColors.Control;
            ctxtMenuEdit.Items.AddRange(new ToolStripItem[] { tsmDoiMau, tsmDoiFont });
            ctxtMenuEdit.Name = "ctxtMenuEdit";
            ctxtMenuEdit.Size = new Size(120, 48);
            // 
            // tsmDoiMau
            // 
            tsmDoiMau.Name = "tsmDoiMau";
            tsmDoiMau.Size = new Size(119, 22);
            tsmDoiMau.Text = "Đổi màu";
            tsmDoiMau.Click += tsmDoiMau_Click;
            // 
            // tsmDoiFont
            // 
            tsmDoiFont.Name = "tsmDoiFont";
            tsmDoiFont.Size = new Size(119, 22);
            tsmDoiFont.Text = "Đổi font";
            tsmDoiFont.Click += tsmDoiFont_Click;
            // 
            // lblNghiem
            // 
            lblNghiem.AutoSize = true;
            lblNghiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNghiem.Location = new Point(32, 258);
            lblNghiem.Name = "lblNghiem";
            lblNghiem.Size = new Size(217, 21);
            lblNghiem.TabIndex = 9;
            lblNghiem.Text = "Nghiệm của phương trình: ";
            lblNghiem.MouseClick += txtBa_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 455);
            Controls.Add(lblNghiem);
            Controls.Add(lblTitle);
            Controls.Add(btnXoa);
            Controls.Add(btnGiai);
            Controls.Add(txtBc);
            Controls.Add(txtBb);
            Controls.Add(txtBa);
            Controls.Add(lblc);
            Controls.Add(lblb);
            Controls.Add(lbla);
            Name = "Form1";
            Text = "Giải phương trình bậc 2";
            MouseClick += txtBa_MouseClick;
            ctxtMenuEdit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbla;
        private Label lblb;
        private Label lblc;
        private TextBox txtBa;
        private TextBox txtBb;
        private TextBox txtBc;
        private Button btnGiai;
        private Button btnXoa;
        private Label lblTitle;
        private ContextMenuStrip ctxtMenuEdit;
        private ToolStripMenuItem tsmDoiMau;
        private ToolStripMenuItem tsmDoiFont;
        private Label lblNghiem;
    }
}
