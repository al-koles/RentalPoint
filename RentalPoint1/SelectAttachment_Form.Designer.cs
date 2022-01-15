namespace RentalPoint1.Resources
{
    partial class SelectAttachment_Form
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
            this.SelectGood_label = new System.Windows.Forms.Label();
            this.Detail_dataGridView = new System.Windows.Forms.DataGridView();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.attachmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attachmentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.AttachmentTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.Number_label = new System.Windows.Forms.Label();
            this.Amount_listBox = new System.Windows.Forms.ListBox();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DetailTableAdapter();
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.SetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectGood_label
            // 
            this.SelectGood_label.AutoSize = true;
            this.SelectGood_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectGood_label.Location = new System.Drawing.Point(43, 86);
            this.SelectGood_label.Name = "SelectGood_label";
            this.SelectGood_label.Size = new System.Drawing.Size(121, 25);
            this.SelectGood_label.TabIndex = 66;
            this.SelectGood_label.Text = "Select Detail";
            // 
            // Detail_dataGridView
            // 
            this.Detail_dataGridView.AllowUserToAddRows = false;
            this.Detail_dataGridView.AllowUserToDeleteRows = false;
            this.Detail_dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Detail_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detail_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.Detail_dataGridView.Location = new System.Drawing.Point(48, 130);
            this.Detail_dataGridView.MultiSelect = false;
            this.Detail_dataGridView.Name = "Detail_dataGridView";
            this.Detail_dataGridView.ReadOnly = true;
            this.Detail_dataGridView.RowHeadersWidth = 51;
            this.Detail_dataGridView.RowTemplate.Height = 24;
            this.Detail_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Detail_dataGridView.Size = new System.Drawing.Size(656, 164);
            this.Detail_dataGridView.TabIndex = 65;
            this.Detail_dataGridView.SelectionChanged += new System.EventHandler(this.Good_dataGridView_SelectionChanged);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(199, 27);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 64;
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
            this.Accept_button.Location = new System.Drawing.Point(562, 27);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 63;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(371, 31);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(123, 26);
            this.Header_label.TabIndex = 62;
            this.Header_label.Text = "Attachment";
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachmentTableAdapter = this.attachmentTableAdapter;
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
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.SetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Number_label
            // 
            this.Number_label.AutoSize = true;
            this.Number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_label.Location = new System.Drawing.Point(634, 86);
            this.Number_label.Name = "Number_label";
            this.Number_label.Size = new System.Drawing.Size(233, 20);
            this.Number_label.TabIndex = 67;
            this.Number_label.Text = "How many ones do you need?";
            // 
            // Amount_listBox
            // 
            this.Amount_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount_listBox.FormattingEnabled = true;
            this.Amount_listBox.ItemHeight = 20;
            this.Amount_listBox.Location = new System.Drawing.Point(738, 130);
            this.Amount_listBox.Name = "Amount_listBox";
            this.Amount_listBox.Size = new System.Drawing.Size(145, 164);
            this.Amount_listBox.TabIndex = 68;
            this.Amount_listBox.TabStop = false;
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
            // setBindingSource
            // 
            this.setBindingSource.DataMember = "Set";
            this.setBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // setTableAdapter
            // 
            this.setTableAdapter.ClearBeforeFill = true;
            // 
            // SelectAttachment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 403);
            this.ControlBox = false;
            this.Controls.Add(this.Amount_listBox);
            this.Controls.Add(this.Number_label);
            this.Controls.Add(this.SelectGood_label);
            this.Controls.Add(this.Detail_dataGridView);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectAttachment_Form";
            this.Text = "Select Attachment";
            this.Load += new System.EventHandler(this.SelectAttachment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detail_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectGood_label;
        private System.Windows.Forms.DataGridView Detail_dataGridView;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource attachmentBindingSource;
        private RentalPointDataSetTableAdapters.AttachmentTableAdapter attachmentTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label Number_label;
        private System.Windows.Forms.ListBox Amount_listBox;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private RentalPointDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.BindingSource setBindingSource;
        private RentalPointDataSetTableAdapters.SetTableAdapter setTableAdapter;
    }
}