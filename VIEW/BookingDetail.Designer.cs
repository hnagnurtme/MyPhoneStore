namespace PhoneHub.VIEW
{
    partial class BookingDetail
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
            productPic = new PictureBox();
            panel1 = new Panel();
            addressTB = new TextBox();
            nameTB = new TextBox();
            noteTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            deliveryTB = new DateTimePicker();
            label4 = new Label();
            panel3 = new Panel();
            countCBB = new ComboBox();
            totalTB = new TextBox();
            label7 = new Label();
            label6 = new Label();
            nameProductTB = new TextBox();
            label5 = new Label();
            confirmBT = new Button();
            ((System.ComponentModel.ISupportInitialize)productPic).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // productPic
            // 
            productPic.Image = Properties.Resources.anhdt1;
            productPic.Location = new Point(12, 12);
            productPic.Name = "productPic";
            productPic.Size = new Size(298, 463);
            productPic.SizeMode = PictureBoxSizeMode.StretchImage;
            productPic.TabIndex = 1;
            productPic.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(addressTB);
            panel1.Controls.Add(nameTB);
            panel1.Controls.Add(noteTB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(320, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 154);
            panel1.TabIndex = 2;
            // 
            // addressTB
            // 
            addressTB.Location = new Point(143, 51);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(314, 27);
            addressTB.TabIndex = 5;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(104, 11);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(353, 27);
            nameTB.TabIndex = 4;
            // 
            // noteTB
            // 
            noteTB.Location = new Point(113, 91);
            noteTB.Name = "noteTB";
            noteTB.Size = new Size(344, 27);
            noteTB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(9, 98);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Ghi chu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(9, 54);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Dia chi nhan hang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ho va ten";
            // 
            // panel2
            // 
            panel2.Controls.Add(deliveryTB);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(322, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 72);
            panel2.TabIndex = 3;
            // 
            // deliveryTB
            // 
            deliveryTB.Location = new Point(181, 18);
            deliveryTB.Name = "deliveryTB";
            deliveryTB.Size = new Size(274, 27);
            deliveryTB.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 23);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 0;
            label4.Text = "Chon ngay giao hang";
            // 
            // panel3
            // 
            panel3.Controls.Add(countCBB);
            panel3.Controls.Add(totalTB);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(nameProductTB);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(320, 284);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 85);
            panel3.TabIndex = 4;
            // 
            // countCBB
            // 
            countCBB.FormattingEnabled = true;
            countCBB.Items.AddRange(new object[] { "1" });
            countCBB.Location = new Point(104, 43);
            countCBB.Name = "countCBB";
            countCBB.Size = new Size(110, 28);
            countCBB.TabIndex = 11;
            countCBB.SelectedIndexChanged += changeCount;
            // 
            // totalTB
            // 
            totalTB.Location = new Point(300, 43);
            totalTB.Name = "totalTB";
            totalTB.Size = new Size(157, 27);
            totalTB.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(238, 50);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 8;
            label7.Text = "Tong";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(11, 50);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 7;
            label6.Text = "So luong";
            // 
            // nameProductTB
            // 
            nameProductTB.Location = new Point(104, 10);
            nameProductTB.Name = "nameProductTB";
            nameProductTB.Size = new Size(353, 27);
            nameProductTB.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(11, 13);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 1;
            label5.Text = "San pham";
            // 
            // confirmBT
            // 
            confirmBT.BackColor = Color.DarkBlue;
            confirmBT.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBT.ForeColor = SystemColors.ButtonHighlight;
            confirmBT.Location = new Point(424, 411);
            confirmBT.Name = "confirmBT";
            confirmBT.Size = new Size(239, 54);
            confirmBT.TabIndex = 5;
            confirmBT.Text = "Xac nhan";
            confirmBT.UseVisualStyleBackColor = false;
            confirmBT.Click += confirmBooking;
            // 
            // BookingDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(confirmBT);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(productPic);
            Name = "BookingDetail";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)productPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox productPic;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox noteTB;
        private Label label3;
        private TextBox addressTB;
        private TextBox nameTB;
        private Panel panel2;
        private DateTimePicker deliveryTB;
        private Label label4;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private TextBox nameProductTB;
        private Label label5;
        private TextBox totalTB;
        private Button confirmBT;
        private ComboBox countCBB;
    }
}