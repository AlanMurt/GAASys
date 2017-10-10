namespace GAASys
{
    partial class frmGenerateFixtures
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.genFixturesButton = new System.Windows.Forms.Button();
            this.hbProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(-1, -1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(37, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Forte", 18F);
            this.Label1.ForeColor = System.Drawing.Color.Gold;
            this.Label1.Location = new System.Drawing.Point(75, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(348, 53);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Click on the button below to Generate fixtures for next season";
            // 
            // genFixturesButton
            // 
            this.genFixturesButton.BackColor = System.Drawing.Color.Gold;
            this.genFixturesButton.Location = new System.Drawing.Point(280, 182);
            this.genFixturesButton.Name = "genFixturesButton";
            this.genFixturesButton.Size = new System.Drawing.Size(106, 77);
            this.genFixturesButton.TabIndex = 22;
            this.genFixturesButton.Text = "Generate Fixtures";
            this.genFixturesButton.UseVisualStyleBackColor = false;
            this.genFixturesButton.Click += new System.EventHandler(this.genFixturesButton_Click);
            // 
            // hbProgress
            // 
            this.hbProgress.BackColor = System.Drawing.Color.Gold;
            this.hbProgress.Location = new System.Drawing.Point(39, 358);
            this.hbProgress.Name = "hbProgress";
            this.hbProgress.Size = new System.Drawing.Size(360, 23);
            this.hbProgress.TabIndex = 23;
            // 
            // frmGenerateFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::GAASys.Properties.Resources.backLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 403);
            this.Controls.Add(this.hbProgress);
            this.Controls.Add(this.genFixturesButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonBack);
            this.DoubleBuffered = true;
            this.Name = "frmGenerateFixtures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Fixtures";
            this.Load += new System.EventHandler(this.frmGenerateFixtures_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button genFixturesButton;
        private System.Windows.Forms.ProgressBar hbProgress;
    }
}