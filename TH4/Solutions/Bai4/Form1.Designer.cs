namespace Bai4
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            changeToolStripMenuItem = new ToolStripMenuItem();
            backColorToolStripMenuItem = new ToolStripMenuItem();
            backImageToolStripMenuItem = new ToolStripMenuItem();
            fopntToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            mSTool = new MenuStrip();
            openFileDialog1 = new OpenFileDialog();
            mSTool.SuspendLayout();
            SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.CheckOnClick = true;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, editToolStripMenuItem, printToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(63, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(147, 36);
            openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(147, 36);
            editToolStripMenuItem.Text = "Edit";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(147, 36);
            printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(147, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // changeToolStripMenuItem
            // 
            changeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backColorToolStripMenuItem, backImageToolStripMenuItem, fopntToolStripMenuItem });
            changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            changeToolStripMenuItem.Size = new Size(108, 36);
            changeToolStripMenuItem.Text = "Change";
            // 
            // backColorToolStripMenuItem
            // 
            backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            backColorToolStripMenuItem.Size = new Size(210, 36);
            backColorToolStripMenuItem.Text = "Back Color";
            backColorToolStripMenuItem.Click += backColorToolStripMenuItem_Click;
            // 
            // backImageToolStripMenuItem
            // 
            backImageToolStripMenuItem.Name = "backImageToolStripMenuItem";
            backImageToolStripMenuItem.Size = new Size(210, 36);
            backImageToolStripMenuItem.Text = "Back Image";
            backImageToolStripMenuItem.Click += backImageToolStripMenuItem_Click;
            // 
            // fopntToolStripMenuItem
            // 
            fopntToolStripMenuItem.Name = "fopntToolStripMenuItem";
            fopntToolStripMenuItem.Size = new Size(210, 36);
            fopntToolStripMenuItem.Text = "Font";
            fopntToolStripMenuItem.Click += fopntToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(76, 36);
            helpToolStripMenuItem.Text = "Help";
            // 
            // mSTool
            // 
            mSTool.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mSTool.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, changeToolStripMenuItem, helpToolStripMenuItem });
            mSTool.Location = new Point(0, 0);
            mSTool.Name = "mSTool";
            mSTool.Size = new Size(664, 40);
            mSTool.TabIndex = 0;
            mSTool.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "oFdColor";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 441);
            Controls.Add(mSTool);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nguyễn Xuân Bình";
            mSTool.ResumeLayout(false);
            mSTool.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem changeToolStripMenuItem;
        private ToolStripMenuItem backColorToolStripMenuItem;
        private ToolStripMenuItem backImageToolStripMenuItem;
        private ToolStripMenuItem fopntToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private MenuStrip mSTool;
        private OpenFileDialog openFileDialog1;
    }
}
