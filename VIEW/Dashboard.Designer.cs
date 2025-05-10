namespace PhoneHub.VIEW
{
    partial class Dashboard
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
            bookingTB = new TextBox();
            productTB = new TextBox();
            customerTB = new TextBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox2 = new PictureBox();
            doanhthuTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(doanhthuTB);
            panel1.Controls.Add(bookingTB);
            panel1.Controls.Add(productTB);
            panel1.Controls.Add(customerTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 534);
            panel1.TabIndex = 0;
            // 
            // bookingTB
            // 
            bookingTB.Location = new Point(143, 276);
            bookingTB.Name = "bookingTB";
            bookingTB.Size = new Size(233, 27);
            bookingTB.TabIndex = 5;
            // 
            // productTB
            // 
            productTB.Location = new Point(143, 201);
            productTB.Name = "productTB";
            productTB.Size = new Size(233, 27);
            productTB.TabIndex = 3;
            // 
            // customerTB
            // 
            customerTB.Location = new Point(143, 127);
            customerTB.Name = "customerTB";
            customerTB.Size = new Size(233, 27);
            customerTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Khach Hang";
            label1.Click += showCustomer;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Group_33__1_;
            pictureBox2.Location = new Point(436, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(479, 560);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // doanhthuTB
            // 
            doanhthuTB.Location = new Point(143, 342);
            doanhthuTB.Name = "doanhthuTB";
            doanhthuTB.Size = new Size(233, 27);
            doanhthuTB.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(12, 342);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 8;
            label2.Text = "Doanh thu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(12, 277);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 9;
            label3.Text = "Don hang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 10;
            label4.Text = "San pham";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anhlogo;
            pictureBox1.Location = new Point(45, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(173, 43);
            label5.Name = "label5";
            label5.Size = new Size(150, 34);
            label5.TabIndex = 12;
            label5.Text = "PhoneHub";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 575);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox productTB;
        private TextBox customerTB;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox bookingTB;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox doanhthuTB;
        private Label label5;
        private PictureBox pictureBox1;
    }
}