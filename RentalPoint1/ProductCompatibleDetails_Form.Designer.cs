namespace RentalPoint1
{
    partial class ProductCompatibleDetails_Form
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
            System.Windows.Forms.Label productId_label;
            System.Windows.Forms.Label modelType_label;
            System.Windows.Forms.Label producer_label;
            System.Windows.Forms.Label Brand_Label;
            System.Windows.Forms.Label Model_Label;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.setDataGridView = new System.Windows.Forms.DataGridView();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Header_label = new System.Windows.Forms.Label();
            this.AddDEtails_label = new System.Windows.Forms.Label();
            this.productTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.setTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.SetTableAdapter();
            this.detailTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DetailTableAdapter();
            this.productId_textBox = new System.Windows.Forms.TextBox();
            this.ModelType_textBox = new System.Windows.Forms.TextBox();
            this.Producer_textBox = new System.Windows.Forms.TextBox();
            this.Brand_textBox = new System.Windows.Forms.TextBox();
            this.Model_textBox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.GridControls_groupBox = new System.Windows.Forms.GroupBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            productId_label = new System.Windows.Forms.Label();
            modelType_label = new System.Windows.Forms.Label();
            producer_label = new System.Windows.Forms.Label();
            Brand_Label = new System.Windows.Forms.Label();
            Model_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            this.GridControls_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productId_label
            // 
            productId_label.AutoSize = true;
            productId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productId_label.Location = new System.Drawing.Point(170, 96);
            productId_label.Name = "productId_label";
            productId_label.Size = new System.Drawing.Size(92, 20);
            productId_label.TabIndex = 1;
            productId_label.Text = "product_id:";
            // 
            // modelType_label
            // 
            modelType_label.AutoSize = true;
            modelType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            modelType_label.Location = new System.Drawing.Point(170, 128);
            modelType_label.Name = "modelType_label";
            modelType_label.Size = new System.Drawing.Size(100, 20);
            modelType_label.TabIndex = 3;
            modelType_label.Text = "Model Type:";
            // 
            // producer_label
            // 
            producer_label.AutoSize = true;
            producer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            producer_label.Location = new System.Drawing.Point(170, 160);
            producer_label.Name = "producer_label";
            producer_label.Size = new System.Drawing.Size(82, 20);
            producer_label.TabIndex = 5;
            producer_label.Text = "Producer:";
            // 
            // Brand_Label
            // 
            Brand_Label.AutoSize = true;
            Brand_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Brand_Label.Location = new System.Drawing.Point(170, 192);
            Brand_Label.Name = "Brand_Label";
            Brand_Label.Size = new System.Drawing.Size(59, 20);
            Brand_Label.TabIndex = 7;
            Brand_Label.Text = "Brand:";
            // 
            // Model_Label
            // 
            Model_Label.AutoSize = true;
            Model_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Model_Label.Location = new System.Drawing.Point(170, 224);
            Model_Label.Name = "Model_Label";
            Model_Label.Size = new System.Drawing.Size(59, 20);
            Model_Label.TabIndex = 9;
            Model_Label.Text = "Model:";
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
            // setDataGridView
            // 
            this.setDataGridView.AllowUserToAddRows = false;
            this.setDataGridView.AllowUserToDeleteRows = false;
            this.setDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.setDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.setDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.setDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.setDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.setDataGridView.Location = new System.Drawing.Point(58, 314);
            this.setDataGridView.MultiSelect = false;
            this.setDataGridView.Name = "setDataGridView";
            this.setDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.setDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.setDataGridView.RowHeadersWidth = 51;
            this.setDataGridView.RowTemplate.Height = 24;
            this.setDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.setDataGridView.Size = new System.Drawing.Size(828, 159);
            this.setDataGridView.TabIndex = 15;
            this.setDataGridView.TabStop = false;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // setBindingSource
            // 
            this.setBindingSource.DataMember = "FK__Set__product_id__55F4C372";
            this.setBindingSource.DataSource = this.productBindingSource;
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(71, 43);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(75, 24);
            this.Header_label.TabIndex = 16;
            this.Header_label.Text = "Product";
            // 
            // AddDEtails_label
            // 
            this.AddDEtails_label.AutoSize = true;
            this.AddDEtails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDEtails_label.Location = new System.Drawing.Point(60, 285);
            this.AddDEtails_label.Name = "AddDEtails_label";
            this.AddDEtails_label.Size = new System.Drawing.Size(163, 24);
            this.AddDEtails_label.TabIndex = 19;
            this.AddDEtails_label.Text = "Сompatible details";
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
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.ModelTypeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RentTableAdapter = null;
            this.tableAdapterManager.SetTableAdapter = this.setTableAdapter;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // setTableAdapter
            // 
            this.setTableAdapter.ClearBeforeFill = true;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // productId_textBox
            // 
            this.productId_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productId_textBox.Location = new System.Drawing.Point(353, 93);
            this.productId_textBox.Name = "productId_textBox";
            this.productId_textBox.ReadOnly = true;
            this.productId_textBox.Size = new System.Drawing.Size(276, 26);
            this.productId_textBox.TabIndex = 1;
            this.productId_textBox.TabStop = false;
            // 
            // ModelType_textBox
            // 
            this.ModelType_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelType_textBox.Location = new System.Drawing.Point(353, 125);
            this.ModelType_textBox.Name = "ModelType_textBox";
            this.ModelType_textBox.ReadOnly = true;
            this.ModelType_textBox.Size = new System.Drawing.Size(276, 26);
            this.ModelType_textBox.TabIndex = 2;
            this.ModelType_textBox.TabStop = false;
            // 
            // Producer_textBox
            // 
            this.Producer_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Producer_textBox.Location = new System.Drawing.Point(353, 157);
            this.Producer_textBox.Name = "Producer_textBox";
            this.Producer_textBox.ReadOnly = true;
            this.Producer_textBox.Size = new System.Drawing.Size(276, 26);
            this.Producer_textBox.TabIndex = 3;
            this.Producer_textBox.TabStop = false;
            // 
            // Brand_textBox
            // 
            this.Brand_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand_textBox.Location = new System.Drawing.Point(353, 189);
            this.Brand_textBox.Name = "Brand_textBox";
            this.Brand_textBox.ReadOnly = true;
            this.Brand_textBox.Size = new System.Drawing.Size(276, 26);
            this.Brand_textBox.TabIndex = 4;
            this.Brand_textBox.TabStop = false;
            // 
            // Model_textBox
            // 
            this.Model_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model_textBox.Location = new System.Drawing.Point(353, 221);
            this.Model_textBox.Name = "Model_textBox";
            this.Model_textBox.ReadOnly = true;
            this.Model_textBox.Size = new System.Drawing.Size(276, 26);
            this.Model_textBox.TabIndex = 5;
            this.Model_textBox.TabStop = false;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(16, 17);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(190, 34);
            this.Add_button.TabIndex = 67;
            this.Add_button.TabStop = false;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // GridControls_groupBox
            // 
            this.GridControls_groupBox.Controls.Add(this.Delete_button);
            this.GridControls_groupBox.Controls.Add(this.Add_button);
            this.GridControls_groupBox.Controls.Add(this.Edit_button);
            this.GridControls_groupBox.Location = new System.Drawing.Point(162, 479);
            this.GridControls_groupBox.Name = "GridControls_groupBox";
            this.GridControls_groupBox.Size = new System.Drawing.Size(609, 57);
            this.GridControls_groupBox.TabIndex = 71;
            this.GridControls_groupBox.TabStop = false;
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(212, 17);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(190, 34);
            this.Edit_button.TabIndex = 68;
            this.Edit_button.TabStop = false;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(408, 17);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(190, 34);
            this.Delete_button.TabIndex = 70;
            this.Delete_button.TabStop = false;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // ProductCompatibleDetails_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 591);
            this.Controls.Add(this.GridControls_groupBox);
            this.Controls.Add(this.Model_textBox);
            this.Controls.Add(this.Brand_textBox);
            this.Controls.Add(this.Producer_textBox);
            this.Controls.Add(this.ModelType_textBox);
            this.Controls.Add(this.productId_textBox);
            this.Controls.Add(this.AddDEtails_label);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.setDataGridView);
            this.Controls.Add(productId_label);
            this.Controls.Add(modelType_label);
            this.Controls.Add(producer_label);
            this.Controls.Add(Brand_Label);
            this.Controls.Add(Model_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductCompatibleDetails_Form";
            this.Text = "Product Compatible Details";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            this.GridControls_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RentalPointDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RentalPointDataSetTableAdapters.SetTableAdapter setTableAdapter;
        private System.Windows.Forms.BindingSource setBindingSource;
        private System.Windows.Forms.DataGridView setDataGridView;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Label AddDEtails_label;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private RentalPointDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.TextBox productId_textBox;
        private System.Windows.Forms.TextBox ModelType_textBox;
        private System.Windows.Forms.TextBox Producer_textBox;
        private System.Windows.Forms.TextBox Brand_textBox;
        private System.Windows.Forms.TextBox Model_textBox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.GroupBox GridControls_groupBox;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
    }
}