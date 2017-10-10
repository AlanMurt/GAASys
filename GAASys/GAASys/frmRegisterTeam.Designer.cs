namespace GAASys
{
    partial class frmRegisterTeam
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtTeamVenue = new System.Windows.Forms.TextBox();
            this.txtTeamEmail = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.txtTeamContactNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeamContactName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeamId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(-1, -1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(37, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Forte", 18F);
            this.Label1.ForeColor = System.Drawing.Color.Gold;
            this.Label1.Location = new System.Drawing.Point(12, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(394, 52);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Input your details to the form below";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(210, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 52);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Team Details";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(210, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(210, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Venue:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(210, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(275, 125);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(139, 20);
            this.txtTeamName.TabIndex = 2;
            // 
            // txtTeamVenue
            // 
            this.txtTeamVenue.Location = new System.Drawing.Point(275, 170);
            this.txtTeamVenue.Name = "txtTeamVenue";
            this.txtTeamVenue.Size = new System.Drawing.Size(139, 20);
            this.txtTeamVenue.TabIndex = 3;
            // 
            // txtTeamEmail
            // 
            this.txtTeamEmail.Location = new System.Drawing.Point(275, 215);
            this.txtTeamEmail.Name = "txtTeamEmail";
            this.txtTeamEmail.Size = new System.Drawing.Size(139, 20);
            this.txtTeamEmail.TabIndex = 4;
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.Gold;
            this.regButton.Location = new System.Drawing.Point(336, 346);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(70, 45);
            this.regButton.TabIndex = 7;
            this.regButton.Text = "Register ";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // txtTeamContactNumber
            // 
            this.txtTeamContactNumber.Location = new System.Drawing.Point(275, 305);
            this.txtTeamContactNumber.Name = "txtTeamContactNumber";
            this.txtTeamContactNumber.Size = new System.Drawing.Size(139, 20);
            this.txtTeamContactNumber.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(210, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 43);
            this.label6.TabIndex = 20;
            this.label6.Text = "Contact Number";
            // 
            // txtTeamContactName
            // 
            this.txtTeamContactName.Location = new System.Drawing.Point(275, 260);
            this.txtTeamContactName.Name = "txtTeamContactName";
            this.txtTeamContactName.Size = new System.Drawing.Size(139, 20);
            this.txtTeamContactName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(210, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 40);
            this.label7.TabIndex = 22;
            this.label7.Text = "Contact Name:";
            // 
            // txtTeamId
            // 
            this.txtTeamId.Location = new System.Drawing.Point(362, 59);
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.ReadOnly = true;
            this.txtTeamId.Size = new System.Drawing.Size(62, 20);
            this.txtTeamId.TabIndex = 23;
            // 
            // frmRegisterTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::GAASys.Properties.Resources.backLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 403);
            this.Controls.Add(this.txtTeamId);
            this.Controls.Add(this.txtTeamContactName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTeamContactNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.txtTeamEmail);
            this.Controls.Add(this.txtTeamVenue);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonBack);
            this.DoubleBuffered = true;
            this.Name = "frmRegisterTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Team";
            this.Load += new System.EventHandler(this.frmRegisterTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtTeamVenue;
        private System.Windows.Forms.TextBox txtTeamEmail;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox txtTeamContactNumber;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeamContactName;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTeamId;
    }
}