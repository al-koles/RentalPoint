namespace RentalPoint1
{
    partial class ReturnBill_Form
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
            this.Print_button = new System.Windows.Forms.Button();
            this.Total_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rentalPointDataSet = new RentalPoint1.RentalPointDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new RentalPoint1.RentalPointDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new RentalPoint1.RentalPointDataSetTableAdapters.TableAdapterManager();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Print_button
            // 
            this.Print_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Print_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Print_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Print_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print_button.Location = new System.Drawing.Point(125, 135);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(198, 34);
            this.Print_button.TabIndex = 75;
            this.Print_button.TabStop = false;
            this.Print_button.Text = "Print Bill";
            this.Print_button.UseVisualStyleBackColor = false;
            this.Print_button.Click += new System.EventHandler(this.Print_button_Click);
            // 
            // Total_textBox
            // 
            this.Total_textBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Total_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total_textBox.Location = new System.Drawing.Point(187, 67);
            this.Total_textBox.Name = "Total_textBox";
            this.Total_textBox.ReadOnly = true;
            this.Total_textBox.Size = new System.Drawing.Size(183, 26);
            this.Total_textBox.TabIndex = 74;
            this.Total_textBox.TabStop = false;
            this.Total_textBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "Total:";
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
            // ReturnBill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 233);
            this.Controls.Add(this.Print_button);
            this.Controls.Add(this.Total_textBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBill_Form";
            this.Text = "Return Bill";
            this.Load += new System.EventHandler(this.ReturnBill_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.TextBox Total_textBox;
        private System.Windows.Forms.Label label3;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentalPointDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private RentalPointDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}