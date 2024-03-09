namespace Bai8
{
    partial class replace
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
            txtbFilter = new TextBox();
            txtbReplace = new TextBox();
            btnReplace = new Button();
            SuspendLayout();
            // 
            // txtbFilter
            // 
            txtbFilter.BorderStyle = BorderStyle.FixedSingle;
            txtbFilter.Location = new Point(-1, 9);
            txtbFilter.Name = "txtbFilter";
            txtbFilter.PlaceholderText = "Filter";
            txtbFilter.Size = new Size(543, 43);
            txtbFilter.TabIndex = 0;
            // 
            // txtbReplace
            // 
            txtbReplace.BorderStyle = BorderStyle.FixedSingle;
            txtbReplace.Location = new Point(-1, 58);
            txtbReplace.Name = "txtbReplace";
            txtbReplace.PlaceholderText = "Replace text";
            txtbReplace.Size = new Size(543, 43);
            txtbReplace.TabIndex = 1;
            // 
            // btnReplace
            // 
            btnReplace.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReplace.Location = new Point(548, 9);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(97, 92);
            btnReplace.TabIndex = 3;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // replace
            // 
            AcceptButton = btnReplace;
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 127);
            Controls.Add(btnReplace);
            Controls.Add(txtbReplace);
            Controls.Add(txtbFilter);
            Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "replace";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Replace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbFilter;
        private TextBox txtbReplace;
        private Button btnReplace;
    }
}