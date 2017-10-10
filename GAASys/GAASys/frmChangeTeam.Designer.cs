namespace GAASys
{
    partial class frmChangeTeam
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
            this.grpTeam = new System.Windows.Forms.GroupBox();
            this.txtTeamId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeamContactName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeamContactNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeamEmail = new System.Windows.Forms.TextBox();
            this.txtTeamVenue = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeTeamButton = new System.Windows.Forms.Button();
            this.grpTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(-1, -1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(37, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Forte", 18F);
            this.Label1.ForeColor = System.Drawing.Color.Gold;
            this.Label1.Location = new System.Drawing.Point(28, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(281, 52);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Select a team to change fom the dropdown menu";
            // 
            // selectTeamCombo
            // 
            this.selectTeamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTeamCombo.FormattingEnabled = true;
            this.selectTeamCombo.Location = new System.Drawing.Point(305, 41);
            this.selectTeamCombo.Name = "selectTeamCombo";
            this.selectTeamCombo.Size = new System.Drawing.Size(121, 21);
            this.selectTeamCombo.TabIndex = 12;
            this.selectTeamCombo.SelectedIndexChanged += new System.EventHandler(this.selectTeamCombo_SelectedIndexChanged);
            // 
            // grpTeam
            // 
            this.grpTeam.Controls.Add(this.txtTeamId);
            this.grpTeam.Controls.Add(this.label2);
            this.grpTeam.Controls.Add(this.txtTeamContactName);
            this.grpTeam.Controls.Add(this.label7);
            this.grpTeam.Controls.Add(this.txtTeamContactNumber);
            this.grpTeam.Controls.Add(this.label6);
            this.grpTeam.Controls.Add(this.txtTeamEmail);
            this.grpTeam.Controls.Add(this.txtTeamVenue);
            this.grpTeam.Controls.Add(this.txtTeamName);
            this.grpTeam.Controls.Add(this.label5);
            this.grpTeam.Controls.Add(this.label4);
            this.grpTeam.Controls.Add(this.label3);
            this.grpTeam.Controls.Add(this.changeTeamButton);
            this.grpTeam.Location = new System.Drawing.Point(218, 80);
            this.grpTeam.Name = "grpTeam";
            this.grpTeam.Size = new System.Drawing.Size(224, 321);
            this.grpTeam.TabIndex = 13;
            this.grpTeam.TabStop = false;
            this.grpTeam.Visible = false;
            // 
            // txtTeamId
            // 
            this.txtTeamId.Location = new System.Drawing.Point(71, 16);
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.ReadOnly = true;
            this.txtTeamId.Size = new System.Drawing.Size(56, 20);
            this.txtTeamId.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Id:";
            // 
            // txtTeamContactName
            // 
            this.txtTeamContactName.Location = new System.Drawing.Point(71, 196);
            this.txtTeamContactName.Name = "txtTeamContactName";
            this.txtTeamContactName.Size = new System.Drawing.Size(139, 20);
            this.txtTeamContactName.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 40);
            this.label7.TabIndex = 49;
            this.label7.Text = "Contact Name:";
            // 
            // txtTeamContactNumber
            // 
            this.txtTeamContactNumber.Location = new System.Drawing.Point(71, 241);
            this.txtTeamContactNumber.Name = "txtTeamContactNumber";
            this.txtTeamContactNumber.Size = new System.Drawing.Size(139, 20);
            this.txtTeamContactNumber.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(6, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 43);
            this.label6.TabIndex = 48;
            this.label6.Text = "Contact Number:";
            // 
            // txtTeamEmail
            // 
            this.txtTeamEmail.Location = new System.Drawing.Point(71, 151);
            this.txtTeamEmail.Name = "txtTeamEmail";
            this.txtTeamEmail.Size = new System.Drawing.Size(139, 20);
            this.txtTeamEmail.TabIndex = 45;
            // 
            // txtTeamVenue
            // 
            this.txtTeamVenue.Location = new System.Drawing.Point(71, 106);
            this.txtTeamVenue.Name = "txtTeamVenue";
            this.txtTeamVenue.Size = new System.Drawing.Size(139, 20);
            this.txtTeamVenue.TabIndex = 44;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(71, 61);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(139, 20);
            this.txtTeamName.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Venue:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Name:";
            // 
            // changeTeamButton
            // 
            this.changeTeamButton.BackColor = System.Drawing.Color.Gold;
            this.changeTeamButton.Location = new System.Drawing.Point(140, 271);
            this.changeTeamButton.Name = "changeTeamButton";
            this.changeTeamButton.Size = new System.Drawing.Size(70, 45);
            this.changeTeamButton.TabIndex = 39;
            this.changeTeamButton.Text = "Change Team";
            this.changeTeamButton.UseVisualStyleBackColor = false;
            this.changeTeamButton.Click += new System.EventHandler(this.changeTeamButton_Click);
            // 
            // frmChangeTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::GAASys.Properties.Resources.backLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 403);
            this.Controls.Add(this.grpTeam);
            this.Controls.Add(this.selectTeamCombo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonBack);
            this.DoubleBuffered = true;
            this.Name = "frmChangeTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Team";
            this.Load += new System.EventHandler(this.frmChangeTeam_Load);
            this.grpTeam.ResumeLayout(false);
            this.grpTeam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.ComboBox selectTeamCombo;
        private System.Windows.Forms.GroupBox grpTeam;
        private System.Windows.Forms.TextBox txtTeamId;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeamContactName;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTeamContactNumber;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeamEmail;
        private System.Windows.Forms.TextBox txtTeamVenue;
        public System.Windows.Forms.TextBox txtTeamName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changeTeamButton;
    }
}