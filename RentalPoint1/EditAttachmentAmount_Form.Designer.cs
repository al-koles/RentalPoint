namespace RentalPoint1
{
    partial class EditAttachmentAmount_Form
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
            this.RentID_textBox = new System.Windows.Forms.TextBox();
            this.RentID_label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.AttachmentId_textBox = new System.Windows.Forms.TextBox();
            this.AttachmentId_label = new System.Windows.Forms.Label();
            this.SetId_textBox = new System.Windows.Forms.TextBox();
            this.SetId_label = new System.Windows.Forms.Label();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Amount_listBox = new System.Windows.Forms.ListBox();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.attachmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attachmentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.AttachmentTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.detailTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DetailTableAdapter();
            this.setTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.SetTableAdapter();
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RentID_textBox
            // 
            this.RentID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RentID_textBox.Location = new System.Drawing.Point(205, 140);
            this.RentID_textBox.Name = "RentID_textBox";
            this.RentID_textBox.ReadOnly = true;
            this.RentID_textBox.Size = new System.Drawing.Size(267, 26);
            this.RentID_textBox.TabIndex = 133;
            this.RentID_textBox.TabStop = false;
            // 
            // RentID_label
            // 
            this.RentID_label.AutoSize = true;
            this.RentID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RentID_label.Location = new System.Drawing.Point(63, 143);
            this.RentID_label.Name = "RentID_label";
            this.RentID_label.Size = new System.Drawing.Size(60, 20);
            this.RentID_label.TabIndex = 137;
            this.RentID_label.Text = "rent_id";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(42, 30);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 134;
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
            this.Accept_button.Location = new System.Drawing.Point(392, 30);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 135;
            this.Accept_button.TabStop = false;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(236, 34);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(58, 26);
            this.Header_label.TabIndex = 136;
            this.Header_label.Text = "Rent";
            // 
            // AttachmentId_textBox
            // 
            this.AttachmentId_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttachmentId_textBox.Location = new System.Drawing.Point(205, 108);
            this.AttachmentId_textBox.Name = "AttachmentId_textBox";
            this.AttachmentId_textBox.ReadOnly = true;
            this.AttachmentId_textBox.Size = new System.Drawing.Size(267, 26);
            this.AttachmentId_textBox.TabIndex = 138;
            this.AttachmentId_textBox.TabStop = false;
            // 
            // AttachmentId_label
            // 
            this.AttachmentId_label.AutoSize = true;
            this.AttachmentId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttachmentId_label.Location = new System.Drawing.Point(63, 111);
            this.AttachmentId_label.Name = "AttachmentId_label";
            this.AttachmentId_label.Size = new System.Drawing.Size(114, 20);
            this.AttachmentId_label.TabIndex = 139;
            this.AttachmentId_label.Text = "attachment_id";
            // 
            // SetId_textBox
            // 
            this.SetId_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetId_textBox.Location = new System.Drawing.Point(205, 172);
            this.SetId_textBox.Name = "SetId_textBox";
            this.SetId_textBox.ReadOnly = true;
            this.SetId_textBox.Size = new System.Drawing.Size(267, 26);
            this.SetId_textBox.TabIndex = 140;
            this.SetId_textBox.TabStop = false;
            // 
            // SetId_label
            // 
            this.SetId_label.AutoSize = true;
            this.SetId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetId_label.Location = new System.Drawing.Point(63, 175);
            this.SetId_label.Name = "SetId_label";
            this.SetId_label.Size = new System.Drawing.Size(54, 20);
            this.SetId_label.TabIndex = 141;
            this.SetId_label.Text = "set_id";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount_label.Location = new System.Drawing.Point(63, 226);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(66, 20);
            this.Amount_label.TabIndex = 142;
            this.Amount_label.Text = "Amount";
            // 
            // Amount_listBox
            // 
            this.Amount_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount_listBox.FormattingEnabled = true;
            this.Amount_listBox.ItemHeight = 20;
            this.Amount_listBox.Location = new System.Drawing.Point(205, 226);
            this.Amount_listBox.Name = "Amount_listBox";
            this.Amount_listBox.Size = new System.Drawing.Size(145, 164);
            this.Amount_listBox.TabIndex = 143;
            this.Amount_listBox.TabStop = false;
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
            this.tableAdapterManager.DetailTableAdapter = this.detailTableAdapter;
            this.tableAdapterManager.DiscountTypeTableAdapter = null;
            this.tableAdapterManager.GoodTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.ModelTypeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.SetTableAdapter = this.setTableAdapter;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // setTableAdapter
            // 
            this.setTableAdapter.ClearBeforeFill = true;
            // 
            // setBindingSource
            // 
            this.setBindingSource.DataMember = "Set";
            this.setBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // EditAttachmentAmount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 451);
            this.ControlBox = false;
            this.Controls.Add(this.Amount_listBox);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.SetId_textBox);
            this.Controls.Add(this.SetId_label);
            this.Controls.Add(this.AttachmentId_textBox);
            this.Controls.Add(this.AttachmentId_label);
            this.Controls.Add(this.RentID_textBox);
            this.Controls.Add(this.RentID_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAttachmentAmount_Form";
            this.Text = "Edit Attachment";
            this.Load += new System.EventHandler(this.EditAttachmentAmount_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RentID_textBox;
        private System.Windows.Forms.Label RentID_label;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.TextBox AttachmentId_textBox;
        private System.Windows.Forms.Label AttachmentId_label;
        private System.Windows.Forms.TextBox SetId_textBox;
        private System.Windows.Forms.Label SetId_label;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.ListBox Amount_listBox;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource attachmentBindingSource;
        private RentalPointDataSetTableAdapters.AttachmentTableAdapter attachmentTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RentalPointDataSetTableAdapters.SetTableAdapter setTableAdapter;
        private System.Windows.Forms.BindingSource setBindingSource;
        private RentalPointDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.BindingSource detailBindingSource;
    }
}