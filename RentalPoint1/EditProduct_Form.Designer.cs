namespace RentalPoint1
{
    partial class EditProduct_Form
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
            this.ModelID_label = new System.Windows.Forms.Label();
            this.ProductID_textBox = new System.Windows.Forms.TextBox();
            this.ProductID_label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.ProducerID_label = new System.Windows.Forms.Label();
            this.Deposit_label = new System.Windows.Forms.Label();
            this.Discount_label = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.ModelID_comboBox = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.modelTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ModelTableAdapter();
            this.ProducerID_comboBox = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ProducerTableAdapter();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Deposit_textBox = new System.Windows.Forms.TextBox();
            this.Discount_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelID_label
            // 
            this.ModelID_label.AutoSize = true;
            this.ModelID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelID_label.Location = new System.Drawing.Point(36, 154);
            this.ModelID_label.Name = "ModelID_label";
            this.ModelID_label.Size = new System.Drawing.Size(54, 20);
            this.ModelID_label.TabIndex = 79;
            this.ModelID_label.Text = "Model";
            // 
            // ProductID_textBox
            // 
            this.ProductID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductID_textBox.Location = new System.Drawing.Point(207, 119);
            this.ProductID_textBox.Name = "ProductID_textBox";
            this.ProductID_textBox.ReadOnly = true;
            this.ProductID_textBox.Size = new System.Drawing.Size(267, 26);
            this.ProductID_textBox.TabIndex = 1;
            // 
            // ProductID_label
            // 
            this.ProductID_label.AutoSize = true;
            this.ProductID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductID_label.Location = new System.Drawing.Point(36, 122);
            this.ProductID_label.Name = "ProductID_label";
            this.ProductID_label.Size = new System.Drawing.Size(87, 20);
            this.ProductID_label.TabIndex = 78;
            this.ProductID_label.Text = "product_id";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(31, 33);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 75;
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
            this.Accept_button.Location = new System.Drawing.Point(381, 33);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 76;
            this.Accept_button.TabStop = false;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(214, 37);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(87, 26);
            this.Header_label.TabIndex = 77;
            this.Header_label.Text = "Product";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_label.Location = new System.Drawing.Point(36, 218);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(132, 20);
            this.Price_label.TabIndex = 81;
            this.Price_label.Text = "Price (UAH/day)";
            // 
            // ProducerID_label
            // 
            this.ProducerID_label.AutoSize = true;
            this.ProducerID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProducerID_label.Location = new System.Drawing.Point(36, 186);
            this.ProducerID_label.Name = "ProducerID_label";
            this.ProducerID_label.Size = new System.Drawing.Size(77, 20);
            this.ProducerID_label.TabIndex = 80;
            this.ProducerID_label.Text = "Producer";
            // 
            // Deposit_label
            // 
            this.Deposit_label.AutoSize = true;
            this.Deposit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deposit_label.Location = new System.Drawing.Point(36, 280);
            this.Deposit_label.Name = "Deposit_label";
            this.Deposit_label.Size = new System.Drawing.Size(120, 20);
            this.Deposit_label.TabIndex = 83;
            this.Deposit_label.Text = "Deposit (UAH)";
            // 
            // Discount_label
            // 
            this.Discount_label.AutoSize = true;
            this.Discount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount_label.Location = new System.Drawing.Point(36, 248);
            this.Discount_label.Name = "Discount_label";
            this.Discount_label.Size = new System.Drawing.Size(108, 20);
            this.Discount_label.TabIndex = 82;
            this.Discount_label.Text = "Discount (%)";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_label.Location = new System.Drawing.Point(36, 312);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(95, 20);
            this.Description_label.TabIndex = 84;
            this.Description_label.Text = "Description";
            // 
            // ModelID_comboBox
            // 
            this.ModelID_comboBox.DataSource = this.modelBindingSource;
            this.ModelID_comboBox.DisplayMember = "ModelName";
            this.ModelID_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelID_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelID_comboBox.FormattingEnabled = true;
            this.ModelID_comboBox.Location = new System.Drawing.Point(207, 151);
            this.ModelID_comboBox.Name = "ModelID_comboBox";
            this.ModelID_comboBox.Size = new System.Drawing.Size(267, 28);
            this.ModelID_comboBox.TabIndex = 2;
            this.ModelID_comboBox.ValueMember = "model_id";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // ProducerID_comboBox
            // 
            this.ProducerID_comboBox.DataSource = this.producerBindingSource;
            this.ProducerID_comboBox.DisplayMember = "ProducerName";
            this.ProducerID_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProducerID_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProducerID_comboBox.FormattingEnabled = true;
            this.ProducerID_comboBox.Location = new System.Drawing.Point(207, 183);
            this.ProducerID_comboBox.Name = "ProducerID_comboBox";
            this.ProducerID_comboBox.Size = new System.Drawing.Size(267, 28);
            this.ProducerID_comboBox.TabIndex = 3;
            this.ProducerID_comboBox.ValueMember = "producer_id";
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // Description_textBox
            // 
            this.Description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_textBox.Location = new System.Drawing.Point(207, 309);
            this.Description_textBox.MaxLength = 100;
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(267, 63);
            this.Description_textBox.TabIndex = 7;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ModelTableAdapter = this.modelTableAdapter;
            this.tableAdapterManager.ModelTypeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = this.producerTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.SetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_textBox.Location = new System.Drawing.Point(207, 215);
            this.Price_textBox.MaxLength = 100;
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(267, 26);
            this.Price_textBox.TabIndex = 4;
            // 
            // Deposit_textBox
            // 
            this.Deposit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deposit_textBox.Location = new System.Drawing.Point(207, 277);
            this.Deposit_textBox.MaxLength = 100;
            this.Deposit_textBox.Name = "Deposit_textBox";
            this.Deposit_textBox.Size = new System.Drawing.Size(267, 26);
            this.Deposit_textBox.TabIndex = 6;
            // 
            // Discount_maskedTextBox
            // 
            this.Discount_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount_maskedTextBox.Location = new System.Drawing.Point(207, 245);
            this.Discount_maskedTextBox.Mask = "99";
            this.Discount_maskedTextBox.Name = "Discount_maskedTextBox";
            this.Discount_maskedTextBox.Size = new System.Drawing.Size(267, 26);
            this.Discount_maskedTextBox.TabIndex = 5;
            // 
            // EditProduct_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 439);
            this.ControlBox = false;
            this.Controls.Add(this.Discount_maskedTextBox);
            this.Controls.Add(this.Deposit_textBox);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.ProducerID_comboBox);
            this.Controls.Add(this.ModelID_comboBox);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Deposit_label);
            this.Controls.Add(this.Discount_label);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.ProducerID_label);
            this.Controls.Add(this.ModelID_label);
            this.Controls.Add(this.ProductID_textBox);
            this.Controls.Add(this.ProductID_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProduct_Form";
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModelID_label;
        private System.Windows.Forms.TextBox ProductID_textBox;
        private System.Windows.Forms.Label ProductID_label;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Label ProducerID_label;
        private System.Windows.Forms.Label Deposit_label;
        private System.Windows.Forms.Label Discount_label;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.ComboBox ModelID_comboBox;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private RentalPointDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.ComboBox ProducerID_comboBox;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private RentalPointDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RentalPointDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.TextBox Deposit_textBox;
        private System.Windows.Forms.MaskedTextBox Discount_maskedTextBox;
    }
}