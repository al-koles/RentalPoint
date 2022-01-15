namespace RentalPoint1
{
    partial class EditGood_Form
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
            this.ProductID_comboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.UsingSince_label = new System.Windows.Forms.Label();
            this.ProductionDate_label = new System.Windows.Forms.Label();
            this.ProductID_label = new System.Windows.Forms.Label();
            this.GoodID_textBox = new System.Windows.Forms.TextBox();
            this.GoodID_label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.ProducerID_label = new System.Windows.Forms.Label();
            this.Condition_comboBox = new System.Windows.Forms.ComboBox();
            this.ProductionDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UsingSince_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.GoodTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductID_comboBox
            // 
            this.ProductID_comboBox.DataSource = this.productBindingSource;
            this.ProductID_comboBox.DisplayMember = "product_id";
            this.ProductID_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductID_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductID_comboBox.FormattingEnabled = true;
            this.ProductID_comboBox.Location = new System.Drawing.Point(222, 152);
            this.ProductID_comboBox.Name = "ProductID_comboBox";
            this.ProductID_comboBox.Size = new System.Drawing.Size(267, 28);
            this.ProductID_comboBox.TabIndex = 102;
            this.ProductID_comboBox.ValueMember = "product_id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsingSince_label
            // 
            this.UsingSince_label.AutoSize = true;
            this.UsingSince_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsingSince_label.Location = new System.Drawing.Point(51, 249);
            this.UsingSince_label.Name = "UsingSince_label";
            this.UsingSince_label.Size = new System.Drawing.Size(99, 20);
            this.UsingSince_label.TabIndex = 114;
            this.UsingSince_label.Text = "Using Since";
            // 
            // ProductionDate_label
            // 
            this.ProductionDate_label.AutoSize = true;
            this.ProductionDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductionDate_label.Location = new System.Drawing.Point(51, 219);
            this.ProductionDate_label.Name = "ProductionDate_label";
            this.ProductionDate_label.Size = new System.Drawing.Size(130, 20);
            this.ProductionDate_label.TabIndex = 113;
            this.ProductionDate_label.Text = "Production Date";
            // 
            // ProductID_label
            // 
            this.ProductID_label.AutoSize = true;
            this.ProductID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductID_label.Location = new System.Drawing.Point(51, 155);
            this.ProductID_label.Name = "ProductID_label";
            this.ProductID_label.Size = new System.Drawing.Size(87, 20);
            this.ProductID_label.TabIndex = 111;
            this.ProductID_label.Text = "product_id";
            // 
            // GoodID_textBox
            // 
            this.GoodID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodID_textBox.Location = new System.Drawing.Point(222, 120);
            this.GoodID_textBox.Name = "GoodID_textBox";
            this.GoodID_textBox.ReadOnly = true;
            this.GoodID_textBox.Size = new System.Drawing.Size(267, 26);
            this.GoodID_textBox.TabIndex = 101;
            // 
            // GoodID_label
            // 
            this.GoodID_label.AutoSize = true;
            this.GoodID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodID_label.Location = new System.Drawing.Point(51, 123);
            this.GoodID_label.Name = "GoodID_label";
            this.GoodID_label.Size = new System.Drawing.Size(67, 20);
            this.GoodID_label.TabIndex = 110;
            this.GoodID_label.Text = "good_id";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(46, 34);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 107;
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
            this.Accept_button.Location = new System.Drawing.Point(396, 34);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 108;
            this.Accept_button.TabStop = false;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(240, 38);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(65, 26);
            this.Header_label.TabIndex = 109;
            this.Header_label.Text = "Good";
            // 
            // ProducerID_label
            // 
            this.ProducerID_label.AutoSize = true;
            this.ProducerID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProducerID_label.Location = new System.Drawing.Point(51, 187);
            this.ProducerID_label.Name = "ProducerID_label";
            this.ProducerID_label.Size = new System.Drawing.Size(79, 20);
            this.ProducerID_label.TabIndex = 112;
            this.ProducerID_label.Text = "Condition";
            // 
            // Condition_comboBox
            // 
            this.Condition_comboBox.DisplayMember = "ProducerName";
            this.Condition_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Condition_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Condition_comboBox.FormattingEnabled = true;
            this.Condition_comboBox.Items.AddRange(new object[] {
            "Bad",
            "Good"});
            this.Condition_comboBox.Location = new System.Drawing.Point(222, 184);
            this.Condition_comboBox.Name = "Condition_comboBox";
            this.Condition_comboBox.Size = new System.Drawing.Size(267, 28);
            this.Condition_comboBox.TabIndex = 103;
            this.Condition_comboBox.ValueMember = "producer_id";
            // 
            // ProductionDate_dateTimePicker
            // 
            this.ProductionDate_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductionDate_dateTimePicker.Location = new System.Drawing.Point(222, 218);
            this.ProductionDate_dateTimePicker.MaxDate = new System.DateTime(2020, 12, 27, 0, 0, 0, 0);
            this.ProductionDate_dateTimePicker.Name = "ProductionDate_dateTimePicker";
            this.ProductionDate_dateTimePicker.Size = new System.Drawing.Size(267, 26);
            this.ProductionDate_dateTimePicker.TabIndex = 115;
            this.ProductionDate_dateTimePicker.Value = new System.DateTime(2020, 12, 27, 0, 0, 0, 0);
            // 
            // UsingSince_dateTimePicker
            // 
            this.UsingSince_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsingSince_dateTimePicker.Location = new System.Drawing.Point(222, 249);
            this.UsingSince_dateTimePicker.MaxDate = new System.DateTime(2020, 12, 27, 0, 0, 0, 0);
            this.UsingSince_dateTimePicker.Name = "UsingSince_dateTimePicker";
            this.UsingSince_dateTimePicker.Size = new System.Drawing.Size(267, 26);
            this.UsingSince_dateTimePicker.TabIndex = 116;
            this.UsingSince_dateTimePicker.Value = new System.DateTime(2020, 12, 27, 0, 0, 0, 0);
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = null;
            this.tableAdapterManager.DiscountTypeTableAdapter = null;
            this.tableAdapterManager.GoodTableAdapter = this.goodTableAdapter;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.ModelTypeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.SetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // EditGood_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 334);
            this.ControlBox = false;
            this.Controls.Add(this.UsingSince_dateTimePicker);
            this.Controls.Add(this.ProductionDate_dateTimePicker);
            this.Controls.Add(this.Condition_comboBox);
            this.Controls.Add(this.ProductID_comboBox);
            this.Controls.Add(this.UsingSince_label);
            this.Controls.Add(this.ProductionDate_label);
            this.Controls.Add(this.ProducerID_label);
            this.Controls.Add(this.ProductID_label);
            this.Controls.Add(this.GoodID_textBox);
            this.Controls.Add(this.GoodID_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGood_Form";
            this.Text = "Edit Good";
            this.Load += new System.EventHandler(this.EditGoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductID_comboBox;
        private System.Windows.Forms.Label UsingSince_label;
        private System.Windows.Forms.Label ProductionDate_label;
        private System.Windows.Forms.Label ProductID_label;
        private System.Windows.Forms.TextBox GoodID_textBox;
        private System.Windows.Forms.Label GoodID_label;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Label ProducerID_label;
        private System.Windows.Forms.ComboBox Condition_comboBox;
        private System.Windows.Forms.DateTimePicker ProductionDate_dateTimePicker;
        private System.Windows.Forms.DateTimePicker UsingSince_dateTimePicker;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private RentalPointDataSetTableAdapters.GoodTableAdapter goodTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RentalPointDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}