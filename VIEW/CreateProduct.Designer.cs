namespace PhoneHub.VIEW
{
    partial class CreateProduct
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
            imageTB = new TextBox();
            label7 = new Label();
            confirmBT = new Button();
            modelTB = new TextBox();
            brandTB = new TextBox();
            label5 = new Label();
            label6 = new Label();
            stockTB = new TextBox();
            priceTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            descriptionTB = new TextBox();
            label2 = new Label();
            nameProductTB = new TextBox();
            label1 = new Label();
            deleteBT = new Button();
            ((System.ComponentModel.ISupportInitialize)productPic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productPic
            // 
            productPic.Image = Properties.Resources.anhdt1;
            productPic.Location = new Point(392, 12);
            productPic.Name = "productPic";
            productPic.Size = new Size(298, 463);
            productPic.SizeMode = PictureBoxSizeMode.StretchImage;
            productPic.TabIndex = 1;
            productPic.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(deleteBT);
            panel1.Controls.Add(imageTB);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(confirmBT);
            panel1.Controls.Add(modelTB);
            panel1.Controls.Add(brandTB);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(stockTB);
            panel1.Controls.Add(priceTB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(descriptionTB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameProductTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 429);
            panel1.TabIndex = 2;
            // 
            // imageTB
            // 
            imageTB.Location = new Point(135, 216);
            imageTB.Name = "imageTB";
            imageTB.Size = new Size(205, 27);
            imageTB.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 223);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 13;
            label7.Text = "Hinh anh";
            // 
            // confirmBT
            // 
            confirmBT.BackColor = Color.DarkBlue;
            confirmBT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmBT.ForeColor = SystemColors.ControlLightLight;
            confirmBT.Location = new Point(195, 372);
            confirmBT.Name = "confirmBT";
            confirmBT.Size = new Size(145, 43);
            confirmBT.TabIndex = 12;
            confirmBT.Text = "Luu thay doi";
            confirmBT.UseVisualStyleBackColor = false;
            confirmBT.Click += confirm;
            // 
            // modelTB
            // 
            modelTB.Location = new Point(135, 118);
            modelTB.Name = "modelTB";
            modelTB.Size = new Size(205, 27);
            modelTB.TabIndex = 11;
            // 
            // brandTB
            // 
            brandTB.Location = new Point(135, 164);
            brandTB.Name = "brandTB";
            brandTB.Size = new Size(205, 27);
            brandTB.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 171);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 9;
            label5.Text = "Thuong Hieu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 118);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 8;
            label6.Text = "Mau";
            // 
            // stockTB
            // 
            stockTB.Location = new Point(135, 273);
            stockTB.Name = "stockTB";
            stockTB.Size = new Size(205, 27);
            stockTB.TabIndex = 7;
            // 
            // priceTB
            // 
            priceTB.Location = new Point(135, 319);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(205, 27);
            priceTB.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 326);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Gia tien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 273);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "So luong";
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(135, 67);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(205, 27);
            descriptionTB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Mo ta";
            // 
            // nameProductTB
            // 
            nameProductTB.Location = new Point(135, 19);
            nameProductTB.Name = "nameProductTB";
            nameProductTB.Size = new Size(205, 27);
            nameProductTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Ten san pham";
            // 
            // deleteBT
            // 
            deleteBT.BackColor = Color.Crimson;
            deleteBT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBT.ForeColor = SystemColors.ControlLightLight;
            deleteBT.Location = new Point(13, 372);
            deleteBT.Name = "deleteBT";
            deleteBT.Size = new Size(145, 43);
            deleteBT.TabIndex = 15;
            deleteBT.Text = "Xoa san pham";
            deleteBT.UseVisualStyleBackColor = false;
            deleteBT.Click += delete;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 502);
            Controls.Add(panel1);
            Controls.Add(productPic);
            Name = "CreateProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)productPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox productPic;
        private Panel panel1;
        private TextBox modelTB;
        private TextBox brandTB;
        private Label label5;
        private Label label6;
        private TextBox stockTB;
        private TextBox priceTB;
        private Label label4;
        private Label label3;
        private TextBox descriptionTB;
        private Label label2;
        private TextBox nameProductTB;
        private Label label1;
        private TextBox imageTB;
        private Label label7;
        private Button confirmBT;
        private Button deleteBT;
    }
}