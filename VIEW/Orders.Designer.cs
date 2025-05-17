namespace PhoneHub.VIEW
{
    partial class Orders
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
            bookingView = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deliveryDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shippingAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingBindingSource = new BindingSource(components);
            panel1 = new Panel();
            toatlRevue = new Label();
            tong = new Label();
            totalOrders = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookingView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bookingView
            // 
            bookingView.AutoGenerateColumns = false;
            bookingView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingView.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, bookingDateDataGridViewTextBoxColumn, deliveryDateDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, shippingAddressDataGridViewTextBoxColumn, notesDataGridViewTextBoxColumn });
            bookingView.DataSource = bookingBindingSource;
            bookingView.Location = new Point(12, 68);
            bookingView.Name = "bookingView";
            bookingView.RowHeadersWidth = 51;
            bookingView.Size = new Size(1083, 370);
            bookingView.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            deliveryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // shippingAddressDataGridViewTextBoxColumn
            // 
            shippingAddressDataGridViewTextBoxColumn.DataPropertyName = "ShippingAddress";
            shippingAddressDataGridViewTextBoxColumn.HeaderText = "ShippingAddress";
            shippingAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            shippingAddressDataGridViewTextBoxColumn.Name = "shippingAddressDataGridViewTextBoxColumn";
            shippingAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingBindingSource
            // 
            bookingBindingSource.DataSource = typeof(Models.Booking);
            // 
            // panel1
            // 
            panel1.Controls.Add(toatlRevue);
            panel1.Controls.Add(tong);
            panel1.Controls.Add(totalOrders);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 56);
            panel1.TabIndex = 2;
            // 
            // toatlRevue
            // 
            toatlRevue.AutoSize = true;
            toatlRevue.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toatlRevue.ForeColor = Color.LimeGreen;
            toatlRevue.Location = new Point(438, 10);
            toatlRevue.Name = "toatlRevue";
            toatlRevue.Size = new Size(30, 35);
            toatlRevue.TabIndex = 3;
            toatlRevue.Text = "0";
            toatlRevue.Click += label2_Click;
            // 
            // tong
            // 
            tong.AutoSize = true;
            tong.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tong.ForeColor = Color.DarkBlue;
            tong.Location = new Point(266, 20);
            tong.Name = "tong";
            tong.Size = new Size(96, 23);
            tong.TabIndex = 2;
            tong.Text = "Doanh thu";
            // 
            // totalOrders
            // 
            totalOrders.AutoSize = true;
            totalOrders.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalOrders.ForeColor = Color.LimeGreen;
            totalOrders.Location = new Point(203, 10);
            totalOrders.Name = "totalOrders";
            totalOrders.Size = new Size(30, 35);
            totalOrders.TabIndex = 1;
            totalOrders.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 0;
            label1.Text = "Tong So Don Hang";
            label1.Click += label1_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 450);
            Controls.Add(panel1);
            Controls.Add(bookingView);
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)bookingView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView bookingView;
        private BindingSource bookingBindingSource;
        private Panel panel1;
        private Label totalOrders;
        private Label label1;
        private Label toatlRevue;
        private Label tong;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shippingAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}