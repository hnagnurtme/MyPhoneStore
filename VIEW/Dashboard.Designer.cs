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
            doanhthuTB = new TextBox();
            label4 = new Label();
            bookingTB = new TextBox();
            label3 = new Label();
            productTB = new TextBox();
            label2 = new Label();
            customerTB = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(doanhthuTB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(bookingTB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(productTB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(customerTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 72);
            panel1.TabIndex = 0;
            // 
            // doanhthuTB
            // 
            doanhthuTB.Location = new Point(680, 20);
            doanhthuTB.Name = "doanhthuTB";
            doanhthuTB.Size = new Size(100, 27);
            doanhthuTB.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(596, 23);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Doanh Thu";
            // 
            // bookingTB
            // 
            bookingTB.Location = new Point(490, 20);
            bookingTB.Name = "bookingTB";
            bookingTB.Size = new Size(100, 27);
            bookingTB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 23);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Don Hang";
            // 
            // productTB
            // 
            productTB.Location = new Point(295, 20);
            productTB.Name = "productTB";
            productTB.Size = new Size(106, 27);
            productTB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 23);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "San pham";
            label2.Click += productShow;
            // 
            // customerTB
            // 
            customerTB.Location = new Point(99, 20);
            customerTB.Name = "customerTB";
            customerTB.Size = new Size(109, 27);
            customerTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 23);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Khach Hang";
            label1.Click += showCustomer;
            // 
            // panel2
            // 
            panel2.Location = new Point(8, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 314);
            panel2.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox productTB;
        private Label label2;
        private TextBox customerTB;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox doanhthuTB;
        private Label label4;
        private TextBox bookingTB;
    }
}