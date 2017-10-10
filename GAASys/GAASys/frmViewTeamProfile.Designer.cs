namespace GAASys
{
    partial class frmViewTeamProfile
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
            this.txtTeamId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeamEmail = new System.Windows.Forms.TextBox();
            this.txtTeamVenue = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeamWon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeamScoresFor = new System.Windows.Forms.TextBox();
            this.txtTeamDrawn = new System.Windows.Forms.TextBox();
            this.txtTeamLost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTeamPoints = new System.Windows.Forms.TextBox();
            this.txtTeamScoresAgainst = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.Label1.Font = new System.Drawing.Font("Forte", 20F);
            this.Label1.ForeColor = System.Drawing.Color.Gold;
            this.Label1.Location = new System.Drawing.Point(146, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(177, 52);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Team Profile";
            // 
            // selectTeamCombo
            // 
            this.selectTeamCombo.FormattingEnabled = true;
            this.selectTeamCombo.Location = new System.Drawing.Point(166, 58);
            this.selectTeamCombo.Name = "selectTeamCombo";
            this.selectTeamCombo.Size = new System.Drawing.Size(121, 21);
            this.selectTeamCombo.TabIndex = 15;
            this.selectTeamCombo.Text = "Select Team...";
            this.selectTeamCombo.SelectedIndexChanged += new System.EventHandler(this.selectTeamCombo_SelectedIndexChanged);
            // 
            // txtTeamId
            // 
            this.txtTeamId.Location = new System.Drawing.Point(75, 171);
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.ReadOnly = true;
            this.txtTeamId.Size = new System.Drawing.Size(62, 20);
            this.txtTeamId.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(21, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Id:";
            // 
            // txtTeamEmail
            // 
            this.txtTeamEmail.Location = new System.Drawing.Point(75, 306);
            this.txtTeamEmail.Name = "txtTeamEmail";
            this.txtTeamEmail.ReadOnly = true;
            this.txtTeamEmail.Size = new System.Drawing.Size(139, 20);
            this.txtTeamEmail.TabIndex = 44;
            // 
            // txtTeamVenue
            // 
            this.txtTeamVenue.Location = new System.Drawing.Point(75, 261);
            this.txtTeamVenue.Name = "txtTeamVenue";
            this.txtTeamVenue.ReadOnly = true;
            this.txtTeamVenue.Size = new System.Drawing.Size(139, 20);
            this.txtTeamVenue.TabIndex = 43;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(75, 216);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.ReadOnly = true;
            this.txtTeamName.Size = new System.Drawing.Size(139, 20);
            this.txtTeamName.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(10, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(10, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Venue:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(10, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Name:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Forte", 16F);
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(37, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 52);
            this.label8.TabIndex = 51;
            this.label8.Text = "Profile";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Forte", 16F);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(291, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 52);
            this.label6.TabIndex = 52;
            this.label6.Text = "Performance Stats";
            // 
            // txtTeamWon
            // 
            this.txtTeamWon.Location = new System.Drawing.Point(329, 153);
            this.txtTeamWon.Name = "txtTeamWon";
            this.txtTeamWon.ReadOnly = true;
            this.txtTeamWon.Size = new System.Drawing.Size(84, 20);
            this.txtTeamWon.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(264, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 60;
            this.label7.Text = "Won:";
            // 
            // txtTeamScoresFor
            // 
            this.txtTeamScoresFor.Location = new System.Drawing.Point(329, 288);
            this.txtTeamScoresFor.Name = "txtTeamScoresFor";
            this.txtTeamScoresFor.ReadOnly = true;
            this.txtTeamScoresFor.Size = new System.Drawing.Size(84, 20);
            this.txtTeamScoresFor.TabIndex = 58;
            // 
            // txtTeamDrawn
            // 
            this.txtTeamDrawn.Location = new System.Drawing.Point(329, 243);
            this.txtTeamDrawn.Name = "txtTeamDrawn";
            this.txtTeamDrawn.ReadOnly = true;
            this.txtTeamDrawn.Size = new System.Drawing.Size(84, 20);
            this.txtTeamDrawn.TabIndex = 57;
            // 
            // txtTeamLost
            // 
            this.txtTeamLost.Location = new System.Drawing.Point(329, 198);
            this.txtTeamLost.Name = "txtTeamLost";
            this.txtTeamLost.ReadOnly = true;
            this.txtTeamLost.Size = new System.Drawing.Size(84, 20);
            this.txtTeamLost.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(264, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 38);
            this.label9.TabIndex = 55;
            this.label9.Text = "Scores For:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(262, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 54;
            this.label10.Text = "Drawn:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(264, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 53;
            this.label11.Text = "Lost:";
            // 
            // txtTeamPoints
            // 
            this.txtTeamPoints.Location = new System.Drawing.Point(329, 374);
            this.txtTeamPoints.Name = "txtTeamPoints";
            this.txtTeamPoints.ReadOnly = true;
            this.txtTeamPoints.Size = new System.Drawing.Size(84, 20);
            this.txtTeamPoints.TabIndex = 64;
            // 
            // txtTeamScoresAgainst
            // 
            this.txtTeamScoresAgainst.Location = new System.Drawing.Point(329, 329);
            this.txtTeamScoresAgainst.Name = "txtTeamScoresAgainst";
            this.txtTeamScoresAgainst.ReadOnly = true;
            this.txtTeamScoresAgainst.Size = new System.Drawing.Size(84, 20);
            this.txtTeamScoresAgainst.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gold;
            this.label12.Location = new System.Drawing.Point(264, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 21);
            this.label12.TabIndex = 62;
            this.label12.Text = "Points:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gold;
            this.label13.Location = new System.Drawing.Point(262, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 45);
            this.label13.TabIndex = 61;
            this.label13.Text = "Scores Against:";
            // 
            // frmViewTeamProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 403);
            this.Controls.Add(this.txtTeamPoints);
            this.Controls.Add(this.txtTeamScoresAgainst);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTeamWon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTeamScoresFor);
            this.Controls.Add(this.txtTeamDrawn);
            this.Controls.Add(this.txtTeamLost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTeamId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamEmail);
            this.Controls.Add(this.txtTeamVenue);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectTeamCombo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonBack);
            this.DoubleBuffered = true;
            this.Name = "frmViewTeamProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Team Profile";
            this.Load += new System.EventHandler(this.frmViewTeamProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.ComboBox selectTeamCombo;
        private System.Windows.Forms.TextBox txtTeamWon;
        private System.Windows.Forms.TextBox txtTeamScoresFor;
        private System.Windows.Forms.TextBox txtTeamDrawn;
        public System.Windows.Forms.TextBox txtTeamLost;
        private System.Windows.Forms.TextBox txtTeamPoints;
        private System.Windows.Forms.TextBox txtTeamScoresAgainst;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtTeamVenue;
        private System.Windows.Forms.TextBox txtTeamEmail;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeamId;
    }
}