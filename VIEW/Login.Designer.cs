using PhoneHub.VIEW;

namespace PhoneHub
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            passwordTB = new TextBox();
            emailTB = new TextBox();
            registerBT = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_33__1_;
            pictureBox1.Location = new Point(467, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 560);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(passwordTB);
            groupBox1.Controls.Add(emailTB);
            groupBox1.Controls.Add(registerBT);
            groupBox1.Location = new Point(71, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(317, 425);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 225);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 11;
            label7.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 131);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(81, 66);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 8;
            label4.Text = "Register Here !";
            label4.Click += changeToRegister;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 66);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 7;
            label3.Text = "You can";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(19, 48);
            label2.Name = "label2";
            label2.Size = new Size(223, 17);
            label2.TabIndex = 6;
            label2.Text = "If you don't have an account register";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 5;
            label1.Text = "Sign in";
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(22, 258);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(275, 27);
            passwordTB.TabIndex = 1;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(22, 164);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(275, 27);
            emailTB.TabIndex = 0;
            // 
            // registerBT
            // 
            registerBT.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            registerBT.ForeColor = Color.DarkBlue;
            registerBT.Location = new Point(84, 323);
            registerBT.Name = "registerBT";
            registerBT.Size = new Size(133, 36);
            registerBT.TabIndex = 3;
            registerBT.Text = "Login";
            registerBT.UseVisualStyleBackColor = true;
            registerBT.Click += login;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 583);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox passwordTB;
        private TextBox emailTB;
        private Button registerBT;
    }
}
