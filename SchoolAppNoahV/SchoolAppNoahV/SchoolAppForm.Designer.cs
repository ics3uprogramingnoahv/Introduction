namespace SchoolAppNoahV
{
    partial class frmSchoolApp
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
            this.mnumenuStrip = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.mnumenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnumenuStrip
            // 
            this.mnumenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnumenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnumenuStrip.Name = "mnumenuStrip";
            this.mnumenuStrip.Size = new System.Drawing.Size(577, 24);
            this.mnumenuStrip.TabIndex = 0;
            this.mnumenuStrip.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSchool.Location = new System.Drawing.Point(34, 66);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(491, 108);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "Imacullata";
            this.lblSchool.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTeam.Location = new System.Drawing.Point(227, 183);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(78, 25);
            this.lblTeam.TabIndex = 2;
            this.lblTeam.Text = "Saints";
            // 
            // frmSchoolApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(577, 426);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.mnumenuStrip);
            this.MainMenuStrip = this.mnumenuStrip;
            this.Name = "frmSchoolApp";
            this.Text = "School App By NoahV";
            this.mnumenuStrip.ResumeLayout(false);
            this.mnumenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnumenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblTeam;
    }
}

