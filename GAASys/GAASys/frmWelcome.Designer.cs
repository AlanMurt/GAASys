namespace GAASys
{
    partial class frmWelcome
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
            System.Windows.Forms.MenuStrip MenuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.TeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FixturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            MenuStrip1 = new System.Windows.Forms.MenuStrip();
            MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TeamsToolStripMenuItem,
            this.FixturesToolStripMenuItem,
            this.AnalysisToolStripMenuItem,
            this.QuitToolStripMenuItem});
            MenuStrip1.Location = new System.Drawing.Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new System.Drawing.Size(435, 24);
            MenuStrip1.TabIndex = 3;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // TeamsToolStripMenuItem
            // 
            this.TeamsToolStripMenuItem.Name = "TeamsToolStripMenuItem";
            this.TeamsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.TeamsToolStripMenuItem.Text = "Teams";
            this.TeamsToolStripMenuItem.Click += new System.EventHandler(this.TeamsToolStripMenuItem_Click);
            // 
            // FixturesToolStripMenuItem
            // 
            this.FixturesToolStripMenuItem.Name = "FixturesToolStripMenuItem";
            this.FixturesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.FixturesToolStripMenuItem.Text = "Fixtures";
            this.FixturesToolStripMenuItem.Click += new System.EventHandler(this.FixturesToolStripMenuItem_Click);
            // 
            // AnalysisToolStripMenuItem
            // 
            this.AnalysisToolStripMenuItem.Name = "AnalysisToolStripMenuItem";
            this.AnalysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.AnalysisToolStripMenuItem.Text = "Analysis";
            this.AnalysisToolStripMenuItem.Click += new System.EventHandler(this.AnalysisToolStripMenuItem_Click);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.QuitToolStripMenuItem.Text = "Quit";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Forte", 20F);
            this.Label1.ForeColor = System.Drawing.Color.Gold;
            this.Label1.Location = new System.Drawing.Point(61, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(343, 48);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Welcome to the GAASys ";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 403);
            this.Controls.Add(MenuStrip1);
            this.Controls.Add(this.Label1);
            this.DoubleBuffered = true;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWelcome_FormClosed);
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStripMenuItem TeamsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FixturesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AnalysisToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
    }
}

