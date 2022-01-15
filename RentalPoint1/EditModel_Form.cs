using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPoint1
{
    public partial class EditModel_Form : Form
    {
        private void modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentalPointDataSet);

        }
        private int id;
        private bool IsEdit;
        public EditModel_Form()
        {
            InitializeComponent();
            id = Convert.ToInt32(modelTableAdapter.TheLastID()) + 1;
            this.ModelId_textBox.Text = id.ToString();
            IsEdit = false;
            // TODO: This line of code loads data into the 'rentalPointDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.rentalPointDataSet.Brand);
            // TODO: This line of code loads data into the 'rentalPointDataSet.ModelType' table. You can move, or remove it, as needed.
            this.modelTypeTableAdapter.Fill(this.rentalPointDataSet.ModelType);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.rentalPointDataSet.Model);
            //rentalPointDataSet.Model.model_idColumn.AutoIncrement = true;
            //rentalPointDataSet.Model.model_idColumn.AutoIncrementStep = 1;
            //rentalPointDataSet.Model.model_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(modelTableAdapter.TheLastID());
        }
        public EditModel_Form(int model_id) : this()
        {
            id = model_id;
            var row = modelTableAdapter.WhereId(id)[0].ItemArray;
            IsEdit = true;
            this.ModelId_textBox.Text = id.ToString();
            this.BrandId_comboBox.SelectedValue = row[1];
            this.ModelTypeId_comboBox.SelectedValue = row[2];
            this.ModelName_textBox.Text = row[3].ToString();
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            //var m = MessageBox.Show("Do you want to save changes?", "Saving changes", MessageBoxButtons.YesNoCancel);
            //if (m == DialogResult.Yes)
            //{
                if (IsEdit)
                    modelTableAdapter.UpdateQuery(
                        Convert.ToInt32(BrandId_comboBox.SelectedValue), 
                        Convert.ToInt32(ModelTypeId_comboBox.SelectedValue), 
                        ModelName_textBox.Text, 
                        id);
                else
                    modelTableAdapter.Insert(id,
                        Convert.ToInt32(BrandId_comboBox.SelectedValue),
                        Convert.ToInt32(ModelTypeId_comboBox.SelectedValue), 
                        ModelName_textBox.Text);
            //}
            //else if (m == DialogResult.No)
            //    return;
            //else if (m == DialogResult.Cancel)
            //    this.DialogResult = DialogResult.None;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Do you want to cancel all changes and leave?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    return;
            //else
            //    this.DialogResult = DialogResult.None;
        }
    }
}
