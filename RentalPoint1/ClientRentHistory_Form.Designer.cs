namespace RentalPoint1
{
    partial class ClientRentHistory_Form
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.rentTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.RentTableAdapter();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Return_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientId_TextBox = new System.Windows.Forms.TextBox();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.SecondName_TextBox = new System.Windows.Forms.TextBox();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.ActiveRents_groupBox = new System.Windows.Forms.GroupBox();
            this.ActiveRents_dataGridView = new System.Windows.Forms.DataGridView();
            this.InactiveRents_groupBox = new System.Windows.Forms.GroupBox();
            this.rentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InactiveRents_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ActiveRents_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveRents_dataGridView)).BeginInit();
            this.InactiveRents_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InactiveRents_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(36, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 20);
            label1.TabIndex = 44;
            label1.Text = "client id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(135, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 50;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(374, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 20);
            label3.TabIndex = 46;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(605, 30);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 20);
            label4.TabIndex = 48;
            label4.Text = "Second Name:";
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
            this.tableAdapterManager.RentTableAdapter = this.rentTableAdapter;
            this.tableAdapterManager.SetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "Rent";
            this.rentBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // Return_button
            // 
            this.Return_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Return_button.Location = new System.Drawing.Point(511, 262);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(264, 48);
            this.Return_button.TabIndex = 69;
            this.Return_button.TabStop = false;
            this.Return_button.Text = "Arrange a return";
            this.Return_button.UseVisualStyleBackColor = false;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(579, 24);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(194, 26);
            this.Header_label.TabIndex = 70;
            this.Header_label.Text = "Client Rent History";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientId_TextBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.LastName_TextBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.SecondName_TextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.FirstName_TextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(228, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 90);
            this.groupBox1.TabIndex = 77;
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
            // ActiveRents_groupBox
            // 
            this.ActiveRents_groupBox.Controls.Add(this.ActiveRents_dataGridView);
            this.ActiveRents_groupBox.Controls.Add(this.Return_button);
            this.ActiveRents_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveRents_groupBox.Location = new System.Drawing.Point(22, 168);
            this.ActiveRents_groupBox.Name = "ActiveRents_groupBox";
            this.ActiveRents_groupBox.Size = new System.Drawing.Size(1297, 323);
            this.ActiveRents_groupBox.TabIndex = 78;
            this.ActiveRents_groupBox.TabStop = false;
            this.ActiveRents_groupBox.Text = "Active Rents";
            // 
            // ActiveRents_dataGridView
            // 
            this.ActiveRents_dataGridView.AllowUserToAddRows = false;
            this.ActiveRents_dataGridView.AllowUserToDeleteRows = false;
            this.ActiveRents_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ActiveRents_dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActiveRents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveRents_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentId,
            this.ModelType,
            this.Producer,
            this.Brand,
            this.Model,
            this.From,
            this.To,
            this.Price,
            this.Deposit});
            this.ActiveRents_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.ActiveRents_dataGridView.Location = new System.Drawing.Point(28, 41);
            this.ActiveRents_dataGridView.Name = "ActiveRents_dataGridView";
            this.ActiveRents_dataGridView.ReadOnly = true;
            this.ActiveRents_dataGridView.RowHeadersWidth = 51;
            this.ActiveRents_dataGridView.RowTemplate.Height = 24;
            this.ActiveRents_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActiveRents_dataGridView.Size = new System.Drawing.Size(1239, 204);
            this.ActiveRents_dataGridView.TabIndex = 59;
            this.ActiveRents_dataGridView.TabStop = false;
            // 
            // InactiveRents_groupBox
            // 
            this.InactiveRents_groupBox.Controls.Add(this.InactiveRents_dataGridView);
            this.InactiveRents_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InactiveRents_groupBox.Location = new System.Drawing.Point(22, 497);
            this.InactiveRents_groupBox.Name = "InactiveRents_groupBox";
            this.InactiveRents_groupBox.Size = new System.Drawing.Size(1297, 270);
            this.InactiveRents_groupBox.TabIndex = 79;
            this.InactiveRents_groupBox.TabStop = false;
            this.InactiveRents_groupBox.Text = "Inactive Rents";
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
            // Price
            // 
            this.Price.DataPropertyName = "TotalPrice(UAH)";
            this.Price.HeaderText = "Price (UAH)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 146;
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
            // InactiveRents_dataGridView
            // 
            this.InactiveRents_dataGridView.AllowUserToAddRows = false;
            this.InactiveRents_dataGridView.AllowUserToDeleteRows = false;
            this.InactiveRents_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InactiveRents_dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.InactiveRents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InactiveRents_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.InactiveRents_dataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.InactiveRents_dataGridView.Location = new System.Drawing.Point(28, 39);
            this.InactiveRents_dataGridView.Name = "InactiveRents_dataGridView";
            this.InactiveRents_dataGridView.ReadOnly = true;
            this.InactiveRents_dataGridView.RowHeadersWidth = 51;
            this.InactiveRents_dataGridView.RowTemplate.Height = 24;
            this.InactiveRents_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InactiveRents_dataGridView.Size = new System.Drawing.Size(1239, 204);
            this.InactiveRents_dataGridView.TabIndex = 60;
            this.InactiveRents_dataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "rent_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "rent_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ModelTypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model Type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 145;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProducerName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Producer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BrandName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 93;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ModelName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Model";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 95;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "From(date)";
            this.dataGridViewTextBoxColumn6.HeaderText = "From";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 86;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "To(date)";
            this.dataGridViewTextBoxColumn7.HeaderText = "To";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 65;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TotalPrice(UAH)";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price (UAH)";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 146;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Deposit";
            this.dataGridViewTextBoxColumn9.HeaderText = "Deposit (UAH)";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 168;
            // 
            // ClientRentHistory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 812);
            this.Controls.Add(this.InactiveRents_groupBox);
            this.Controls.Add(this.ActiveRents_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Header_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientRentHistory_Form";
            this.Text = "Rent History";
            this.Load += new System.EventHandler(this.EditClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ActiveRents_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveRents_dataGridView)).EndInit();
            this.InactiveRents_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InactiveRents_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentalPointDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RentalPointDataSetTableAdapters.RentTableAdapter rentTableAdapter;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private System.Windows.Forms.Button Return_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clientId_TextBox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.TextBox SecondName_TextBox;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.GroupBox ActiveRents_groupBox;
        private System.Windows.Forms.DataGridView ActiveRents_dataGridView;
        private System.Windows.Forms.GroupBox InactiveRents_groupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.DataGridView InactiveRents_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}