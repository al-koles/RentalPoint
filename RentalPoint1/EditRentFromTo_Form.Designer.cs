namespace RentalPoint1
{
    partial class EditRentFromTo_Form
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
            this.components = new System.ComponentModel.Container();
            this.ToDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDate_label = new System.Windows.Forms.Label();
            this.FromDate_label = new System.Windows.Forms.Label();
            this.GoodID_label = new System.Windows.Forms.Label();
            this.RentID_textBox = new System.Windows.Forms.TextBox();
            this.RentID_label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.GoodID_textBox = new System.Windows.Forms.TextBox();
            this.OrderID_textBox = new System.Windows.Forms.TextBox();
            this.orderID_label = new System.Windows.Forms.Label();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.RentTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDate_dateTimePicker
            // 
            this.ToDate_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate_dateTimePicker.Location = new System.Drawing.Point(228, 236);
            this.ToDate_dateTimePicker.MaxDate = new System.DateTime(9990, 12, 27, 0, 0, 0, 0);
            this.ToDate_dateTimePicker.Name = "ToDate_dateTimePicker";
            this.ToDate_dateTimePicker.Size = new System.Drawing.Size(267, 26);
            this.ToDate_dateTimePicker.TabIndex = 1;
            this.ToDate_dateTimePicker.Value = new System.DateTime(2020, 12, 27, 0, 0, 0, 0);
            // 
            // FromDate_dateTimePicker
            // 
            this.FromDate_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate_dateTimePicker.Location = new System.Drawing.Point(228, 205);
            this.FromDate_dateTimePicker.MaxDate = new System.DateTime(9990, 12, 27, 0, 0, 0, 0);
            this.FromDate_dateTimePicker.Name = "FromDate_dateTimePicker";
            this.FromDate_dateTimePicker.Size = new System.Drawing.Size(267, 26);
            this.FromDate_dateTimePicker.TabIndex = 1;
            this.FromDate_dateTimePicker.Value = new System.DateTime(2020, 12, 27, 0, 0, 0, 0);
            // 
            // ToDate_label
            // 
            this.ToDate_label.AutoSize = true;
            this.ToDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDate_label.Location = new System.Drawing.Point(57, 236);
            this.ToDate_label.Name = "ToDate_label";
            this.ToDate_label.Size = new System.Drawing.Size(81, 20);
            this.ToDate_label.TabIndex = 127;
            this.ToDate_label.Text = "To (Date)";
            // 
            // FromDate_label
            // 
            this.FromDate_label.AutoSize = true;
            this.FromDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromDate_label.Location = new System.Drawing.Point(57, 206);
            this.FromDate_label.Name = "FromDate_label";
            this.FromDate_label.Size = new System.Drawing.Size(101, 20);
            this.FromDate_label.TabIndex = 126;
            this.FromDate_label.Text = "From (Date)";
            // 
            // GoodID_label
            // 
            this.GoodID_label.AutoSize = true;
            this.GoodID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodID_label.Location = new System.Drawing.Point(57, 168);
            this.GoodID_label.Name = "GoodID_label";
            this.GoodID_label.Size = new System.Drawing.Size(67, 20);
            this.GoodID_label.TabIndex = 124;
            this.GoodID_label.Text = "good_id";
            // 
            // RentID_textBox
            // 
            this.RentID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RentID_textBox.Location = new System.Drawing.Point(228, 101);
            this.RentID_textBox.Name = "RentID_textBox";
            this.RentID_textBox.ReadOnly = true;
            this.RentID_textBox.Size = new System.Drawing.Size(267, 26);
            this.RentID_textBox.TabIndex = 117;
            this.RentID_textBox.TabStop = false;
            // 
            // RentID_label
            // 
            this.RentID_label.AutoSize = true;
            this.RentID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RentID_label.Location = new System.Drawing.Point(57, 104);
            this.RentID_label.Name = "RentID_label";
            this.RentID_label.Size = new System.Drawing.Size(60, 20);
            this.RentID_label.TabIndex = 123;
            this.RentID_label.Text = "rent_id";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(50, 27);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 120;
            this.Cancel_button.TabStop = false;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Accept_button
            // 
            this.Accept_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Accept_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accept_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accept_button.Location = new System.Drawing.Point(400, 27);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 121;
            this.Accept_button.TabStop = false;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(244, 31);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(58, 26);
            this.Header_label.TabIndex = 122;
            this.Header_label.Text = "Rent";
            // 
            // GoodID_textBox
            // 
            this.GoodID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodID_textBox.Location = new System.Drawing.Point(228, 165);
            this.GoodID_textBox.Name = "GoodID_textBox";
            this.GoodID_textBox.ReadOnly = true;
            this.GoodID_textBox.Size = new System.Drawing.Size(267, 26);
            this.GoodID_textBox.TabIndex = 130;
            this.GoodID_textBox.TabStop = false;
            // 
            // OrderID_textBox
            // 
            this.OrderID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderID_textBox.Location = new System.Drawing.Point(228, 133);
            this.OrderID_textBox.Name = "OrderID_textBox";
            this.OrderID_textBox.ReadOnly = true;
            this.OrderID_textBox.Size = new System.Drawing.Size(267, 26);
            this.OrderID_textBox.TabIndex = 132;
            this.OrderID_textBox.TabStop = false;
            // 
            // orderID_label
            // 
            this.orderID_label.AutoSize = true;
            this.orderID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderID_label.Location = new System.Drawing.Point(57, 136);
            this.orderID_label.Name = "orderID_label";
            this.orderID_label.Size = new System.Drawing.Size(70, 20);
            this.orderID_label.TabIndex = 131;
            this.orderID_label.Text = "order_id";
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "Rent";
            this.rentBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = null;
            this.tableAdapterManager.DiscountTypeTableAdapter = null;
            this.tableAdapterManager.GoodTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.ModelTypeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RentTableAdapter = this.rentTableAdapter;
            this.tableAdapterManager.SetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EditRentFromTo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 334);
            this.ControlBox = false;
            this.Controls.Add(this.OrderID_textBox);
            this.Controls.Add(this.orderID_label);
            this.Controls.Add(this.GoodID_textBox);
            this.Controls.Add(this.ToDate_dateTimePicker);
            this.Controls.Add(this.FromDate_dateTimePicker);
            this.Controls.Add(this.ToDate_label);
            this.Controls.Add(this.FromDate_label);
            this.Controls.Add(this.GoodID_label);
            this.Controls.Add(this.RentID_textBox);
            this.Controls.Add(this.RentID_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRentFromTo_Form";
            this.Text = "Edit Rent";
            this.Load += new System.EventHandler(this.EditRent_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ToDate_dateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDate_dateTimePicker;
        private System.Windows.Forms.Label ToDate_label;
        private System.Windows.Forms.Label FromDate_label;
        private System.Windows.Forms.Label GoodID_label;
        private System.Windows.Forms.TextBox RentID_textBox;
        private System.Windows.Forms.Label RentID_label;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.TextBox GoodID_textBox;
        private System.Windows.Forms.TextBox OrderID_textBox;
        private System.Windows.Forms.Label orderID_label;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private RentalPointDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}