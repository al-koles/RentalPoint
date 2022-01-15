namespace RentalPoint1
{
    partial class Return_Form
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
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label secondNameLabel;
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.Attachments_groupBox = new System.Windows.Forms.GroupBox();
            this.SelectAmount_button = new System.Windows.Forms.Button();
            this.ReturnAmount_listBox = new System.Windows.Forms.ListBox();
            this.ReturnAmount_label = new System.Windows.Forms.Label();
            this.Attachments_dataGridView = new System.Windows.Forms.DataGridView();
            this.attachmentId_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelType_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rents_groupBox = new System.Windows.Forms.GroupBox();
            this.Condition_button = new System.Windows.Forms.Button();
            this.Rents_dataGridView = new System.Windows.Forms.DataGridView();
            this.rentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnCondition = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientId_TextBox = new System.Windows.Forms.TextBox();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.SecondName_TextBox = new System.Windows.Forms.TextBox();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.RentTableAdapter();
            this.attachmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attachmentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.AttachmentTableAdapter();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DetailTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            client_idLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            secondNameLabel = new System.Windows.Forms.Label();
            this.Attachments_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Attachments_dataGridView)).BeginInit();
            this.Rents_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rents_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_idLabel.Location = new System.Drawing.Point(36, 30);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(72, 20);
            client_idLabel.TabIndex = 44;
            client_idLabel.Text = "client id:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(135, 30);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(96, 20);
            lastNameLabel.TabIndex = 50;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(374, 30);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(97, 20);
            firstNameLabel.TabIndex = 46;
            firstNameLabel.Text = "First Name:";
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            secondNameLabel.Location = new System.Drawing.Point(605, 30);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new System.Drawing.Size(119, 20);
            secondNameLabel.TabIndex = 48;
            secondNameLabel.Text = "Second Name:";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(451, 12);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 32;
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
            this.Accept_button.Location = new System.Drawing.Point(814, 12);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 31;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(650, 16);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(77, 26);
            this.Header_label.TabIndex = 30;
            this.Header_label.Text = "Return";
            // 
            // Attachments_groupBox
            // 
            this.Attachments_groupBox.Controls.Add(this.SelectAmount_button);
            this.Attachments_groupBox.Controls.Add(this.ReturnAmount_listBox);
            this.Attachments_groupBox.Controls.Add(this.ReturnAmount_label);
            this.Attachments_groupBox.Controls.Add(this.Attachments_dataGridView);
            this.Attachments_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attachments_groupBox.Location = new System.Drawing.Point(43, 425);
            this.Attachments_groupBox.Name = "Attachments_groupBox";
            this.Attachments_groupBox.Size = new System.Drawing.Size(1297, 264);
            this.Attachments_groupBox.TabIndex = 75;
            this.Attachments_groupBox.TabStop = false;
            this.Attachments_groupBox.Text = "Attachments";
            // 
            // SelectAmount_button
            // 
            this.SelectAmount_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectAmount_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SelectAmount_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectAmount_button.Location = new System.Drawing.Point(1121, 219);
            this.SelectAmount_button.Name = "SelectAmount_button";
            this.SelectAmount_button.Size = new System.Drawing.Size(145, 34);
            this.SelectAmount_button.TabIndex = 71;
            this.SelectAmount_button.TabStop = false;
            this.SelectAmount_button.Text = "Select";
            this.SelectAmount_button.UseVisualStyleBackColor = false;
            this.SelectAmount_button.Click += new System.EventHandler(this.SelectAmount_button_Click);
            // 
            // ReturnAmount_listBox
            // 
            this.ReturnAmount_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnAmount_listBox.FormattingEnabled = true;
            this.ReturnAmount_listBox.ItemHeight = 20;
            this.ReturnAmount_listBox.Location = new System.Drawing.Point(1121, 29);
            this.ReturnAmount_listBox.Name = "ReturnAmount_listBox";
            this.ReturnAmount_listBox.Size = new System.Drawing.Size(145, 184);
            this.ReturnAmount_listBox.TabIndex = 145;
            this.ReturnAmount_listBox.TabStop = false;
            // 
            // ReturnAmount_label
            // 
            this.ReturnAmount_label.AutoSize = true;
            this.ReturnAmount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnAmount_label.Location = new System.Drawing.Point(1117, 0);
            this.ReturnAmount_label.Name = "ReturnAmount_label";
            this.ReturnAmount_label.Size = new System.Drawing.Size(137, 24);
            this.ReturnAmount_label.TabIndex = 144;
            this.ReturnAmount_label.Text = "Return Amount";
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
            this.ReturnAmount,
            this.ReturnPrice});
            this.Attachments_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.Attachments_dataGridView.Location = new System.Drawing.Point(27, 29);
            this.Attachments_dataGridView.MultiSelect = false;
            this.Attachments_dataGridView.Name = "Attachments_dataGridView";
            this.Attachments_dataGridView.ReadOnly = true;
            this.Attachments_dataGridView.RowHeadersWidth = 51;
            this.Attachments_dataGridView.RowTemplate.Height = 24;
            this.Attachments_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Attachments_dataGridView.Size = new System.Drawing.Size(1088, 184);
            this.Attachments_dataGridView.TabIndex = 59;
            this.Attachments_dataGridView.TabStop = false;
            this.Attachments_dataGridView.SelectionChanged += new System.EventHandler(this.Attachments_dataGridView_SelectionChanged);
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
            this.ModelType_at.Width = 133;
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
            // ReturnAmount
            // 
            this.ReturnAmount.DataPropertyName = "ReturnAmount";
            this.ReturnAmount.HeaderText = "ReturnAmount";
            this.ReturnAmount.MinimumWidth = 6;
            this.ReturnAmount.Name = "ReturnAmount";
            this.ReturnAmount.ReadOnly = true;
            this.ReturnAmount.Width = 166;
            // 
            // ReturnPrice
            // 
            this.ReturnPrice.DataPropertyName = "ReturnPrice";
            this.ReturnPrice.HeaderText = "Return Price (UAH)";
            this.ReturnPrice.MinimumWidth = 6;
            this.ReturnPrice.Name = "ReturnPrice";
            this.ReturnPrice.ReadOnly = true;
            this.ReturnPrice.Width = 190;
            // 
            // Rents_groupBox
            // 
            this.Rents_groupBox.Controls.Add(this.Condition_button);
            this.Rents_groupBox.Controls.Add(this.Rents_dataGridView);
            this.Rents_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rents_groupBox.Location = new System.Drawing.Point(43, 156);
            this.Rents_groupBox.Name = "Rents_groupBox";
            this.Rents_groupBox.Size = new System.Drawing.Size(1297, 263);
            this.Rents_groupBox.TabIndex = 74;
            this.Rents_groupBox.TabStop = false;
            this.Rents_groupBox.Text = "Rents";
            // 
            // Condition_button
            // 
            this.Condition_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Condition_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Condition_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Condition_button.Location = new System.Drawing.Point(521, 213);
            this.Condition_button.Name = "Condition_button";
            this.Condition_button.Size = new System.Drawing.Size(243, 34);
            this.Condition_button.TabIndex = 68;
            this.Condition_button.TabStop = false;
            this.Condition_button.Text = "Change Condition";
            this.Condition_button.UseVisualStyleBackColor = false;
            this.Condition_button.Click += new System.EventHandler(this.Condition_button_Click);
            // 
            // Rents_dataGridView
            // 
            this.Rents_dataGridView.AllowUserToAddRows = false;
            this.Rents_dataGridView.AllowUserToDeleteRows = false;
            this.Rents_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Rents_dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Rents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rents_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentId,
            this.ModelType,
            this.Producer,
            this.Brand,
            this.Model,
            this.To,
            this.Deposit,
            this.ReturnCondition,
            this.Penalty});
            this.Rents_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.Rents_dataGridView.Location = new System.Drawing.Point(27, 29);
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
            // rentId
            // 
            this.rentId.DataPropertyName = "rent_id";
            this.rentId.HeaderText = "rent_id";
            this.rentId.MinimumWidth = 6;
            this.rentId.Name = "rentId";
            this.rentId.ReadOnly = true;
            // 
            // ModelType
            // 
            this.ModelType.DataPropertyName = "ModelTypeName";
            this.ModelType.HeaderText = "Model Type";
            this.ModelType.MinimumWidth = 6;
            this.ModelType.Name = "ModelType";
            this.ModelType.ReadOnly = true;
            this.ModelType.Width = 133;
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
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.To.DataPropertyName = "To(date)";
            this.To.HeaderText = "To (Date)";
            this.To.MinimumWidth = 6;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Width = 115;
            // 
            // Deposit
            // 
            this.Deposit.DataPropertyName = "Deposit";
            this.Deposit.HeaderText = "Deposit (UAH)";
            this.Deposit.MinimumWidth = 6;
            this.Deposit.Name = "Deposit";
            this.Deposit.ReadOnly = true;
            this.Deposit.Width = 154;
            // 
            // ReturnCondition
            // 
            this.ReturnCondition.DataPropertyName = "ReturnCondition";
            this.ReturnCondition.HeaderText = "Return Condition";
            this.ReturnCondition.MinimumWidth = 6;
            this.ReturnCondition.Name = "ReturnCondition";
            this.ReturnCondition.ReadOnly = true;
            this.ReturnCondition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnCondition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReturnCondition.Width = 170;
            // 
            // Penalty
            // 
            this.Penalty.DataPropertyName = "Penalty";
            this.Penalty.HeaderText = "Penalty (UAH)";
            this.Penalty.MinimumWidth = 6;
            this.Penalty.Name = "Penalty";
            this.Penalty.ReadOnly = true;
            this.Penalty.Width = 153;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientId_TextBox);
            this.groupBox1.Controls.Add(client_idLabel);
            this.groupBox1.Controls.Add(this.LastName_TextBox);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.SecondName_TextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(secondNameLabel);
            this.groupBox1.Controls.Add(this.FirstName_TextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(43, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 90);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Data";
            // 
            // clientId_TextBox
            // 
            this.clientId_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientId_TextBox.Location = new System.Drawing.Point(40, 53);
            this.clientId_TextBox.Name = "clientId_TextBox";
            this.clientId_TextBox.ReadOnly = true;
            this.clientId_TextBox.Size = new System.Drawing.Size(68, 26);
            this.clientId_TextBox.TabIndex = 45;
            this.clientId_TextBox.TabStop = false;
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName_TextBox.Location = new System.Drawing.Point(139, 53);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.ReadOnly = true;
            this.LastName_TextBox.Size = new System.Drawing.Size(211, 26);
            this.LastName_TextBox.TabIndex = 51;
            this.LastName_TextBox.TabStop = false;
            // 
            // SecondName_TextBox
            // 
            this.SecondName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondName_TextBox.Location = new System.Drawing.Point(609, 53);
            this.SecondName_TextBox.Name = "SecondName_TextBox";
            this.SecondName_TextBox.ReadOnly = true;
            this.SecondName_TextBox.Size = new System.Drawing.Size(211, 26);
            this.SecondName_TextBox.TabIndex = 49;
            this.SecondName_TextBox.TabStop = false;
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName_TextBox.Location = new System.Drawing.Point(378, 53);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.ReadOnly = true;
            this.FirstName_TextBox.Size = new System.Drawing.Size(211, 26);
            this.FirstName_TextBox.TabIndex = 47;
            this.FirstName_TextBox.TabStop = false;
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
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
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "Rent";
            this.rentBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
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
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Price_textBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(956, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 90);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // Price_textBox
            // 
            this.Price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_textBox.Location = new System.Drawing.Point(94, 49);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.ReadOnly = true;
            this.Price_textBox.Size = new System.Drawing.Size(183, 26);
            this.Price_textBox.TabIndex = 58;
            this.Price_textBox.TabStop = false;
            this.Price_textBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // Return_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 735);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Attachments_groupBox);
            this.Controls.Add(this.Rents_groupBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Return_Form";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.Attachments_groupBox.ResumeLayout(false);
            this.Attachments_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Attachments_dataGridView)).EndInit();
            this.Rents_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rents_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentalPointDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox Attachments_groupBox;
        private System.Windows.Forms.DataGridView Attachments_dataGridView;
        private System.Windows.Forms.GroupBox Rents_groupBox;
        private System.Windows.Forms.DataGridView Rents_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clientId_TextBox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.TextBox SecondName_TextBox;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private RentalPointDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReturnCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalty;
        private System.Windows.Forms.Button Condition_button;
        private System.Windows.Forms.ListBox ReturnAmount_listBox;
        private System.Windows.Forms.Label ReturnAmount_label;
        private System.Windows.Forms.Button SelectAmount_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachmentId_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelType_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnPrice;
        private System.Windows.Forms.BindingSource attachmentBindingSource;
        private RentalPointDataSetTableAdapters.AttachmentTableAdapter attachmentTableAdapter;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private RentalPointDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Label label1;
    }
}