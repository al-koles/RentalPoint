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
    public partial class EditModelType_Form : Form
    {
        private int id;
        private bool IsEdit;
        public EditModelType_Form()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'rentalPointDataSet.ModelType' table. You can move, or remove it, as needed.
            this.modelTypeTableAdapter.Fill(this.rentalPointDataSet.ModelType);
            id = Convert.ToInt32(modelTypeTableAdapter.TheLastID()) + 1;
            this.ModelTypeID_textBox.Text = id.ToString();
            IsEdit = false;
        }
        public EditModelType_Form(int id) : this()
        {
            var rows = modelTypeTableAdapter.WhereId(id);
            var row = rows[0].ItemArray;
            IsEdit = true;
            this.id = id;
            this.ModelTypeID_textBox.Text = id.ToString();
            this.ModelTypeName_textBox.Text = row[1].ToString();
        }
        private void Accept_button_Click(object sender, EventArgs e)
        {
            //var m = MessageBox.Show("Do you want to save changes?", "Saving changes", MessageBoxButtons.YesNoCancel);
            //if (m == DialogResult.Yes)
            //{
                if (IsEdit)
                {
                    try
                    {
                        modelTypeTableAdapter.UpdateQuery(id, ModelTypeName_textBox.Text, id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    try
                    {
                        modelTypeTableAdapter.Insert(id, ModelTypeName_textBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.DialogResult = DialogResult.None;
                    }
                }
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

        private void modelTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modelTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentalPointDataSet);

        }

        private void EditModelTypeForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
