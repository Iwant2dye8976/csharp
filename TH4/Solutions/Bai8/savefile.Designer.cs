namespace Bai8
{
    partial class savefile
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
            btnSave = new Button();
            btnNotSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(12, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNotSave
            // 
            btnNotSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnNotSave.ForeColor = SystemColors.ControlText;
            btnNotSave.Location = new Point(136, 13);
            btnNotSave.Name = "btnNotSave";
            btnNotSave.Size = new Size(100, 32);
            btnNotSave.TabIndex = 1;
            btnNotSave.Text = "Không lưu";
            btnNotSave.UseVisualStyleBackColor = true;
            btnNotSave.Click += btnNotSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(260, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // savefile
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(378, 48);
            Controls.Add(btnCancel);
            Controls.Add(btnNotSave);
            Controls.Add(btnSave);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "savefile";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bạn có muốn các lưu thay đổi?";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnNotSave;
        private Button btnCancel;
    }
}