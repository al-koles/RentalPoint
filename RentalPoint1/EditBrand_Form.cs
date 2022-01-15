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
    public partial class EditBrand_Form : Form
    {
        private int id;
        private bool IsEdit;
        public EditBrand_Form()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'rentalPointDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.rentalPointDataSet.Brand);
            id = Convert.ToInt32(brandTableAdapter.TheLastID()) + 1;
            this.BrandID_textBox.Text = id.ToString();
            IsEdit = false;
        }
        public EditBrand_Form(int id) : this()
        {
            var rows = brandTableAdapter.WhereId(id);
            var row = rows[0];
            IsEdit = true;
            this.id = id;
            this.BrandID_textBox.Text = id.ToString();
            this.BrandName_textBox.Text = row[1].ToString();
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
                        brandTableAdapter.UpdateQuery(id, BrandName_textBox.Text, id);
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
                        brandTableAdapter.Insert(id, BrandName_textBox.Text);
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

        private void EditBrandForm_Load(object sender, EventArgs e)
        {
            
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
