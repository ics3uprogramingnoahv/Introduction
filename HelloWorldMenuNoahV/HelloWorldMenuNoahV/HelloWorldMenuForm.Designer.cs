namespace HelloWorldMenuNoahV
{
    partial class frmHelloWorldMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorldMenu));
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.mnuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenuStrip
            // 
            this.mnuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuStrip.Name = "mnuMenuStrip";
            this.mnuMenuStrip.Size = new System.Drawing.Size(364, 24);
            this.mnuMenuStrip.TabIndex = 0;
            this.mnuMenuStrip.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            this.mniProgram.Click += new System.EventHandler(this.progarmToolStripMenuItem_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(77, 106);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(221, 42);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "Hello World";
            this.lblHelloWorld.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmHelloWorldMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.mnuMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenuStrip;
            this.Name = "frmHelloWorldMenu";
            this.Text = "Hello World With Menu By Noah";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

