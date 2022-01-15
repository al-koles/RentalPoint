namespace RentalPoint1
{
    partial class Order_Form
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label secondNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label discount___Label;
            System.Windows.Forms.Label discountType_idLabel;
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.SecondName_TextBox = new System.Windows.Forms.TextBox();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.clientId_TextBox = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discountType_comboBox = new System.Windows.Forms.ComboBox();
            this.discountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.Discount_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.discountTypeTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DiscountTypeTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.Rents_dataGridView = new System.Windows.Forms.DataGridView();
            this.rent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridControls_groupBox = new System.Windows.Forms.GroupBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Rents_groupBox = new System.Windows.Forms.GroupBox();
            this.AddAtt_button = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ClientTableAdapter();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.RentTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.OrderTableAdapter();
            this.Attachments_groupBox = new System.Windows.Forms.GroupBox();
            this.Attachments_dataGridView = new System.Windows.Forms.DataGridView();
            this.attachmentId_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelType_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EditAtt_button = new System.Windows.Forms.Button();
            this.DeleteAtt_button = new System.Windows.Forms.Button();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DetailTableAdapter();
            this.attachmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attachmentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.AttachmentTableAdapter();
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.SetTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Deposit_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            secondNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            client_idLabel = new System.Windows.Forms.Label();
            discount___Label = new System.Windows.Forms.Label();
            discountType_idLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rents_dataGridView)).BeginInit();
            this.GridControls_groupBox.SuspendLayout();
            this.Rents_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.Attachments_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Attachments_dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(430, 43);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(97, 20);
            firstNameLabel.TabIndex = 46;
            firstNameLabel.Text = "First Name:";
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            secondNameLabel.Location = new System.Drawing.Point(661, 43);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new System.Drawing.Size(119, 20);
            secondNameLabel.TabIndex = 48;
            secondNameLabel.Text = "Second Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(191, 43);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(96, 20);
            lastNameLabel.TabIndex = 50;
            lastNameLabel.Text = "Last Name:";
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_idLabel.Location = new System.Drawing.Point(92, 43);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(72, 20);
            client_idLabel.TabIndex = 44;
            client_idLabel.Text = "client id:";
            // 
            // discount___Label
            // 
            discount___Label.AutoSize = true;
            discount___Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            discount___Label.Location = new System.Drawing.Point(134, 111);
            discount___Label.Name = "discount___Label";
            discount___Label.Size = new System.Drawing.Size(108, 20);
            discount___Label.TabIndex = 52;
            discount___Label.Text = "Discount(%):";
            // 
            // discountType_idLabel
            // 
            discountType_idLabel.AutoSize = true;
            discountType_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            discountType_idLabel.Location = new System.Drawing.Point(397, 111);
            discountType_idLabel.Name = "discountType_idLabel";
            discountType_idLabel.Size = new System.Drawing.Size(118, 20);
            discountType_idLabel.TabIndex = 54;
            discountType_idLabel.Text = "discount Type:";
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName_TextBox.Location = new System.Drawing.Point(434, 66);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.ReadOnly = true;
            this.FirstName_TextBox.Size = new System.Drawing.Size(211, 26);
            this.FirstName_TextBox.TabIndex = 47;
            this.FirstName_TextBox.TabStop = false;
            // 
            // SecondName_TextBox
            // 
            this.SecondName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondName_TextBox.Location = new System.Drawing.Point(665, 66);
            this.SecondName_TextBox.Name = "SecondName_TextBox";
            this.SecondName_TextBox.ReadOnly = true;
            this.SecondName_TextBox.Size = new System.Drawing.Size(211, 26);
            this.SecondName_TextBox.TabIndex = 49;
            this.SecondName_TextBox.TabStop = false;
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName_TextBox.Location = new System.Drawing.Point(195, 66);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.ReadOnly = true;
            this.LastName_TextBox.Size = new System.Drawing.Size(211, 26);
            this.LastName_TextBox.TabIndex = 51;
            this.LastName_TextBox.TabStop = false;
            // 
            // clientId_TextBox
            // 
            this.clientId_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientId_TextBox.Location = new System.Drawing.Point(96, 66);
            this.clientId_TextBox.Name = "clientId_TextBox";
            this.clientId_TextBox.ReadOnly = true;
            this.clientId_TextBox.Size = new System.Drawing.Size(68, 26);
            this.clientId_TextBox.TabIndex = 45;
            this.clientId_TextBox.TabStop = false;
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(443, 12);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 43;
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
            this.Accept_button.Location = new System.Drawing.Point(806, 12);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 42;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(642, 16);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(67, 26);
            this.Header_label.TabIndex = 41;
            this.Header_label.Text = "Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.discountType_comboBox);
            this.groupBox1.Controls.Add(this.Discount_maskedTextBox);
            this.groupBox1.Controls.Add(this.clientId_TextBox);
            this.groupBox1.Controls.Add(discount___Label);
            this.groupBox1.Controls.Add(client_idLabel);
            this.groupBox1.Controls.Add(this.LastName_TextBox);
            this.groupBox1.Controls.Add(discountType_idLabel);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.SecondName_TextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(secondNameLabel);
            this.groupBox1.Controls.Add(this.FirstName_TextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(35, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 153);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Data";
            // 
            // discountType_comboBox
            // 
            this.discountType_comboBox.DataSource = this.discountTypeBindingSource;
            this.discountType_comboBox.DisplayMember = "DiscountTypeName";
            this.discountType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discountType_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountType_comboBox.FormattingEnabled = true;
            this.discountType_comboBox.Location = new System.Drawing.Point(535, 108);
            this.discountType_comboBox.Name = "discountType_comboBox";
            this.discountType_comboBox.Size = new System.Drawing.Size(287, 28);
            this.discountType_comboBox.TabIndex = 57;
            this.discountType_comboBox.TabStop = false;
            this.discountType_comboBox.ValueMember = "discountType_id";
            // 
            // discountTypeBindingSource
            // 
            this.discountTypeBindingSource.DataMember = "DiscountType";
            this.discountTypeBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Discount_maskedTextBox
            // 
            this.Discount_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount_maskedTextBox.Location = new System.Drawing.Point(268, 108);
            this.Discount_maskedTextBox.Mask = "09";
            this.Discount_maskedTextBox.Name = "Discount_maskedTextBox";
            this.Discount_maskedTextBox.Size = new System.Drawing.Size(82, 26);
            this.Discount_maskedTextBox.TabIndex = 56;
            this.Discount_maskedTextBox.TabStop = false;
            this.Discount_maskedTextBox.TextChanged += new System.EventHandler(this.Discount_maskedTextBox_TextChanged);
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
            // Rents_dataGridView
            // 
            this.Rents_dataGridView.AllowUserToAddRows = false;
            this.Rents_dataGridView.AllowUserToDeleteRows = false;
            this.Rents_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Rents_dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Rents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rents_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rent_id,
            this.ModelType,
            this.Producer,
            this.Brand,
            this.Model,
            this.From,
            this.To,
            this.ProductPrice,
            this.Deposit});
            this.Rents_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.Rents_dataGridView.Location = new System.Drawing.Point(27, 47);
            this.Rents_dataGridView.MultiSelect = false;
            this.Rents_dataGridView.Name = "Rents_dataGridView";
            this.Rents_dataGridView.ReadOnly = true;
            this.Rents_dataGridView.RowHeadersWidth = 51;
            this.Rents_dataGridView.RowTemplate.Height = 24;
            this.Rents_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Rents_dataGridView.Size = new System.Drawing.Size(1239, 178);
            this.Rents_dataGridView.TabIndex = 59;
            this.Rents_dataGridView.TabStop = false;
            this.Rents_dataGridView.SelectionChanged += new System.EventHandler(this.Rents_dataGridView_SelectionChanged);
            // 
            // rent_id
            // 
            this.rent_id.DataPropertyName = "rent_id";
            this.rent_id.HeaderText = "rent_id";
            this.rent_id.MinimumWidth = 6;
            this.rent_id.Name = "rent_id";
            this.rent_id.ReadOnly = true;
            // 
            // ModelType
            // 
            this.ModelType.DataPropertyName = "ModelTypeName";
            this.ModelType.HeaderText = "Model Type";
            this.ModelType.MinimumWidth = 6;
            this.ModelType.Name = "ModelType";
            this.ModelType.ReadOnly = true;
            this.ModelType.Width = 145;
            // 
            // Producer
            // 
            this.Producer.DataPropertyName = "ProducerName";
            this.Producer.HeaderText = "Producer";
            this.Producer.MinimumWidth = 6;
            this.Producer.Name = "Producer";
            this.Producer.ReadOnly = true;
            this.Producer.Width = 120;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "BrandName";
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 93;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "ModelName";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 95;
            // 
            // From
            // 
            this.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.From.DataPropertyName = "From(date)";
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 6;
            this.From.Name = "From";
            this.From.ReadOnly = true;
            this.From.Width = 86;
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.To.DataPropertyName = "To(date)";
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 6;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Width = 65;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "TotalPrice(UAH)";
            this.ProductPrice.HeaderText = "Price (UAH)";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 146;
            // 
            // Deposit
            // 
            this.Deposit.DataPropertyName = "Deposit";
            this.Deposit.HeaderText = "Deposit (UAH)";
            this.Deposit.MinimumWidth = 6;
            this.Deposit.Name = "Deposit";
            this.Deposit.ReadOnly = true;
            this.Deposit.Width = 168;
            // 
            // GridControls_groupBox
            // 
            this.GridControls_groupBox.Controls.Add(this.Edit_button);
            this.GridControls_groupBox.Controls.Add(this.Add_button);
            this.GridControls_groupBox.Controls.Add(this.Delete_button);
            this.GridControls_groupBox.Location = new System.Drawing.Point(350, 231);
            this.GridControls_groupBox.Name = "GridControls_groupBox";
            this.GridControls_groupBox.Size = new System.Drawing.Size(611, 57);
            this.GridControls_groupBox.TabIndex = 71;
            this.GridControls_groupBox.TabStop = false;
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(212, 17);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(190, 34);
            this.Edit_button.TabIndex = 70;
            this.Edit_button.TabStop = false;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
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
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(409, 17);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(190, 34);
            this.Delete_button.TabIndex = 69;
            this.Delete_button.TabStop = false;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Rents_groupBox
            // 
            this.Rents_groupBox.Controls.Add(this.Rents_dataGridView);
            this.Rents_groupBox.Controls.Add(this.GridControls_groupBox);
            this.Rents_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rents_groupBox.Location = new System.Drawing.Point(35, 215);
            this.Rents_groupBox.Name = "Rents_groupBox";
            this.Rents_groupBox.Size = new System.Drawing.Size(1297, 298);
            this.Rents_groupBox.TabIndex = 72;
            this.Rents_groupBox.TabStop = false;
            this.Rents_groupBox.Text = "Rents";
            // 
            // AddAtt_button
            // 
            this.AddAtt_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddAtt_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddAtt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAtt_button.Location = new System.Drawing.Point(16, 17);
            this.AddAtt_button.Name = "AddAtt_button";
            this.AddAtt_button.Size = new System.Drawing.Size(198, 34);
            this.AddAtt_button.TabIndex = 67;
            this.AddAtt_button.TabStop = false;
            this.AddAtt_button.Text = "Add";
            this.AddAtt_button.UseVisualStyleBackColor = false;
            this.AddAtt_button.Click += new System.EventHandler(this.AddAttachment_button_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
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
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // Attachments_groupBox
            // 
            this.Attachments_groupBox.Controls.Add(this.Attachments_dataGridView);
            this.Attachments_groupBox.Controls.Add(this.groupBox3);
            this.Attachments_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attachments_groupBox.Location = new System.Drawing.Point(35, 519);
            this.Attachments_groupBox.Name = "Attachments_groupBox";
            this.Attachments_groupBox.Size = new System.Drawing.Size(1297, 298);
            this.Attachments_groupBox.TabIndex = 73;
            this.Attachments_groupBox.TabStop = false;
            this.Attachments_groupBox.Text = "Attachments";
            // 
            // Attachments_dataGridView
            // 
            this.Attachments_dataGridView.AllowUserToAddRows = false;
            this.Attachments_dataGridView.AllowUserToDeleteRows = false;
            this.Attachments_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Attachments_dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Attachments_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Attachments_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachmentId_at,
            this.ModelType_at,
            this.Producer_at,
            this.Brand_at,
            this.Model_at,
            this.Amount_at,
            this.Price_at});
            this.Attachments_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.Attachments_dataGridView.Location = new System.Drawing.Point(27, 47);
            this.Attachments_dataGridView.MultiSelect = false;
            this.Attachments_dataGridView.Name = "Attachments_dataGridView";
            this.Attachments_dataGridView.ReadOnly = true;
            this.Attachments_dataGridView.RowHeadersWidth = 51;
            this.Attachments_dataGridView.RowTemplate.Height = 24;
            this.Attachments_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Attachments_dataGridView.Size = new System.Drawing.Size(1239, 178);
            this.Attachments_dataGridView.TabIndex = 59;
            this.Attachments_dataGridView.TabStop = false;
            // 
            // attachmentId_at
            // 
            this.attachmentId_at.DataPropertyName = "attachment_id";
            this.attachmentId_at.HeaderText = "attachment_id";
            this.attachmentId_at.MinimumWidth = 6;
            this.attachmentId_at.Name = "attachmentId_at";
            this.attachmentId_at.ReadOnly = true;
            this.attachmentId_at.Width = 163;
            // 
            // ModelType_at
            // 
            this.ModelType_at.DataPropertyName = "ModelTypeName";
            this.ModelType_at.HeaderText = "Model Type";
            this.ModelType_at.MinimumWidth = 6;
            this.ModelType_at.Name = "ModelType_at";
            this.ModelType_at.ReadOnly = true;
            this.ModelType_at.Width = 145;
            // 
            // Producer_at
            // 
            this.Producer_at.DataPropertyName = "ProducerName";
            this.Producer_at.HeaderText = "Producer";
            this.Producer_at.MinimumWidth = 6;
            this.Producer_at.Name = "Producer_at";
            this.Producer_at.ReadOnly = true;
            this.Producer_at.Width = 120;
            // 
            // Brand_at
            // 
            this.Brand_at.DataPropertyName = "BrandName";
            this.Brand_at.HeaderText = "Brand";
            this.Brand_at.MinimumWidth = 6;
            this.Brand_at.Name = "Brand_at";
            this.Brand_at.ReadOnly = true;
            this.Brand_at.Width = 93;
            // 
            // Model_at
            // 
            this.Model_at.DataPropertyName = "ModelName";
            this.Model_at.HeaderText = "Model";
            this.Model_at.MinimumWidth = 6;
            this.Model_at.Name = "Model_at";
            this.Model_at.ReadOnly = true;
            this.Model_at.Width = 95;
            // 
            // Amount_at
            // 
            this.Amount_at.DataPropertyName = "Amount";
            this.Amount_at.HeaderText = "Amount";
            this.Amount_at.MinimumWidth = 6;
            this.Amount_at.Name = "Amount_at";
            this.Amount_at.ReadOnly = true;
            this.Amount_at.Width = 109;
            // 
            // Price_at
            // 
            this.Price_at.DataPropertyName = "TotalPrice(UAH)";
            this.Price_at.HeaderText = "Price (UAH)";
            this.Price_at.MinimumWidth = 6;
            this.Price_at.Name = "Price_at";
            this.Price_at.ReadOnly = true;
            this.Price_at.Width = 146;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EditAtt_button);
            this.groupBox3.Controls.Add(this.AddAtt_button);
            this.groupBox3.Controls.Add(this.DeleteAtt_button);
            this.groupBox3.Location = new System.Drawing.Point(350, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 57);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            // 
            // EditAtt_button
            // 
            this.EditAtt_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditAtt_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.EditAtt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditAtt_button.Location = new System.Drawing.Point(224, 17);
            this.EditAtt_button.Name = "EditAtt_button";
            this.EditAtt_button.Size = new System.Drawing.Size(190, 34);
            this.EditAtt_button.TabIndex = 70;
            this.EditAtt_button.TabStop = false;
            this.EditAtt_button.Text = "Edit";
            this.EditAtt_button.UseVisualStyleBackColor = false;
            this.EditAtt_button.Click += new System.EventHandler(this.EditAtt_button_Click);
            // 
            // DeleteAtt_button
            // 
            this.DeleteAtt_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteAtt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAtt_button.Location = new System.Drawing.Point(421, 17);
            this.DeleteAtt_button.Name = "DeleteAtt_button";
            this.DeleteAtt_button.Size = new System.Drawing.Size(190, 34);
            this.DeleteAtt_button.TabIndex = 69;
            this.DeleteAtt_button.TabStop = false;
            this.DeleteAtt_button.Text = "Delete";
            this.DeleteAtt_button.UseVisualStyleBackColor = false;
            this.DeleteAtt_button.Click += new System.EventHandler(this.DeleteAtt_button_Click);
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
            // attachmentBindingSource
            // 
            this.attachmentBindingSource.DataMember = "Attachment";
            this.attachmentBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // attachmentTableAdapter
            // 
            this.attachmentTableAdapter.ClearBeforeFill = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Deposit_textBox);
            this.groupBox2.Controls.Add(this.Price_textBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(948, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 153);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // Deposit_textBox
            // 
            this.Deposit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deposit_textBox.Location = new System.Drawing.Point(152, 86);
            this.Deposit_textBox.Name = "Deposit_textBox";
            this.Deposit_textBox.ReadOnly = true;
            this.Deposit_textBox.Size = new System.Drawing.Size(183, 26);
            this.Deposit_textBox.TabIndex = 59;
            this.Deposit_textBox.TabStop = false;
            this.Deposit_textBox.Text = "0";
            // 
            // Price_textBox
            // 
            this.Price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_textBox.Location = new System.Drawing.Point(152, 45);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.ReadOnly = true;
            this.Price_textBox.Size = new System.Drawing.Size(183, 26);
            this.Price_textBox.TabIndex = 58;
            this.Price_textBox.TabStop = false;
            this.Price_textBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deposit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1450, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Attachments_groupBox);
            this.Controls.Add(this.Rents_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order_Form";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rents_dataGridView)).EndInit();
            this.GridControls_groupBox.ResumeLayout(false);
            this.Rents_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.Attachments_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Attachments_dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.TextBox SecondName_TextBox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.TextBox clientId_TextBox;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox Discount_maskedTextBox;
        private System.Windows.Forms.ComboBox discountType_comboBox;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource discountTypeBindingSource;
        private RentalPointDataSetTableAdapters.DiscountTypeTableAdapter discountTypeTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView Rents_dataGridView;
        private System.Windows.Forms.GroupBox GridControls_groupBox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.GroupBox Rents_groupBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentalPointDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private RentalPointDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private RentalPointDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.GroupBox Attachments_groupBox;
        private System.Windows.Forms.DataGridView Attachments_dataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button EditAtt_button;
        private System.Windows.Forms.Button AddAtt_button;
        private System.Windows.Forms.Button DeleteAtt_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachmentId_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelType_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_at;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private RentalPointDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.BindingSource attachmentBindingSource;
        private RentalPointDataSetTableAdapters.AttachmentTableAdapter attachmentTableAdapter;
        private System.Windows.Forms.BindingSource setBindingSource;
        private RentalPointDataSetTableAdapters.SetTableAdapter setTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Deposit_textBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}