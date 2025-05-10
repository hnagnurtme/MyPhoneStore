namespace PhoneHub.VIEW
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            panel2 = new Panel();
            productTB = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            IsAvailable = new DataGridViewCheckBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            entityBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button5 = new Button();
            label1 = new Label();
            nameUserLB = new Label();
            bookingBT = new Button();
            ((System.ComponentModel.ISupportInitialize)productTB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "profileBT";
            button1.Location = new Point(847, 12);
            button1.Name = "button1";
            button1.Size = new Size(83, 60);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += showProfile;
            // 
            // panel2
            // 
            panel2.AccessibleName = "Footer";
            panel2.Location = new Point(0, 527);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 57);
            panel2.TabIndex = 1;
            // 
            // productTB
            // 
            productTB.AccessibleName = "productTable";
            productTB.AllowUserToAddRows = false;
            productTB.AllowUserToDeleteRows = false;
            productTB.AllowUserToOrderColumns = true;
            productTB.AutoGenerateColumns = false;
            productTB.BackgroundColor = Color.LightCyan;
            productTB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productTB.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, Model, IsAvailable, Brand, Price, StockQuantity });
            productTB.DataSource = productBindingSource;
            productTB.Location = new Point(24, 143);
            productTB.Name = "productTB";
            productTB.ReadOnly = true;
            productTB.RowHeadersWidth = 51;
            productTB.Size = new Size(906, 365);
            productTB.TabIndex = 2;
            productTB.Click += showDetails;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Model
            // 
            Model.DataPropertyName = "Model";
            Model.HeaderText = "Model";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            Model.ReadOnly = true;
            Model.Width = 125;
            // 
            // IsAvailable
            // 
            IsAvailable.DataPropertyName = "IsAvailable";
            IsAvailable.HeaderText = "IsAvailable";
            IsAvailable.MinimumWidth = 6;
            IsAvailable.Name = "IsAvailable";
            IsAvailable.ReadOnly = true;
            IsAvailable.Width = 125;
            // 
            // Brand
            // 
            Brand.DataPropertyName = "Brand";
            Brand.HeaderText = "Brand";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            Brand.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // StockQuantity
            // 
            StockQuantity.DataPropertyName = "StockQuantity";
            StockQuantity.HeaderText = "StockQuantity";
            StockQuantity.MinimumWidth = 6;
            StockQuantity.Name = "StockQuantity";
            StockQuantity.ReadOnly = true;
            StockQuantity.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // entityBindingSource
            // 
            entityBindingSource.DataSource = typeof(Models.Entity);
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "searchTB";
            textBox1.Location = new Point(429, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "sortOrderCBB";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(697, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(128, 28);
            comboBox1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(847, 97);
            button5.Name = "button5";
            button5.Size = new Size(83, 28);
            button5.TabIndex = 5;
            button5.Text = "Sort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += sortBT;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(30, 103);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 6;
            label1.Text = "PhoneHub xin chao ban !!!";
            // 
            // nameUserLB
            // 
            nameUserLB.AutoSize = true;
            nameUserLB.Location = new Point(252, 103);
            nameUserLB.Name = "nameUserLB";
            nameUserLB.Size = new Size(50, 20);
            nameUserLB.TabIndex = 7;
            nameUserLB.Text = "label2";
            // 
            // bookingBT
            // 
            bookingBT.AccessibleName = "profileBT";
            bookingBT.Location = new Point(697, 12);
            bookingBT.Name = "bookingBT";
            bookingBT.Size = new Size(128, 60);
            bookingBT.TabIndex = 8;
            bookingBT.Text = "button2";
            bookingBT.UseVisualStyleBackColor = true;
            bookingBT.Click += allBooking;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 583);
            Controls.Add(bookingBT);
            Controls.Add(nameUserLB);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(productTB);
            Controls.Add(panel2);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)productTB).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel panel2;
        private DataGridView productTB;
        private BindingSource productBindingSource;
        private BindingSource entityBindingSource;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button5;
        private Label label1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewCheckBoxColumn IsAvailable;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn StockQuantity;
        private Label nameUserLB;
        private Button bookingBT;
    }
}