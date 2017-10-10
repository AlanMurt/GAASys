namespace GAASys
{
    partial class frmRemoveTeam
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
            this.selectTeamCombo = new System.Windows.Forms.ComboBox();
            this.remTeamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(-1, -1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(37, 23);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Forte", 18F);
            this.Label1.ForeColor = System.Drawing.Color.Gold;
            this.Label1.Location = new System.Drawing.Point(92, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(281, 52);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Select a team to remove from the dropdown menu";
            // 
            // selectTeamCombo
            // 
            this.selectTeamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTeamCombo.FormattingEnabled = true;
            this.selectTeamCombo.Location = new System.Drawing.Point(262, 151);
            this.selectTeamCombo.Name = "selectTeamCombo";
            this.selectTeamCombo.Size = new System.Drawing.Size(121, 21);
            this.selectTeamCombo.TabIndex = 13;
            // 
            // remTeamButton
            // 
            this.remTeamButton.BackColor = System.Drawing.Color.Gold;
            this.remTeamButton.Location = new System.Drawing.Point(313, 200);
            this.remTeamButton.Name = "remTeamButton";
            this.remTeamButton.Size = new System.Drawing.Size(70, 45);
            this.remTeamButton.TabIndex = 21;
            this.remTeamButton.Text = "Remove Team";
            this.remTeamButton.UseVisualStyleBackColor = false;
            this.remTeamButton.Click += new System.EventHandler(this.remTeamButton_Click);
            // 
            // frmRemoveTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::GAASys.Properties.Resources.backLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 403);
            this.Controls.Add(this.remTeamButton);
            this.Controls.Add(this.selectTeamCombo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonBack);
            this.DoubleBuffered = true;
            this.Name = "frmRemoveTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Team";
            this.Load += new System.EventHandler(this.frmRemoveTeam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox selectTeamCombo;
        private System.Windows.Forms.Button remTeamButton;
    }
}