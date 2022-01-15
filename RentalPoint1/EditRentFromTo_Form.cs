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
    public partial class EditRentFromTo_Form : Form
    {
        private EditRentFromTo_Form()
        {
            InitializeComponent();
        }
        private int rent_id;
        public EditRentFromTo_Form(int id) : this()
        {
            rent_id = id;
        }
        private void EditRent_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.rentalPointDataSet.Rent);
            FromDate_dateTimePicker.MinDate = DateTime.Today;
            ToDate_dateTimePicker.MinDate = DateTime.Today;

            var row = rentTableAdapter.WhereID(rent_id)[0];
            this.RentID_textBox.Text = row[0].ToString();
            this.OrderID_textBox.Text = row[1].ToString();
            this.GoodID_textBox.Text = row[2].ToString();
            this.FromDate_dateTimePicker.Value = Convert.ToDateTime(row[3]);
            this.ToDate_dateTimePicker.Value = Convert.ToDateTime(row[4]);
        }
        private void Accept_button_Click(object sender, EventArgs e)
        {
            var from = FromDate_dateTimePicker.Value;
            var to = ToDate_dateTimePicker.Value;
            if(from < DateTime.Today)
            {
                MessageBox.Show("'From Date' must be today or after");
                this.DialogResult = DialogResult.None;
                return;
            }
            if(to <= from)
            {
                MessageBox.Show("'To Date' must be after 'From Date'");
                this.DialogResult = DialogResult.None;
                return;
            }
            //var m = MessageBox.Show("Do you want to save changes?", "Saving changes", MessageBoxButtons.YesNoCancel);
            //if (m == DialogResult.Yes)
                rentTableAdapter.UpdateFromTo(from.Date, to.Date, rent_id);
            //else if (m == DialogResult.No)
            //    this.DialogResult = DialogResult.Cancel;
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
