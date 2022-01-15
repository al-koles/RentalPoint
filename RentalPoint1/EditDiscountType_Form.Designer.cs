namespace RentalPoint1
{
    partial class EditDiscountType_Form
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
            this.DiscountTypeName_textBox = new System.Windows.Forms.TextBox();
            this.DiscountTypeName_label = new System.Windows.Forms.Label();
            this.DiscountTypeID_textBox = new System.Windows.Forms.TextBox();
            this.DiscountTypeID_label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.discountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountTypeTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DiscountTypeTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscountTypeName_textBox
            // 
            this.DiscountTypeName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountTypeName_textBox.Location = new System.Drawing.Point(230, 143);
            this.DiscountTypeName_textBox.MaxLength = 30;
            this.DiscountTypeName_textBox.Name = "DiscountTypeName_textBox";
            this.DiscountTypeName_textBox.Size = new System.Drawing.Size(267, 26);
            this.DiscountTypeName_textBox.TabIndex = 63;
            // 
            // DiscountTypeName_label
            // 
            this.DiscountTypeName_label.AutoSize = true;
            this.DiscountTypeName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountTypeName_label.Location = new System.Drawing.Point(35, 146);
            this.DiscountTypeName_label.Name = "DiscountTypeName_label";
            this.DiscountTypeName_label.Size = new System.Drawing.Size(166, 20);
            this.DiscountTypeName_label.TabIndex = 68;
            this.DiscountTypeName_label.Text = "Discount Type Name";
            // 
            // DiscountTypeID_textBox
            // 
            this.DiscountTypeID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountTypeID_textBox.Location = new System.Drawing.Point(230, 111);
            this.DiscountTypeID_textBox.Name = "DiscountTypeID_textBox";
            this.DiscountTypeID_textBox.ReadOnly = true;
            this.DiscountTypeID_textBox.Size = new System.Drawing.Size(267, 26);
            this.DiscountTypeID_textBox.TabIndex = 62;
            // 
            // DiscountTypeID_label
            // 
            this.DiscountTypeID_label.AutoSize = true;
            this.DiscountTypeID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountTypeID_label.Location = new System.Drawing.Point(35, 114);
            this.DiscountTypeID_label.Name = "DiscountTypeID_label";
            this.DiscountTypeID_label.Size = new System.Drawing.Size(130, 20);
            this.DiscountTypeID_label.TabIndex = 67;
            this.DiscountTypeID_label.Text = "discountType_id";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(42, 32);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 66;
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
            this.Accept_button.Location = new System.Drawing.Point(392, 32);
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
            this.Header_label.Location = new System.Drawing.Point(199, 36);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(150, 26);
            this.Header_label.TabIndex = 64;
            this.Header_label.Text = "Discount Type";
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discountTypeBindingSource
            // 
            this.discountTypeBindingSource.DataMember = "DiscountType";
            this.discountTypeBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // discountTypeTableAdapter
            // 
            this.discountTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = null;
            this.tableAdapterManager.DiscountTypeTableAdapter = this.discountTypeTableAdapter;
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
            // EditDiscountTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 247);
            this.ControlBox = false;
            this.Controls.Add(this.DiscountTypeName_textBox);
            this.Controls.Add(this.DiscountTypeName_label);
            this.Controls.Add(this.DiscountTypeID_textBox);
            this.Controls.Add(this.DiscountTypeID_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDiscountTypeForm";
            this.Text = "Edit Discount Type";
            this.Load += new System.EventHandler(this.EditDiscountTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DiscountTypeName_textBox;
        private System.Windows.Forms.Label DiscountTypeName_label;
        private System.Windows.Forms.TextBox DiscountTypeID_textBox;
        private System.Windows.Forms.Label DiscountTypeID_label;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource discountTypeBindingSource;
        private RentalPointDataSetTableAdapters.DiscountTypeTableAdapter discountTypeTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}