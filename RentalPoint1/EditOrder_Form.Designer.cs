namespace RentalPoint1
{
    partial class EditOrder_Form
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
            System.Windows.Forms.Label registrationDateLabel;
            System.Windows.Forms.Label label2;
            this.clientId_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderID_textBox = new System.Windows.Forms.TextBox();
            this.OrderID_label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.Note_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel_checkBox = new System.Windows.Forms.CheckBox();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.RentTableAdapter();
            this.OrderDate_textBox = new System.Windows.Forms.TextBox();
            this.attachmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attachmentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.AttachmentTableAdapter();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DetailTableAdapter();
            registrationDateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            registrationDateLabel.Location = new System.Drawing.Point(64, 191);
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new System.Drawing.Size(98, 20);
            registrationDateLabel.TabIndex = 70;
            registrationDateLabel.Text = "Order Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(64, 263);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 20);
            label2.TabIndex = 72;
            label2.Text = "Cancel:";
            // 
            // clientId_textBox
            // 
            this.clientId_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientId_textBox.Location = new System.Drawing.Point(233, 159);
            this.clientId_textBox.MaxLength = 30;
            this.clientId_textBox.Name = "clientId_textBox";
            this.clientId_textBox.ReadOnly = true;
            this.clientId_textBox.Size = new System.Drawing.Size(267, 26);
            this.clientId_textBox.TabIndex = 63;
            this.clientId_textBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "client_id";
            // 
            // OrderID_textBox
            // 
            this.OrderID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderID_textBox.Location = new System.Drawing.Point(233, 127);
            this.OrderID_textBox.Name = "OrderID_textBox";
            this.OrderID_textBox.ReadOnly = true;
            this.OrderID_textBox.Size = new System.Drawing.Size(267, 26);
            this.OrderID_textBox.TabIndex = 62;
            this.OrderID_textBox.TabStop = false;
            // 
            // OrderID_label
            // 
            this.OrderID_label.AutoSize = true;
            this.OrderID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderID_label.Location = new System.Drawing.Point(64, 128);
            this.OrderID_label.Name = "OrderID_label";
            this.OrderID_label.Size = new System.Drawing.Size(70, 20);
            this.OrderID_label.TabIndex = 67;
            this.OrderID_label.Text = "order_id";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(57, 42);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 66;
            this.Cancel_button.TabStop = false;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            // 
            // Accept_button
            // 
            this.Accept_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Accept_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accept_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accept_button.Location = new System.Drawing.Point(407, 42);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 65;
            this.Accept_button.TabStop = false;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(248, 46);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(67, 26);
            this.Header_label.TabIndex = 64;
            this.Header_label.Text = "Order";
            // 
            // Note_textBox
            // 
            this.Note_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Note_textBox.Location = new System.Drawing.Point(233, 308);
            this.Note_textBox.Multiline = true;
            this.Note_textBox.Name = "Note_textBox";
            this.Note_textBox.Size = new System.Drawing.Size(267, 87);
            this.Note_textBox.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Note";
            // 
            // Cancel_checkBox
            // 
            this.Cancel_checkBox.AutoSize = true;
            this.Cancel_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_checkBox.Location = new System.Drawing.Point(233, 263);
            this.Cancel_checkBox.Name = "Cancel_checkBox";
            this.Cancel_checkBox.Size = new System.Drawing.Size(18, 17);
            this.Cancel_checkBox.TabIndex = 75;
            this.Cancel_checkBox.UseVisualStyleBackColor = true;
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
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "Rent";
            this.rentBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // OrderDate_textBox
            // 
            this.OrderDate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDate_textBox.Location = new System.Drawing.Point(233, 191);
            this.OrderDate_textBox.MaxLength = 30;
            this.OrderDate_textBox.Name = "OrderDate_textBox";
            this.OrderDate_textBox.ReadOnly = true;
            this.OrderDate_textBox.Size = new System.Drawing.Size(267, 26);
            this.OrderDate_textBox.TabIndex = 76;
            this.OrderDate_textBox.TabStop = false;
            // 
            // attachmentBindingSource
            // 
            this.attachmentBindingSource.DataMember = "Attachment";
            this.attachmentBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // attachmentTableAdapter
            // 
            this.attachmentTableAdapter.ClearBeforeFill = true;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // EditOrder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 477);
            this.ControlBox = false;
            this.Controls.Add(this.OrderDate_textBox);
            this.Controls.Add(this.Cancel_checkBox);
            this.Controls.Add(this.Note_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(registrationDateLabel);
            this.Controls.Add(this.clientId_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderID_textBox);
            this.Controls.Add(this.OrderID_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditOrder_Form";
            this.Text = "Edit Order";
            this.Load += new System.EventHandler(this.EditOrder_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientId_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderID_textBox;
        private System.Windows.Forms.Label OrderID_label;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.TextBox Note_textBox;
        private System.Windows.Forms.Label label3;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private RentalPointDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox Cancel_checkBox;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private RentalPointDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.TextBox OrderDate_textBox;
        private System.Windows.Forms.BindingSource attachmentBindingSource;
        private RentalPointDataSetTableAdapters.AttachmentTableAdapter attachmentTableAdapter;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private RentalPointDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
    }
}