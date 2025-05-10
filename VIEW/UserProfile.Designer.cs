namespace PhoneHub.VIEW
{
    partial class UserProfile
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            addressTB = new TextBox();
            label4 = new Label();
            sdtTB = new TextBox();
            label3 = new Label();
            emailTB = new TextBox();
            label2 = new Label();
            userNameTB = new TextBox();
            label1 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            change = new Button();
            panel2 = new Panel();
            oldPass = new Label();
            oldPassTB = new TextBox();
            label6 = new Label();
            newPassTB = new TextBox();
            label7 = new Label();
            newPassCFTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anhdt2;
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(addressTB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(sdtTB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(emailTB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userNameTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(405, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 195);
            panel1.TabIndex = 1;
            // 
            // addressTB
            // 
            addressTB.Location = new Point(114, 143);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(265, 27);
            addressTB.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkBlue;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(16, 143);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 6;
            label4.Text = "Dia Chi";
            // 
            // sdtTB
            // 
            sdtTB.Location = new Point(80, 99);
            sdtTB.Name = "sdtTB";
            sdtTB.Size = new Size(299, 27);
            sdtTB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkBlue;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(16, 100);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 4;
            label3.Text = "SDT";
            // 
            // emailTB
            // 
            emailTB.Location = new Point(80, 55);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(299, 27);
            emailTB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkBlue;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // userNameTB
            // 
            userNameTB.Location = new Point(136, 14);
            userNameTB.Name = "userNameTB";
            userNameTB.Size = new Size(243, 27);
            userNameTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 0;
            label1.Text = "Ho va ten";
            // 
            // change
            // 
            change.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            change.Location = new Point(659, 238);
            change.Name = "change";
            change.Size = new Size(143, 29);
            change.TabIndex = 2;
            change.Text = "Luu thay doi";
            change.UseVisualStyleBackColor = true;
            change.Click += updateProfile;
            // 
            // panel2
            // 
            panel2.Controls.Add(newPassCFTB);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(newPassTB);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(oldPassTB);
            panel2.Controls.Add(oldPass);
            panel2.Location = new Point(411, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 128);
            panel2.TabIndex = 3;
            // 
            // oldPass
            // 
            oldPass.AutoSize = true;
            oldPass.BackColor = Color.DarkBlue;
            oldPass.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oldPass.ForeColor = SystemColors.ButtonHighlight;
            oldPass.Location = new Point(10, 18);
            oldPass.Name = "oldPass";
            oldPass.Size = new Size(91, 23);
            oldPass.TabIndex = 3;
            oldPass.Text = "Mat khau";
            // 
            // oldPassTB
            // 
            oldPassTB.Location = new Point(108, 17);
            oldPassTB.Name = "oldPassTB";
            oldPassTB.Size = new Size(265, 27);
            oldPassTB.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkBlue;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(10, 52);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 9;
            label6.Text = "Mat khau moi";
            // 
            // newPassTB
            // 
            newPassTB.Location = new Point(142, 50);
            newPassTB.Name = "newPassTB";
            newPassTB.Size = new Size(231, 27);
            newPassTB.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkBlue;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(10, 84);
            label7.Name = "label7";
            label7.Size = new Size(162, 23);
            label7.TabIndex = 11;
            label7.Text = "Nhap lai mat khau";
            // 
            // newPassCFTB
            // 
            newPassCFTB.Location = new Point(178, 83);
            newPassCFTB.Name = "newPassCFTB";
            newPassCFTB.Size = new Size(195, 27);
            newPassCFTB.TabIndex = 12;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 438);
            Controls.Add(panel2);
            Controls.Add(change);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "UserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox addressTB;
        private Label label4;
        private TextBox sdtTB;
        private Label label3;
        private TextBox emailTB;
        private Label label2;
        private TextBox userNameTB;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button change;
        private Panel panel2;
        private TextBox newPassTB;
        private Label label6;
        private TextBox oldPassTB;
        private Label oldPass;
        private TextBox newPassCFTB;
        private Label label7;
    }
}