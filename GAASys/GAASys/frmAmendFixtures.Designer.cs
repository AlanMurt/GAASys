namespace GAASys
{
    partial class frmAmendFixtures
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
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.amendFixtureButton = new System.Windows.Forms.Button();
            this.fixtureComboBox = new System.Windows.Forms.ComboBox();
            this.txtFixtureTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFixtureVenue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFixtureDate = new System.Windows.Forms.TextBox();
            this.grpFixture = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFixture.SuspendLayout();
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
            this.Label1.Location = new System.Drawing.Point(52, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(359, 66);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Select a team and then a fixture to amend from the dropdown box\'s";
            // 
            // teamComboBox
            // 
            this.teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(272, 106);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(129, 21);
            this.teamComboBox.TabIndex = 13;
            this.teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // amendFixtureButton
            // 
            this.amendFixtureButton.BackColor = System.Drawing.Color.Gold;
            this.amendFixtureButton.Location = new System.Drawing.Point(135, 153);
            this.amendFixtureButton.Name = "amendFixtureButton";
            this.amendFixtureButton.Size = new System.Drawing.Size(70, 45);
            this.amendFixtureButton.TabIndex = 21;
            this.amendFixtureButton.Text = "Amend Fixture";
            this.amendFixtureButton.UseVisualStyleBackColor = false;
            this.amendFixtureButton.Click += new System.EventHandler(this.amendFixtureButton_Click);
            // 
            // fixtureComboBox
            // 
            this.fixtureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fixtureComboBox.FormattingEnabled = true;
            this.fixtureComboBox.Location = new System.Drawing.Point(272, 142);
            this.fixtureComboBox.Name = "fixtureComboBox";
            this.fixtureComboBox.Size = new System.Drawing.Size(129, 21);
            this.fixtureComboBox.TabIndex = 22;
            this.fixtureComboBox.Visible = false;
            this.fixtureComboBox.SelectedIndexChanged += new System.EventHandler(this.fixtureComboBox_SelectedIndexChanged);
            // 
            // txtFixtureTime
            // 
            this.txtFixtureTime.Location = new System.Drawing.Point(57, 108);
            this.txtFixtureTime.Name = "txtFixtureTime";
            this.txtFixtureTime.Size = new System.Drawing.Size(139, 20);
            this.txtFixtureTime.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(0, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 40);
            this.label7.TabIndex = 42;
            this.label7.Text = "Fixture Time:";
            // 
            // txtFixtureVenue
            // 
            this.txtFixtureVenue.Location = new System.Drawing.Point(57, 19);
            this.txtFixtureVenue.Name = "txtFixtureVenue";
            this.txtFixtureVenue.Size = new System.Drawing.Size(139, 20);
            this.txtFixtureVenue.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(1, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 45);
            this.label5.TabIndex = 38;
            this.label5.Text = "Fixture Date:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(0, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Venue:";
            // 
            // txtFixtureDate
            // 
            this.txtFixtureDate.Location = new System.Drawing.Point(57, 66);
            this.txtFixtureDate.Name = "txtFixtureDate";
            this.txtFixtureDate.Size = new System.Drawing.Size(139, 20);
            this.txtFixtureDate.TabIndex = 43;
            // 
            // grpFixture
            // 
            this.grpFixture.Controls.Add(this.amendFixtureButton);
            this.grpFixture.Controls.Add(this.txtFixtureDate);
            this.grpFixture.Controls.Add(this.txtFixtureTime);
            this.grpFixture.Controls.Add(this.label7);
            this.grpFixture.Controls.Add(this.txtFixtureVenue);
            this.grpFixture.Controls.Add(this.label5);
            this.grpFixture.Controls.Add(this.label4);
            this.grpFixture.Location = new System.Drawing.Point(215, 179);
            this.grpFixture.Name = "grpFixture";
            this.grpFixture.Size = new System.Drawing.Size(217, 213);
            this.grpFixture.TabIndex = 44;
            this.grpFixture.TabStop = false;
            this.grpFixture.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(215, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Team:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(211, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Fixture:";
            this.label2.Visible = false;
            // 
            // frmAmendFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::GAASys.Properties.Resources.backLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 403);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpFixture);
            this.Controls.Add(this.fixtureComboBox);
            this.Controls.Add(this.teamComboBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonBack);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "frmAmendFixtures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amend Fixtures";
            this.Load += new System.EventHandler(this.frmAmendFixtures_Load);
            this.grpFixture.ResumeLayout(false);
            this.grpFixture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.Button amendFixtureButton;
        private System.Windows.Forms.ComboBox fixtureComboBox;
        private System.Windows.Forms.TextBox txtFixtureTime;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFixtureVenue;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFixtureDate;
        private System.Windows.Forms.GroupBox grpFixture;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label2;
    }
}