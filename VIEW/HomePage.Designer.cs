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
            addBT = new Button();
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
            searchName = new TextBox();
            sortOrderCBB = new ComboBox();
            button5 = new Button();
            label1 = new Label();
            nameUserLB = new Label();
            bookingBT = new Button();
            label2 = new Label();
            searchBT = new Button();
            button2 = new Button();
            sortByCBB = new ComboBox();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(addBT);
            panel2.Location = new Point(1, 514);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 57);
            panel2.TabIndex = 1;
            // 
            // addBT
            // 
            addBT.Location = new Point(731, 13);
            addBT.Name = "addBT";
            addBT.Size = new Size(198, 30);
            addBT.TabIndex = 0;
            addBT.Text = "Add";
            addBT.UseVisualStyleBackColor = true;
            addBT.Click += addProduct;
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
            // searchName
            // 
            searchName.AccessibleName = "searchTB";
            searchName.Location = new Point(100, 97);
            searchName.Name = "searchName";
            searchName.Size = new Size(234, 27);
            searchName.TabIndex = 3;
            // 
            // sortOrderCBB
            // 
            sortOrderCBB.AccessibleName = "sortOrderCBB";
            sortOrderCBB.FormattingEnabled = true;
            sortOrderCBB.Items.AddRange(new object[] { "ASC", "DESC" });
            sortOrderCBB.Location = new Point(697, 91);
            sortOrderCBB.Name = "sortOrderCBB";
            sortOrderCBB.Size = new Size(128, 28);
            sortOrderCBB.TabIndex = 4;
            sortOrderCBB.Text = "ASC";
            // 
            // button5
            // 
            button5.Location = new Point(847, 90);
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
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 6;
            label1.Text = "PhoneHub xin chao ban !!!";
            // 
            // nameUserLB
            // 
            nameUserLB.AutoSize = true;
            nameUserLB.Location = new Point(253, 33);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 105);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "Tim kiem";
            // 
            // searchBT
            // 
            searchBT.Location = new Point(356, 93);
            searchBT.Name = "searchBT";
            searchBT.Size = new Size(116, 31);
            searchBT.TabIndex = 10;
            searchBT.Text = "Search";
            searchBT.UseVisualStyleBackColor = true;
            searchBT.Click += search;
            // 
            // button2
            // 
            button2.Location = new Point(487, 91);
            button2.Name = "button2";
            button2.Size = new Size(89, 33);
            button2.TabIndex = 11;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += reset;
            // 
            // sortByCBB
            // 
            sortByCBB.FormattingEnabled = true;
            sortByCBB.Items.AddRange(new object[] { "PRICE", "STOCK" });
            sortByCBB.Location = new Point(595, 91);
            sortByCBB.Name = "sortByCBB";
            sortByCBB.Size = new Size(87, 28);
            sortByCBB.TabIndex = 12;
            sortByCBB.Text = "PRICE";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 583);
            Controls.Add(sortByCBB);
            Controls.Add(button2);
            Controls.Add(searchBT);
            Controls.Add(label2);
            Controls.Add(bookingBT);
            Controls.Add(nameUserLB);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(sortOrderCBB);
            Controls.Add(searchName);
            Controls.Add(productTB);
            Controls.Add(panel2);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            panel2.ResumeLayout(false);
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
        private TextBox searchName;
        private ComboBox sortOrderCBB;
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
        private Label label2;
        private Button searchBT;
        private Button button2;
        private ComboBox sortByCBB;
        private Button addBT;
    }
}