namespace RentalPoint1
{
    partial class EditClient_Form
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
            System.Windows.Forms.Label discount___Label;
            System.Windows.Forms.Label discountType_idLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label secondNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label registrationDateLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.ClientID_textBox = new System.Windows.Forms.TextBox();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.SecondName_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.RegistrationDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Header_label = new System.Windows.Forms.Label();
            this.discountType_comboBox = new System.Windows.Forms.ComboBox();
            this.discountTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountTypeTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.DiscountTypeTableAdapter();
            this.PhoneNumber_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Discount_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PostCode_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            client_idLabel = new System.Windows.Forms.Label();
            discount___Label = new System.Windows.Forms.Label();
            discountType_idLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            secondNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            registrationDateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_idLabel.Location = new System.Drawing.Point(90, 87);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(72, 20);
            client_idLabel.TabIndex = 25;
            client_idLabel.Text = "client id:";
            // 
            // discount___Label
            // 
            discount___Label.AutoSize = true;
            discount___Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            discount___Label.Location = new System.Drawing.Point(90, 120);
            discount___Label.Name = "discount___Label";
            discount___Label.Size = new System.Drawing.Size(108, 20);
            discount___Label.TabIndex = 26;
            discount___Label.Text = "Discount(%):";
            // 
            // discountType_idLabel
            // 
            discountType_idLabel.AutoSize = true;
            discountType_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            discountType_idLabel.Location = new System.Drawing.Point(90, 156);
            discountType_idLabel.Name = "discountType_idLabel";
            discountType_idLabel.Size = new System.Drawing.Size(122, 20);
            discountType_idLabel.TabIndex = 27;
            discountType_idLabel.Text = "Discount Type:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(90, 222);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(97, 20);
            firstNameLabel.TabIndex = 28;
            firstNameLabel.Text = "First Name:";
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            secondNameLabel.Location = new System.Drawing.Point(90, 254);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new System.Drawing.Size(119, 20);
            secondNameLabel.TabIndex = 29;
            secondNameLabel.Text = "Second Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(90, 190);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(96, 20);
            lastNameLabel.TabIndex = 30;
            lastNameLabel.Text = "Last Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genderLabel.Location = new System.Drawing.Point(90, 286);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(69, 20);
            genderLabel.TabIndex = 31;
            genderLabel.Text = "Gender:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneNumberLabel.Location = new System.Drawing.Point(90, 323);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(125, 20);
            phoneNumberLabel.TabIndex = 32;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(90, 357);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 20);
            emailLabel.TabIndex = 33;
            emailLabel.Text = "Email:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(90, 392);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(76, 20);
            addressLabel.TabIndex = 34;
            addressLabel.Text = "Address:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postCodeLabel.Location = new System.Drawing.Point(90, 426);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(92, 20);
            postCodeLabel.TabIndex = 35;
            postCodeLabel.Text = "Post Code:";
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            registrationDateLabel.Location = new System.Drawing.Point(90, 459);
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new System.Drawing.Size(145, 20);
            registrationDateLabel.TabIndex = 36;
            registrationDateLabel.Text = "Registration Date:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(90, 489);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(100, 20);
            descriptionLabel.TabIndex = 37;
            descriptionLabel.Text = "Description:";
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
            // ClientID_textBox
            // 
            this.ClientID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientID_textBox.Location = new System.Drawing.Point(261, 84);
            this.ClientID_textBox.Name = "ClientID_textBox";
            this.ClientID_textBox.ReadOnly = true;
            this.ClientID_textBox.Size = new System.Drawing.Size(287, 26);
            this.ClientID_textBox.TabIndex = 1;
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName_textBox.Location = new System.Drawing.Point(261, 219);
            this.FirstName_textBox.MaxLength = 30;
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(287, 26);
            this.FirstName_textBox.TabIndex = 4;
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName_textBox.Location = new System.Drawing.Point(261, 187);
            this.LastName_textBox.MaxLength = 30;
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(287, 26);
            this.LastName_textBox.TabIndex = 6;
            // 
            // SecondName_textBox
            // 
            this.SecondName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondName_textBox.Location = new System.Drawing.Point(261, 251);
            this.SecondName_textBox.MaxLength = 30;
            this.SecondName_textBox.Name = "SecondName_textBox";
            this.SecondName_textBox.Size = new System.Drawing.Size(287, 26);
            this.SecondName_textBox.TabIndex = 5;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_textBox.Location = new System.Drawing.Point(261, 354);
            this.Email_textBox.MaxLength = 30;
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(287, 26);
            this.Email_textBox.TabIndex = 9;
            // 
            // Address_textBox
            // 
            this.Address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address_textBox.Location = new System.Drawing.Point(261, 389);
            this.Address_textBox.MaxLength = 50;
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(287, 26);
            this.Address_textBox.TabIndex = 10;
            // 
            // Description_textBox
            // 
            this.Description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_textBox.Location = new System.Drawing.Point(261, 489);
            this.Description_textBox.MaxLength = 100;
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(287, 52);
            this.Description_textBox.TabIndex = 13;
            // 
            // RegistrationDate_dateTimePicker
            // 
            this.RegistrationDate_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RegistrationDate_dateTimePicker.Location = new System.Drawing.Point(261, 457);
            this.RegistrationDate_dateTimePicker.MaxDate = new System.DateTime(2021, 1, 29, 0, 0, 0, 0);
            this.RegistrationDate_dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.RegistrationDate_dateTimePicker.Name = "RegistrationDate_dateTimePicker";
            this.RegistrationDate_dateTimePicker.Size = new System.Drawing.Size(287, 26);
            this.RegistrationDate_dateTimePicker.TabIndex = 12;
            this.RegistrationDate_dateTimePicker.Value = new System.DateTime(2020, 12, 26, 0, 0, 0, 0);
            // 
            // Gender_comboBox
            // 
            this.Gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender_comboBox.FormattingEnabled = true;
            this.Gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_comboBox.Location = new System.Drawing.Point(261, 283);
            this.Gender_comboBox.Name = "Gender_comboBox";
            this.Gender_comboBox.Size = new System.Drawing.Size(287, 28);
            this.Gender_comboBox.TabIndex = 7;
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(93, 24);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(105, 38);
            this.Cancel_button.TabIndex = 54;
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
            this.Accept_button.Location = new System.Drawing.Point(443, 24);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(105, 38);
            this.Accept_button.TabIndex = 53;
            this.Accept_button.TabStop = false;
            this.Accept_button.Text = "Accept";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Header_label
            // 
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.Location = new System.Drawing.Point(284, 28);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(68, 26);
            this.Header_label.TabIndex = 52;
            this.Header_label.Text = "Client";
            // 
            // discountType_comboBox
            // 
            this.discountType_comboBox.DataSource = this.discountTypeBindingSource;
            this.discountType_comboBox.DisplayMember = "DiscountTypeName";
            this.discountType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discountType_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountType_comboBox.FormattingEnabled = true;
            this.discountType_comboBox.Location = new System.Drawing.Point(261, 151);
            this.discountType_comboBox.Name = "discountType_comboBox";
            this.discountType_comboBox.Size = new System.Drawing.Size(287, 28);
            this.discountType_comboBox.TabIndex = 3;
            this.discountType_comboBox.ValueMember = "discountType_id";
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
            // PhoneNumber_maskedTextBox
            // 
            this.PhoneNumber_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumber_maskedTextBox.Location = new System.Drawing.Point(261, 320);
            this.PhoneNumber_maskedTextBox.Mask = "(999) 000-0000";
            this.PhoneNumber_maskedTextBox.Name = "PhoneNumber_maskedTextBox";
            this.PhoneNumber_maskedTextBox.Size = new System.Drawing.Size(287, 26);
            this.PhoneNumber_maskedTextBox.TabIndex = 8;
            // 
            // Discount_maskedTextBox
            // 
            this.Discount_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount_maskedTextBox.Location = new System.Drawing.Point(261, 117);
            this.Discount_maskedTextBox.Mask = "99";
            this.Discount_maskedTextBox.Name = "Discount_maskedTextBox";
            this.Discount_maskedTextBox.Size = new System.Drawing.Size(287, 26);
            this.Discount_maskedTextBox.TabIndex = 2;
            this.Discount_maskedTextBox.ValidatingType = typeof(int);
            // 
            // PostCode_maskedTextBox
            // 
            this.PostCode_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostCode_maskedTextBox.Location = new System.Drawing.Point(261, 423);
            this.PostCode_maskedTextBox.Mask = "00000";
            this.PostCode_maskedTextBox.Name = "PostCode_maskedTextBox";
            this.PostCode_maskedTextBox.Size = new System.Drawing.Size(287, 26);
            this.PostCode_maskedTextBox.TabIndex = 11;
            this.PostCode_maskedTextBox.ValidatingType = typeof(int);
            // 
            // EditClient_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 635);
            this.ControlBox = false;
            this.Controls.Add(this.PostCode_maskedTextBox);
            this.Controls.Add(this.Discount_maskedTextBox);
            this.Controls.Add(this.PhoneNumber_maskedTextBox);
            this.Controls.Add(this.discountType_comboBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Header_label);
            this.Controls.Add(this.Gender_comboBox);
            this.Controls.Add(this.RegistrationDate_dateTimePicker);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.SecondName_textBox);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.ClientID_textBox);
            this.Controls.Add(client_idLabel);
            this.Controls.Add(discount___Label);
            this.Controls.Add(discountType_idLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(secondNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(registrationDateLabel);
            this.Controls.Add(descriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClient_Form";
            this.Text = "Edit Client";
            this.Load += new System.EventHandler(this.EditClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentalPointDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ClientID_textBox;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.TextBox SecondName_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.DateTimePicker RegistrationDate_dateTimePicker;
        private System.Windows.Forms.ComboBox Gender_comboBox;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.ComboBox discountType_comboBox;
        private System.Windows.Forms.BindingSource discountTypeBindingSource;
        private RentalPointDataSetTableAdapters.DiscountTypeTableAdapter discountTypeTableAdapter;
        private System.Windows.Forms.MaskedTextBox PhoneNumber_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox Discount_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox PostCode_maskedTextBox;
    }
}