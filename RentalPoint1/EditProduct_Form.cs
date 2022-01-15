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
    public partial class EditProduct_Form : Form
    {
        private int id;
        private bool IsEdit;
        public EditProduct_Form()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'rentalPointDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.rentalPointDataSet.Product);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.rentalPointDataSet.Producer);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.rentalPointDataSet.Model);

            id = Convert.ToInt32(productTableAdapter.TheLastID()) + 1;
            this.ProductID_textBox.Text = id.ToString();
            IsEdit = false;
        }
        public EditProduct_Form(int id) : this()
        {
            var rows = productTableAdapter.WhereId(id);
            var row = rows[0].ItemArray;
            IsEdit = true;
            this.id = id;
            this.ProductID_textBox.Text = id.ToString();
            this.ModelID_comboBox.SelectedValue = row[1];
            this.ProducerID_comboBox.SelectedValue = row[2];
            this.Price_textBox.Text = row[3].ToString();
            this.Discount_maskedTextBox.Text = row[4].ToString();
            this.Deposit_textBox.Text = row[5].ToString();
            this.Description_textBox.Text = row[6].ToString();
        }
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            
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
                        productTableAdapter.UpdateQuery(
                            id,
                            Convert.ToInt32(ModelID_comboBox.SelectedValue),
                            Convert.ToInt32(ProducerID_comboBox.SelectedValue),
                            Convert.ToDecimal(Price_textBox.Text),
                            Convert.ToInt32(Discount_maskedTextBox.Text),
                            Convert.ToDecimal(Deposit_textBox.Text),
                            Description_textBox.Text,
                            id
                            );
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
                        productTableAdapter.InsertQuery(
                            id,
                            Convert.ToInt32(ModelID_comboBox.SelectedValue),
                            Convert.ToInt32(ProducerID_comboBox.SelectedValue),
                            Convert.ToDecimal(Price_textBox.Text),
                            Convert.ToInt32(Discount_maskedTextBox.Text),
                            Convert.ToDecimal(Deposit_textBox.Text),
                            Description_textBox.Text
                            );
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
    }
}
