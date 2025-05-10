namespace PhoneHub.VIEW
{
    partial class ProductDetail
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
            nameLB = new Label();
            descriprionLB = new Label();
            button1 = new Button();
            priceLB = new Label();
            stockLB = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)productPic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productPic
            // 
            productPic.Image = Properties.Resources.anhdt1;
            productPic.Location = new Point(358, 0);
            productPic.Name = "productPic";
            productPic.Size = new Size(298, 463);
            productPic.SizeMode = PictureBoxSizeMode.StretchImage;
            productPic.TabIndex = 0;
            productPic.TabStop = false;
            // 
            // nameLB
            // 
            nameLB.AutoSize = true;
            nameLB.Location = new Point(15, 47);
            nameLB.MaximumSize = new Size(300, 0);
            nameLB.MinimumSize = new Size(300, 50);
            nameLB.Name = "nameLB";
            nameLB.Size = new Size(300, 50);
            nameLB.TabIndex = 1;
            nameLB.Text = "label1";
            // 
            // descriprionLB
            // 
            descriprionLB.AutoSize = true;
            descriprionLB.Location = new Point(15, 144);
            descriprionLB.MaximumSize = new Size(300, 100);
            descriprionLB.MinimumSize = new Size(300, 100);
            descriprionLB.Name = "descriprionLB";
            descriprionLB.Size = new Size(300, 100);
            descriprionLB.TabIndex = 2;
            descriprionLB.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(83, 362);
            button1.Name = "button1";
            button1.Size = new Size(178, 52);
            button1.TabIndex = 4;
            button1.Text = "Mua ngay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += order;
            // 
            // priceLB
            // 
            priceLB.AutoSize = true;
            priceLB.Location = new Point(17, 44);
            priceLB.MinimumSize = new Size(140, 30);
            priceLB.Name = "priceLB";
            priceLB.Size = new Size(140, 30);
            priceLB.TabIndex = 0;
            priceLB.Text = "label2";
            // 
            // stockLB
            // 
            stockLB.AutoSize = true;
            stockLB.Location = new Point(169, 44);
            stockLB.MinimumSize = new Size(140, 30);
            stockLB.Name = "stockLB";
            stockLB.Size = new Size(140, 30);
            stockLB.TabIndex = 1;
            stockLB.Text = "label3";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(stockLB);
            panel1.Controls.Add(priceLB);
            panel1.Location = new Point(15, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 87);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(169, 14);
            label1.MinimumSize = new Size(140, 30);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 1;
            label1.Text = "So luong";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(17, 14);
            label2.MinimumSize = new Size(140, 30);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 0;
            label2.Text = "Gia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(15, 109);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 5;
            label3.Text = "Mo ta";
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(10, 10);
            button2.Name = "button2";
            button2.Size = new Size(67, 27);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += backClicked;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 461);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(descriprionLB);
            Controls.Add(nameLB);
            Controls.Add(productPic);
            Name = "ProductDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductDetail";
            ((System.ComponentModel.ISupportInitialize)productPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productPic;
        private Label nameLB;
        private Label descriprionLB;
        private Button button1;
        private Label priceLB;
        private Label stockLB;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}