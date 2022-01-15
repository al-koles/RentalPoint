namespace RentalPoint1
{
    partial class EditDetail_Form
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
            this.Amount_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.ProducerID_comboBox = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.ModelID_comboBox = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Amount_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.ProducerID_label = new System.Windows.Forms.Label();
            this.ModelID_label = new System.Windows.Forms.Label();
            this.DetailID_textBox = new System.Windows.Forms.TextBox();
            this.DetailID_label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IsReturnable_checkBox = new System.Windows.Forms.CheckBox();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DetailTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.modelTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ModelTableAdapter();
            this.producerTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ProducerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Amount_maskedTextBox
            // 
            this.Amount_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount_maskedTextBox.Location = new System.Drawing.Point(225, 241);
            this.Amount_maskedTextBox.Mask = "999999";
            this.Amount_maskedTextBox.Name = "Amount_maskedTextBox";
            this.Amount_maskedTextBox.Size = new System.Drawing.Size(267, 26);
            this.Amount_maskedTextBox.TabIndex = 5;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_textBox.Location = new System.Drawing.Point(225, 211);
            this.Price_textBox.MaxLength = 100;
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(267, 26);
            this.Price_textBox.TabIndex = 4;
            // 
            // ProducerID_comboBox
            // 
            this.ProducerID_comboBox.DataSource = this.producerBindingSource;
            this.ProducerID_comboBox.DisplayMember = "ProducerName";
            this.ProducerID_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProducerID_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProducerID_comboBox.FormattingEnabled = true;
            this.ProducerID_comboBox.Location = new System.Drawing.Point(225, 179);
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
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ModelID_comboBox
            // 
            this.ModelID_comboBox.DataSource = this.modelBindingSource;
            this.ModelID_comboBox.DisplayMember = "ModelName";
            this.ModelID_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelID_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelID_comboBox.FormattingEnabled = true;
            this.ModelID_comboBox.Location = new System.Drawing.Point(225, 147);
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
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount_label.Location = new System.Drawing.Point(54, 244);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(66, 20);
            this.Amount_label.TabIndex = 99;
            this.Amount_label.Text = "Amount";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_label.Location = new System.Drawing.Point(54, 214);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(127, 20);
            this.Price_label.TabIndex = 98;
            this.Price_label.Text = "Price(UAH/day)";
            // 
            // ProducerID_label
            // 
            this.ProducerID_label.AutoSize = true;
            this.ProducerID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProducerID_label.Location = new System.Drawing.Point(54, 182);
            this.ProducerID_label.Name = "ProducerID_label";
            this.ProducerID_label.Size = new System.Drawing.Size(77, 20);
            this.ProducerID_label.TabIndex = 97;
            this.ProducerID_label.Text = "Producer";
            // 
            // ModelID_label
            // 
            this.ModelID_label.AutoSize = true;
            this.ModelID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelID_label.Location = new System.Drawing.Point(54, 150);
            this.ModelID_label.Name = "ModelID_label";
            this.ModelID_label.Size = new System.Drawing.Size(54, 20);
            this.ModelID_label.TabIndex = 96;
            this.ModelID_label.Text = "Model";
            // 
            // DetailID_textBox
            // 
            this.DetailID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailID_textBox.Location = new System.Drawing.Point(225, 115);
            this.DetailID_textBox.Name = "DetailID_textBox";
            this.DetailID_textBox.ReadOnly = true;
            this.DetailID_textBox.Size = new System.Drawing.Size(267, 26);
            this.DetailID_textBox.TabIndex = 1;
            // 
            // DetailID_label
            // 
            this.DetailID_label.AutoSize = true;
            this.DetailID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailID_label.Location = new System.Drawing.Point(54, 118);
            this.DetailID_label.Name = "DetailID_label";
            this.DetailID_label.Size = new System.Drawing.Size(71, 20);
            this.DetailID_label.TabIndex = 95;
            this.DetailID_label.Text = "detail_id";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(49, 29);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 92;
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
            this.Accept_button.Location = new System.Drawing.Point(399, 29);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 93;
            this.Accept_button.TabStop = false;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(243, 33);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(68, 26);
            this.Header_label.TabIndex = 94;
            this.Header_label.Text = "Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Is Returnable";
            // 
            // IsReturnable_checkBox
            // 
            this.IsReturnable_checkBox.AutoSize = true;
            this.IsReturnable_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsReturnable_checkBox.Location = new System.Drawing.Point(225, 273);
            this.IsReturnable_checkBox.Name = "IsReturnable_checkBox";
            this.IsReturnable_checkBox.Size = new System.Drawing.Size(18, 17);
            this.IsReturnable_checkBox.TabIndex = 6;
            this.IsReturnable_checkBox.UseVisualStyleBackColor = true;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = this.detailTableAdapter;
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
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // EditDetail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 373);
            this.ControlBox = false;
            this.Controls.Add(this.IsReturnable_checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amount_maskedTextBox);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.ProducerID_comboBox);
            this.Controls.Add(this.ModelID_comboBox);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.ProducerID_label);
            this.Controls.Add(this.ModelID_label);
            this.Controls.Add(this.DetailID_textBox);
            this.Controls.Add(this.DetailID_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDetail_Form";
            this.Text = "Edit Detail";
            this.Load += new System.EventHandler(this.EditDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Amount_maskedTextBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.ComboBox ProducerID_comboBox;
        private System.Windows.Forms.ComboBox ModelID_comboBox;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Label ProducerID_label;
        private System.Windows.Forms.Label ModelID_label;
        private System.Windows.Forms.TextBox DetailID_textBox;
        private System.Windows.Forms.Label DetailID_label;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IsReturnable_checkBox;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private RentalPointDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private RentalPointDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private RentalPointDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
    }
}