namespace PhoneHub.VIEW
{
    partial class SignUp
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
            groupBox1 = new GroupBox();
            usernameTB = new TextBox();
            registerBT = new Button();
            confirmPasswordTB = new TextBox();
            passwordTB = new TextBox();
            emailTB = new TextBox();
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(confirmPasswordTB);
            groupBox1.Controls.Add(passwordTB);
            groupBox1.Controls.Add(usernameTB);
            groupBox1.Controls.Add(emailTB);
            groupBox1.Controls.Add(registerBT);
            groupBox1.Location = new Point(92, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 434);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(21, 144);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(238, 27);
            usernameTB.TabIndex = 4;
            // 
            // registerBT
            // 
            registerBT.Location = new Point(102, 365);
            registerBT.Name = "registerBT";
            registerBT.Size = new Size(94, 36);
            registerBT.TabIndex = 3;
            registerBT.Text = "button1";
            registerBT.UseVisualStyleBackColor = true;
            registerBT.Click += register;
            // 
            // confirmPasswordTB
            // 
            confirmPasswordTB.Location = new Point(21, 280);
            confirmPasswordTB.Name = "confirmPasswordTB";
            confirmPasswordTB.Size = new Size(238, 27);
            confirmPasswordTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(21, 204);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(238, 27);
            passwordTB.TabIndex = 1;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(21, 83);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(238, 27);
            emailTB.TabIndex = 0;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 583);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox usernameTB;
        private Button registerBT;
        private TextBox confirmPasswordTB;
        private TextBox passwordTB;
        private TextBox emailTB;
    }
}