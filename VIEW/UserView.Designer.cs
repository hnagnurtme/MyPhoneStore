namespace PhoneHub.VIEW
{
    partial class UserView
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
            panel1 = new Panel();
            addressTB = new TextBox();
            label4 = new Label();
            sdtTB = new TextBox();
            label3 = new Label();
            emailTB = new TextBox();
            label2 = new Label();
            userNameTB = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            tongsotienLb = new Button();
            tongsotien = new Button();
            sodonhang = new Button();
            sodonhangLB = new Button();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.Location = new Point(382, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 195);
            panel1.TabIndex = 2;
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
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
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
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
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
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
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
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 0;
            label1.Text = "Ho va ten";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anhdt2;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tongsotienLb);
            panel2.Controls.Add(tongsotien);
            panel2.Controls.Add(sodonhang);
            panel2.Controls.Add(sodonhangLB);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(382, 213);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 108);
            panel2.TabIndex = 4;
            // 
            // tongsotienLb
            // 
            tongsotienLb.Location = new Point(235, 3);
            tongsotienLb.Name = "tongsotienLb";
            tongsotienLb.Size = new Size(144, 47);
            tongsotienLb.TabIndex = 4;
            tongsotienLb.Text = "Tổng số tiền";
            tongsotienLb.UseVisualStyleBackColor = true;
            // 
            // tongsotien
            // 
            tongsotien.Location = new Point(235, 56);
            tongsotien.Name = "tongsotien";
            tongsotien.Size = new Size(144, 47);
            tongsotien.TabIndex = 3;
            tongsotien.UseVisualStyleBackColor = true;
            // 
            // sodonhang
            // 
            sodonhang.Location = new Point(3, 56);
            sodonhang.Name = "sodonhang";
            sodonhang.Size = new Size(144, 47);
            sodonhang.TabIndex = 2;
            sodonhang.UseVisualStyleBackColor = true;
            sodonhang.Click += sodonhang_Click;
            // 
            // sodonhangLB
            // 
            sodonhangLB.Location = new Point(3, 3);
            sodonhangLB.Name = "sodonhangLB";
            sodonhangLB.Size = new Size(144, 47);
            sodonhangLB.TabIndex = 1;
            sodonhangLB.Text = "Số đơn hàng";
            sodonhangLB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 13);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(43, 11);
            button2.Name = "button2";
            button2.Size = new Size(137, 43);
            button2.TabIndex = 5;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += deleteUser;
            // 
            // button3
            // 
            button3.Location = new Point(212, 11);
            button3.Name = "button3";
            button3.Size = new Size(137, 43);
            button3.TabIndex = 6;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += close;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(386, 326);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 59);
            panel3.TabIndex = 7;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 393);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "UserView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox addressTB;
        private Label label4;
        private TextBox sdtTB;
        private Label label3;
        private TextBox emailTB;
        private Label label2;
        private TextBox userNameTB;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button tongsotienLb;
        private Button tongsotien;
        private Button sodonhang;
        private Button sodonhangLB;
        private Label label5;
        private Button button2;
        private Button button3;
        private Panel panel3;
    }
}