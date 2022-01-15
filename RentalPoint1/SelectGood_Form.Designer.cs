namespace RentalPoint1
{
    partial class SelectGood_Form
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
            this.Good_dataGridView = new System.Windows.Forms.DataGridView();
            this.SelectGood_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.To_label = new System.Windows.Forms.Label();
            this.From_label = new System.Windows.Forms.Label();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.RentTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.Good_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(218, 44);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 46;
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
            this.Accept_button.Location = new System.Drawing.Point(581, 44);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 45;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(421, 48);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(58, 26);
            this.Header_label.TabIndex = 44;
            this.Header_label.Text = "Rent";
            // 
            // Good_dataGridView
            // 
            this.Good_dataGridView.AllowUserToAddRows = false;
            this.Good_dataGridView.AllowUserToDeleteRows = false;
            this.Good_dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Good_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Good_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.Good_dataGridView.Location = new System.Drawing.Point(65, 132);
            this.Good_dataGridView.MultiSelect = false;
            this.Good_dataGridView.Name = "Good_dataGridView";
            this.Good_dataGridView.ReadOnly = true;
            this.Good_dataGridView.RowHeadersWidth = 51;
            this.Good_dataGridView.RowTemplate.Height = 24;
            this.Good_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Good_dataGridView.Size = new System.Drawing.Size(825, 205);
            this.Good_dataGridView.TabIndex = 60;
            // 
            // SelectGood_label
            // 
            this.SelectGood_label.AutoSize = true;
            this.SelectGood_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectGood_label.Location = new System.Drawing.Point(60, 88);
            this.SelectGood_label.Name = "SelectGood_label";
            this.SelectGood_label.Size = new System.Drawing.Size(120, 25);
            this.SelectGood_label.TabIndex = 61;
            this.SelectGood_label.Text = "Select Good";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.To_label);
            this.groupBox1.Controls.Add(this.From_label);
            this.groupBox1.Controls.Add(this.To_dateTimePicker);
            this.groupBox1.Controls.Add(this.From_dateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(65, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 124);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select \'From\' and \'To\' Dates";
            // 
            // To_label
            // 
            this.To_label.AutoSize = true;
            this.To_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.To_label.Location = new System.Drawing.Point(438, 62);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(28, 20);
            this.To_label.TabIndex = 3;
            this.To_label.Text = "To";
            // 
            // From_label
            // 
            this.From_label.AutoSize = true;
            this.From_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.From_label.Location = new System.Drawing.Point(28, 62);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(48, 20);
            this.From_label.TabIndex = 2;
            this.From_label.Text = "From";
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.To_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_dateTimePicker.Location = new System.Drawing.Point(481, 57);
            this.To_dateTimePicker.MinDate = new System.DateTime(2020, 12, 31, 0, 16, 29, 0);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(303, 26);
            this.To_dateTimePicker.TabIndex = 1;
            this.To_dateTimePicker.Value = new System.DateTime(2020, 12, 31, 0, 16, 29, 0);
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.From_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_dateTimePicker.Location = new System.Drawing.Point(94, 56);
            this.From_dateTimePicker.MinDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(299, 26);
            this.From_dateTimePicker.TabIndex = 0;
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
            // SelectGood_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 533);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectGood_label);
            this.Controls.Add(this.Good_dataGridView);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectGood_Form";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.RentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Good_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.DataGridView Good_dataGridView;
        private System.Windows.Forms.Label SelectGood_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private RentalPointDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}