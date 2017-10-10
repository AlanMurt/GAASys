namespace GAASys
{
    partial class frmTeams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeams));
            this.buttonBack = new System.Windows.Forms.Button();
            this.regTeamButton = new System.Windows.Forms.Button();
            this.changeTeamButton = new System.Windows.Forms.Button();
            this.remTeamButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(-1, -1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(37, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // regTeamButton
            // 
            this.regTeamButton.BackColor = System.Drawing.Color.Gold;
            this.regTeamButton.Location = new System.Drawing.Point(252, 125);
            this.regTeamButton.Name = "regTeamButton";
            this.regTeamButton.Size = new System.Drawing.Size(154, 27);
            this.regTeamButton.TabIndex = 7;
            this.regTeamButton.Text = "Register Team";
            this.regTeamButton.UseVisualStyleBackColor = false;
            this.regTeamButton.Click += new System.EventHandler(this.regTeamButton_Click);
            // 
            // changeTeamButton
            // 
            this.changeTeamButton.BackColor = System.Drawing.Color.Gold;
            this.changeTeamButton.Location = new System.Drawing.Point(252, 200);
            this.changeTeamButton.Name = "changeTeamButton";
            this.changeTeamButton.Size = new System.Drawing.Size(154, 27);
            this.changeTeamButton.TabIndex = 8;
            this.changeTeamButton.Text = "Change Team";
            this.changeTeamButton.UseVisualStyleBackColor = false;
            this.changeTeamButton.Click += new System.EventHandler(this.changeTeamButton_Click);
            // 
            // remTeamButton
            // 
            this.remTeamButton.BackColor = System.Drawing.Color.Gold;
            this.remTeamButton.Location = new System.Drawing.Point(252, 275);
            this.remTeamButton.Name = "remTeamButton";
            this.remTeamButton.Size = new System.Drawing.Size(154, 27);
            this.remTeamButton.TabIndex = 9;
            this.remTeamButton.Text = "Remove Team";
            this.remTeamButton.UseVisualStyleBackColor = false;
            this.remTeamButton.Click += new System.EventHandler(this.remTeamButton_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Forte", 18F);
            this.Label1.ForeColor = System.Drawing.Color.Gold;
            this.Label1.Location = new System.Drawing.Point(12, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(394, 52);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Choose one of the following options";
            // 
            // frmTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 403);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.remTeamButton);
            this.Controls.Add(this.changeTeamButton);
            this.Controls.Add(this.regTeamButton);
            this.Controls.Add(this.buttonBack);
            this.DoubleBuffered = true;
            this.Name = "frmTeams";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teams";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button regTeamButton;
        private System.Windows.Forms.Button changeTeamButton;
        private System.Windows.Forms.Button remTeamButton;
        internal System.Windows.Forms.Label Label1;
    }
}