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
    public partial class EditClient_Form : Form
    {
        private int id;
        private bool IsEdit;
        public EditClient_Form()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'rentalPointDataSet.DiscountType' table. You can move, or remove it, as needed.
            this.discountTypeTableAdapter.Fill(this.rentalPointDataSet.DiscountType);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.Client);

            id = Convert.ToInt32(clientTableAdapter.TheLastID()) + 1;
            this.ClientID_textBox.Text = id.ToString();

            RegistrationDate_dateTimePicker.MaxDate = DateTime.Today;
            this.RegistrationDate_dateTimePicker.Value = DateTime.Today;
            IsEdit = false;
        }
        public EditClient_Form(int id) : this()
        {
            var rows = clientTableAdapter.WhereId(id);
            var row = rows[0].ItemArray;
            IsEdit = true;
            this.id = id;
            this.ClientID_textBox.Text = id.ToString();
            this.Discount_maskedTextBox.Text = row[1].ToString();
            this.discountType_comboBox.SelectedValue = row[2].ToString();
            this.FirstName_textBox.Text = row[3].ToString();
            this.SecondName_textBox.Text = row[4].ToString();
            this.LastName_textBox.Text = row[5].ToString();
            string gender = row[6].ToString();
            switch (gender.ToUpper())
            {
                case "M":
                    Gender_comboBox.SelectedIndex = 0;
                    break;
                case "F":
                    Gender_comboBox.SelectedIndex = 1;
                    break;
                default:
                    Gender_comboBox.SelectedIndex = 0;
                    break;
            };
            this.PhoneNumber_maskedTextBox.Text = row[7].ToString();
            this.Email_textBox.Text = row[8].ToString();
            this.Address_textBox.Text = row[9].ToString();
            this.PostCode_maskedTextBox.Text = row[10].ToString();
            this.RegistrationDate_dateTimePicker.Value = Convert.ToDateTime(row[11]);
            this.Description_textBox.Text = row[12].ToString();
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            string gender;
            switch (Gender_comboBox.SelectedIndex.ToString())
            {
                case "0":
                    gender = "M";
                    break;
                case "1":
                    gender = "F";
                    break;
                default:
                    gender = "M";
                    break;
            }
            if (IsEdit)
            {
                try
                {
                    clientTableAdapter.UpdateQuery(
                    id,
                    Convert.ToInt32(Discount_maskedTextBox.Text),
                    Convert.ToInt32(discountType_comboBox.SelectedValue),
                    FirstName_textBox.Text,
                    SecondName_textBox.Text,
                    LastName_textBox.Text,
                    gender,
                    PhoneNumber_maskedTextBox.Text,
                    Email_textBox.Text,
                    Address_textBox.Text,
                    Convert.ToInt32(PostCode_maskedTextBox.Text),
                    RegistrationDate_dateTimePicker.Value,
                    Description_textBox.Text,
                    id
                    );
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Input does not validate.");
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                try
                {
                    clientTableAdapter.Insert(
                    id,
                    Convert.ToInt32(Discount_maskedTextBox.Text),
                    Convert.ToInt32(discountType_comboBox.SelectedValue),
                    FirstName_textBox.Text,
                    SecondName_textBox.Text,
                    LastName_textBox.Text,
                    gender,
                    PhoneNumber_maskedTextBox.Text,
                    Email_textBox.Text,
                    Address_textBox.Text,
                    Convert.ToInt32(PostCode_maskedTextBox.Text),
                    RegistrationDate_dateTimePicker.Value,
                    Description_textBox.Text
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Input does not validate.");
                    this.DialogResult = DialogResult.None;
                }
            }
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
