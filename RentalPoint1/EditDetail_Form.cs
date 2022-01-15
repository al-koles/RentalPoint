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
    public partial class EditDetail_Form : Form
    {
        private int id;
        private bool IsEdit;
        public EditDetail_Form()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'rentalPointDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.rentalPointDataSet.Detail);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.rentalPointDataSet.Producer);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.rentalPointDataSet.Model);

            id = Convert.ToInt32(detailTableAdapter.TheLastID()) + 1;
            this.DetailID_textBox.Text = id.ToString();
            IsEdit = false;
        }
        public EditDetail_Form(int id) : this()
        {
            var rows = detailTableAdapter.WhereId(id);
            var row = rows[0].ItemArray;
            IsEdit = true;
            this.id = id;
            this.DetailID_textBox.Text = id.ToString();
            this.ModelID_comboBox.SelectedValue = row[1];
            this.ProducerID_comboBox.SelectedValue = row[2];
            this.Price_textBox.Text = row[3].ToString();
            this.Amount_maskedTextBox.Text = row[4].ToString();
            this.IsReturnable_checkBox.Checked = Convert.ToBoolean(row[5]);
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
                        detailTableAdapter.UpdateQuery(
                            id,
                            Convert.ToInt32(ModelID_comboBox.SelectedValue),
                            Convert.ToInt32(ProducerID_comboBox.SelectedValue),
                            Convert.ToDecimal(Price_textBox.Text),
                            Convert.ToInt32(Amount_maskedTextBox.Text),
                            IsReturnable_checkBox.Checked,
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
                        detailTableAdapter.Insert(
                            id,
                            Convert.ToInt32(ModelID_comboBox.SelectedValue),
                            Convert.ToInt32(ProducerID_comboBox.SelectedValue),
                            Convert.ToDecimal(Price_textBox.Text),
                            Convert.ToInt32(Amount_maskedTextBox.Text),
                            IsReturnable_checkBox.Checked
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
        private void EditDetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
