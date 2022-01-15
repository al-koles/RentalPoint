namespace RentalPoint1
{
    partial class EditModelType_Form
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
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.ModelTypeName_textBox = new System.Windows.Forms.TextBox();
            this.ModelTypeName_label = new System.Windows.Forms.Label();
            this.ModelTypeID_textBox = new System.Windows.Forms.TextBox();
            this.ModelTypeID_label = new System.Windows.Forms.Label();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.modelTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTypeTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ModelTypeTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(49, 33);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 0;
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
            this.Accept_button.Location = new System.Drawing.Point(399, 33);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 0;
            this.Accept_button.TabStop = false;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(220, 37);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(124, 26);
            this.Header_label.TabIndex = 58;
            this.Header_label.Text = "Model Type";
            // 
            // ModelTypeName_textBox
            // 
            this.ModelTypeName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTypeName_textBox.Location = new System.Drawing.Point(225, 151);
            this.ModelTypeName_textBox.MaxLength = 30;
            this.ModelTypeName_textBox.Name = "ModelTypeName_textBox";
            this.ModelTypeName_textBox.Size = new System.Drawing.Size(267, 26);
            this.ModelTypeName_textBox.TabIndex = 2;
            // 
            // ModelTypeName_label
            // 
            this.ModelTypeName_label.AutoSize = true;
            this.ModelTypeName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTypeName_label.Location = new System.Drawing.Point(54, 154);
            this.ModelTypeName_label.Name = "ModelTypeName_label";
            this.ModelTypeName_label.Size = new System.Drawing.Size(144, 20);
            this.ModelTypeName_label.TabIndex = 65;
            this.ModelTypeName_label.Text = "Model Type Name";
            // 
            // ModelTypeID_textBox
            // 
            this.ModelTypeID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTypeID_textBox.Location = new System.Drawing.Point(225, 119);
            this.ModelTypeID_textBox.Name = "ModelTypeID_textBox";
            this.ModelTypeID_textBox.ReadOnly = true;
            this.ModelTypeID_textBox.Size = new System.Drawing.Size(267, 26);
            this.ModelTypeID_textBox.TabIndex = 1;
            // 
            // ModelTypeID_label
            // 
            this.ModelTypeID_label.AutoSize = true;
            this.ModelTypeID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTypeID_label.Location = new System.Drawing.Point(54, 122);
            this.ModelTypeID_label.Name = "ModelTypeID_label";
            this.ModelTypeID_label.Size = new System.Drawing.Size(112, 20);
            this.ModelTypeID_label.TabIndex = 64;
            this.ModelTypeID_label.Text = "modelType_id";
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelTypeBindingSource
            // 
            this.modelTypeBindingSource.DataMember = "ModelType";
            this.modelTypeBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // modelTypeTableAdapter
            // 
            this.modelTypeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ModelTypeTableAdapter = this.modelTypeTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.SetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EditModelType_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 258);
            this.ControlBox = false;
            this.Controls.Add(this.ModelTypeName_textBox);
            this.Controls.Add(this.ModelTypeName_label);
            this.Controls.Add(this.ModelTypeID_textBox);
            this.Controls.Add(this.ModelTypeID_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditModelType_Form";
            this.Text = "Edit Model Type";
            this.Load += new System.EventHandler(this.EditModelTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.TextBox ModelTypeName_textBox;
        private System.Windows.Forms.Label ModelTypeName_label;
        private System.Windows.Forms.TextBox ModelTypeID_textBox;
        private System.Windows.Forms.Label ModelTypeID_label;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource modelTypeBindingSource;
        private RentalPointDataSetTableAdapters.ModelTypeTableAdapter modelTypeTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}