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
    public partial class EditGood_Form : Form
    {
        private int id;
        private bool IsEdit;
        public EditGood_Form()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'rentalPointDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.rentalPointDataSet.Product);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.rentalPointDataSet.Good);

            id = Convert.ToInt32(goodTableAdapter.TheLastID()) + 1;
            this.GoodID_textBox.Text = id.ToString();
            IsEdit = false;
        }
        public EditGood_Form(int id) : this()
        {
            var rows = goodTableAdapter.WhereId(id);
            var row = rows[0].ItemArray;
            IsEdit = true;
            this.id = id;
            this.GoodID_textBox.Text = id.ToString();
            this.ProductID_comboBox.SelectedValue = row[1];
            this.ProductionDate_dateTimePicker.Value = Convert.ToDateTime(row[2]);
            this.UsingSince_dateTimePicker.Value = Convert.ToDateTime(row[3]);
            this.Condition_comboBox.SelectedIndex = Convert.ToInt32(row[4]);
        }
        private void Accept_button_Click(object sender, EventArgs e)
        {
            //var m = MessageBox.Show("Do you want to save changes?", "Saving changes", MessageBoxButtons.YesNoCancel);
            //if (m == DialogResult.Yes)
            //{
            var from = ProductionDate_dateTimePicker.Value;
            var to = UsingSince_dateTimePicker.Value;
            if (to <= from)
            {
                MessageBox.Show("'Using Since Date' must be after 'Production Date'");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (IsEdit)
            {
                try
                {
                    goodTableAdapter.UpdateQuery(
                        id,
                        Convert.ToInt32(ProductID_comboBox.SelectedValue),
                        Convert.ToBoolean(Condition_comboBox.SelectedIndex),
                        ProductionDate_dateTimePicker.Value.ToString(),
                        UsingSince_dateTimePicker.Value.ToString(),
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
                    goodTableAdapter.Insert(
                        id,
                        Convert.ToInt32(ProductID_comboBox.SelectedValue),
                        Convert.ToBoolean(Condition_comboBox.SelectedIndex),
                        ProductionDate_dateTimePicker.Value,
                        UsingSince_dateTimePicker.Value
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

        private void EditGoodForm_Load(object sender, EventArgs e)
        {
            ProductionDate_dateTimePicker.MaxDate = DateTime.Today;
            UsingSince_dateTimePicker.MaxDate = DateTime.Today;
            if(!IsEdit)
            {
                ProductionDate_dateTimePicker.Value = DateTime.Today;
                UsingSince_dateTimePicker.Value = DateTime.Today;
            }
        }
    }
}
