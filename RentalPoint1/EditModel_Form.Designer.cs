namespace RentalPoint1
{
    partial class EditModel_Form
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
            System.Windows.Forms.Label model_idLabel;
            System.Windows.Forms.Label brand_idLabel;
            System.Windows.Forms.Label modelType_idLabel;
            System.Windows.Forms.Label modelNameLabel;
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.BrandId_comboBox = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.ModelTypeId_comboBox = new System.Windows.Forms.ComboBox();
            this.modelTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModelId_textBox = new System.Windows.Forms.TextBox();
            this.ModelName_textBox = new System.Windows.Forms.TextBox();
            this.modelTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ModelTableAdapter();
            this.brandTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.BrandTableAdapter();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.modelTypeTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ModelTypeTableAdapter();
            model_idLabel = new System.Windows.Forms.Label();
            brand_idLabel = new System.Windows.Forms.Label();
            modelType_idLabel = new System.Windows.Forms.Label();
            modelNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // model_idLabel
            // 
            model_idLabel.AutoSize = true;
            model_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            model_idLabel.Location = new System.Drawing.Point(57, 113);
            model_idLabel.Name = "model_idLabel";
            model_idLabel.Size = new System.Drawing.Size(77, 20);
            model_idLabel.TabIndex = 22;
            model_idLabel.Text = "model id:";
            // 
            // brand_idLabel
            // 
            brand_idLabel.AutoSize = true;
            brand_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            brand_idLabel.Location = new System.Drawing.Point(57, 141);
            brand_idLabel.Name = "brand_idLabel";
            brand_idLabel.Size = new System.Drawing.Size(59, 20);
            brand_idLabel.TabIndex = 24;
            brand_idLabel.Text = "Brand:";
            // 
            // modelType_idLabel
            // 
            modelType_idLabel.AutoSize = true;
            modelType_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            modelType_idLabel.Location = new System.Drawing.Point(57, 168);
            modelType_idLabel.Name = "modelType_idLabel";
            modelType_idLabel.Size = new System.Drawing.Size(100, 20);
            modelType_idLabel.TabIndex = 26;
            modelType_idLabel.Text = "Model Type:";
            // 
            // modelNameLabel
            // 
            modelNameLabel.AutoSize = true;
            modelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            modelNameLabel.Location = new System.Drawing.Point(57, 196);
            modelNameLabel.Name = "modelNameLabel";
            modelNameLabel.Size = new System.Drawing.Size(108, 20);
            modelNameLabel.TabIndex = 28;
            modelNameLabel.Text = "Model Name:";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(27, 27);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 21;
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
            this.Accept_button.Location = new System.Drawing.Point(377, 27);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 20;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(209, 31);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(71, 26);
            this.Header_label.TabIndex = 19;
            this.Header_label.Text = "Model";
            // 
            // BrandId_comboBox
            // 
            this.BrandId_comboBox.DataSource = this.brandBindingSource;
            this.BrandId_comboBox.DisplayMember = "BrandName";
            this.BrandId_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandId_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandId_comboBox.FormattingEnabled = true;
            this.BrandId_comboBox.Location = new System.Drawing.Point(204, 135);
            this.BrandId_comboBox.Name = "BrandId_comboBox";
            this.BrandId_comboBox.Size = new System.Drawing.Size(240, 28);
            this.BrandId_comboBox.TabIndex = 30;
            this.BrandId_comboBox.ValueMember = "brand_id";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ModelTypeId_comboBox
            // 
            this.ModelTypeId_comboBox.DataSource = this.modelTypeBindingSource;
            this.ModelTypeId_comboBox.DisplayMember = "ModelTypeName";
            this.ModelTypeId_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelTypeId_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTypeId_comboBox.FormattingEnabled = true;
            this.ModelTypeId_comboBox.Location = new System.Drawing.Point(204, 165);
            this.ModelTypeId_comboBox.Name = "ModelTypeId_comboBox";
            this.ModelTypeId_comboBox.Size = new System.Drawing.Size(240, 28);
            this.ModelTypeId_comboBox.TabIndex = 31;
            this.ModelTypeId_comboBox.ValueMember = "modelType_id";
            // 
            // modelTypeBindingSource
            // 
            this.modelTypeBindingSource.DataMember = "ModelType";
            this.modelTypeBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // ModelId_textBox
            // 
            this.ModelId_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelId_textBox.Location = new System.Drawing.Point(204, 107);
            this.ModelId_textBox.Name = "ModelId_textBox";
            this.ModelId_textBox.ReadOnly = true;
            this.ModelId_textBox.Size = new System.Drawing.Size(240, 26);
            this.ModelId_textBox.TabIndex = 32;
            // 
            // ModelName_textBox
            // 
            this.ModelName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelName_textBox.Location = new System.Drawing.Point(204, 196);
            this.ModelName_textBox.MaxLength = 30;
            this.ModelName_textBox.Name = "ModelName_textBox";
            this.ModelName_textBox.Size = new System.Drawing.Size(240, 26);
            this.ModelName_textBox.TabIndex = 33;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DetailTableAdapter = null;
            this.tableAdapterManager.DiscountTypeTableAdapter = null;
            this.tableAdapterManager.GoodTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.ModelTypeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.SetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // modelTypeTableAdapter
            // 
            this.modelTypeTableAdapter.ClearBeforeFill = true;
            // 
            // EditModel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 291);
            this.ControlBox = false;
            this.Controls.Add(this.ModelName_textBox);
            this.Controls.Add(this.ModelId_textBox);
            this.Controls.Add(this.ModelTypeId_comboBox);
            this.Controls.Add(this.BrandId_comboBox);
            this.Controls.Add(model_idLabel);
            this.Controls.Add(brand_idLabel);
            this.Controls.Add(modelType_idLabel);
            this.Controls.Add(modelNameLabel);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditModel_Form";
            this.Text = "Edit Model";
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private RentalPointDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RentalPointDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.ComboBox BrandId_comboBox;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.ComboBox ModelTypeId_comboBox;
        private System.Windows.Forms.BindingSource modelTypeBindingSource;
        private RentalPointDataSetTableAdapters.ModelTypeTableAdapter modelTypeTableAdapter;
        private System.Windows.Forms.TextBox ModelId_textBox;
        private System.Windows.Forms.TextBox ModelName_textBox;
    }
}