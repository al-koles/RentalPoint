using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPoint1
{
    public partial class EditAttachmentAmount_Form : Form
    {
        private EditAttachmentAmount_Form()
        {
            InitializeComponent();
        }
        public EditAttachmentAmount_Form(int attachment_id) : this()
        {
            this.attachment_id = attachment_id;
        }
        private int attachment_id;
        private int detail_id;
        private int amount;
        private void EditAttachmentAmount_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.rentalPointDataSet.Detail);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.rentalPointDataSet.Set);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Attachment' table. You can move, or remove it, as needed.
            this.attachmentTableAdapter.Fill(this.rentalPointDataSet.Attachment);

            //Fill fields
            var row = attachmentTableAdapter.WhereId(attachment_id)[0];
            AttachmentId_textBox.Text = attachment_id.ToString();
            RentID_textBox.Text = row[1].ToString();
            SetId_textBox.Text = row[2].ToString();

            //Fill listbox and select item in it
            var setRow = setTableAdapter.WhereId(Convert.ToInt32(row[2]))[0];
            detail_id = Convert.ToInt32(setRow[2]);
            int selectedAmount = Convert.ToInt32(row[3]);
            amount = Convert.ToInt32(detailTableAdapter.GetAmountAt(detail_id)) + selectedAmount;
            FillListBox(amount, selectedAmount-1);
        }
        private void FillListBox(int amount, int selected)
        {
            object[] arr = new object[amount];
            for (int i = 1; i <= amount; i++)
                arr[i - 1] = i;
            this.Amount_listBox.Items.Clear();
            this.Amount_listBox.Items.AddRange(arr);
            Amount_listBox.SelectedIndex = selected;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            int newAmount = Convert.ToInt32(Amount_listBox.SelectedItem);

            //Update attechment
            attachmentTableAdapter.UpdateAmount(newAmount, attachment_id);
            //attachmentTableAdapter.Update(rentalPointDataSet.Attachment);
            Update_AttachmentPrice(attachment_id);

            //Update detail
            detailTableAdapter.UpdateAmount(amount - newAmount, detail_id);
        }
        private void Update_AttachmentPrice(int attachment_id)
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = Properties.Resources.UpdateAttachmentPrice;
                    command.Parameters.AddWithValue("attachment_id", attachment_id);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {

        }
    }
}
