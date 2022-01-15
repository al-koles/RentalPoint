namespace RentalPoint1
{
    partial class OrderRents
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
            System.Windows.Forms.Label order_idLabel;
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label cancelDateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.order_idTextBox = new System.Windows.Forms.TextBox();
            this.client_idTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.RentTableAdapter();
            this.rentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderDate_textBox = new System.Windows.Forms.TextBox();
            this.CancelDate_textBox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ClientTableAdapter();
            order_idLabel = new System.Windows.Forms.Label();
            client_idLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            cancelDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // order_idLabel
            // 
            order_idLabel.AutoSize = true;
            order_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            order_idLabel.Location = new System.Drawing.Point(118, 54);
            order_idLabel.Name = "order_idLabel";
            order_idLabel.Size = new System.Drawing.Size(71, 20);
            order_idLabel.TabIndex = 1;
            order_idLabel.Text = "order id:";
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_idLabel.Location = new System.Drawing.Point(118, 87);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(57, 20);
            client_idLabel.TabIndex = 3;
            client_idLabel.Text = "Client:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            orderDateLabel.Location = new System.Drawing.Point(118, 122);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(98, 20);
            orderDateLabel.TabIndex = 5;
            orderDateLabel.Text = "Order Date:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            noteLabel.Location = new System.Drawing.Point(118, 188);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(49, 20);
            noteLabel.TabIndex = 7;
            noteLabel.Text = "Note:";
            // 
            // cancelDateLabel
            // 
            cancelDateLabel.AutoSize = true;
            cancelDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cancelDateLabel.Location = new System.Drawing.Point(118, 156);
            cancelDateLabel.Name = "cancelDateLabel";
            cancelDateLabel.Size = new System.Drawing.Size(107, 20);
            cancelDateLabel.TabIndex = 9;
            cancelDateLabel.Text = "Cancel Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(256, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(22, 20);
            label1.TabIndex = 14;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(361, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 20);
            label2.TabIndex = 16;
            label2.Text = "Last Name";
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.SetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // order_idTextBox
            // 
            this.order_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_idTextBox.Location = new System.Drawing.Point(260, 51);
            this.order_idTextBox.Name = "order_idTextBox";
            this.order_idTextBox.ReadOnly = true;
            this.order_idTextBox.Size = new System.Drawing.Size(433, 26);
            this.order_idTextBox.TabIndex = 2;
            this.order_idTextBox.TabStop = false;
            // 
            // client_idTextBox
            // 
            this.client_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_idTextBox.Location = new System.Drawing.Point(293, 83);
            this.client_idTextBox.Name = "client_idTextBox";
            this.client_idTextBox.ReadOnly = true;
            this.client_idTextBox.Size = new System.Drawing.Size(46, 26);
            this.client_idTextBox.TabIndex = 4;
            this.client_idTextBox.TabStop = false;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Note", true));
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteTextBox.Location = new System.Drawing.Point(260, 185);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(433, 61);
            this.noteTextBox.TabIndex = 8;
            this.noteTextBox.TabStop = false;
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
            // rentBindingSource1
            // 
            this.rentBindingSource1.DataMember = "FK__Rent__order_id__5CA1C101";
            this.rentBindingSource1.DataSource = this.orderBindingSource;
            // 
            // rentDataGridView
            // 
            this.rentDataGridView.AllowUserToAddRows = false;
            this.rentDataGridView.AllowUserToDeleteRows = false;
            this.rentDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentDataGridView.Location = new System.Drawing.Point(54, 275);
            this.rentDataGridView.Name = "rentDataGridView";
            this.rentDataGridView.ReadOnly = true;
            this.rentDataGridView.RowHeadersWidth = 51;
            this.rentDataGridView.RowTemplate.Height = 24;
            this.rentDataGridView.Size = new System.Drawing.Size(718, 213);
            this.rentDataGridView.TabIndex = 11;
            // 
            // OrderDate_textBox
            // 
            this.OrderDate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDate_textBox.Location = new System.Drawing.Point(260, 119);
            this.OrderDate_textBox.Name = "OrderDate_textBox";
            this.OrderDate_textBox.ReadOnly = true;
            this.OrderDate_textBox.Size = new System.Drawing.Size(433, 26);
            this.OrderDate_textBox.TabIndex = 12;
            this.OrderDate_textBox.TabStop = false;
            // 
            // CancelDate_textBox
            // 
            this.CancelDate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelDate_textBox.Location = new System.Drawing.Point(260, 153);
            this.CancelDate_textBox.Name = "CancelDate_textBox";
            this.CancelDate_textBox.ReadOnly = true;
            this.CancelDate_textBox.Size = new System.Drawing.Size(433, 26);
            this.CancelDate_textBox.TabIndex = 13;
            this.CancelDate_textBox.TabStop = false;
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName_textBox.Location = new System.Drawing.Point(467, 83);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.ReadOnly = true;
            this.LastName_textBox.Size = new System.Drawing.Size(226, 26);
            this.LastName_textBox.TabIndex = 15;
            this.LastName_textBox.TabStop = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // OrderRents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 557);
            this.Controls.Add(label2);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.CancelDate_textBox);
            this.Controls.Add(this.OrderDate_textBox);
            this.Controls.Add(this.rentDataGridView);
            this.Controls.Add(order_idLabel);
            this.Controls.Add(this.order_idTextBox);
            this.Controls.Add(client_idLabel);
            this.Controls.Add(this.client_idTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(cancelDateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderRents";
            this.Text = "Order Rents";
            this.Load += new System.EventHandler(this.OrderRents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private RentalPointDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox order_idTextBox;
        private System.Windows.Forms.TextBox client_idTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private RentalPointDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.BindingSource rentBindingSource1;
        private System.Windows.Forms.DataGridView rentDataGridView;
        private System.Windows.Forms.TextBox OrderDate_textBox;
        private System.Windows.Forms.TextBox CancelDate_textBox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentalPointDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}