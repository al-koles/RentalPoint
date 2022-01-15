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

namespace RentalPoint1.Resources
{
    public partial class SelectAttachment_Form : Form
    {
        private SelectAttachment_Form()
        {
            InitializeComponent();
        }
        public SelectAttachment_Form(int rent_id) : this()
        {
            this.rent_id = rent_id;
        }
        private int rent_id;
        private void Accept_button_Click(object sender, EventArgs e)
        {
            if (Detail_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No good selected. Please select one.");
                this.DialogResult = DialogResult.None;
                return;
            }
            var row = Detail_dataGridView.SelectedRows[0];
            int attachment_id = Convert.ToInt32(attachmentTableAdapter.TheLastID()) + 1;
            attachmentTableAdapter.Insert(
                attachment_id,
                rent_id,
                Convert.ToInt32(row.Cells[0].Value),
                Convert.ToInt32(Amount_listBox.SelectedItem),
                null,
                null,
                null
                );
            Update_AttachmentPrice(attachment_id);
            var setRow = setTableAdapter.WhereId(Convert.ToInt32(row.Cells[0].Value))[0];
            int detail_id = Convert.ToInt32(setRow[2]);
            int detailAmount = Convert.ToInt32(detailTableAdapter.GetAmountAt(detail_id)) - Convert.ToInt32(Amount_listBox.SelectedItem);
            detailTableAdapter.UpdateAmount(detailAmount, detail_id);
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
            if (MessageBox.Show("Do you realy want to cancel all changes and leave?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.No)
                this.DialogResult = DialogResult.None;
        }

        private void SelectAttachment_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.rentalPointDataSet.Set);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.rentalPointDataSet.Detail);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Attachment' table. You can move, or remove it, as needed.
            this.attachmentTableAdapter.Fill(this.rentalPointDataSet.Attachment);

            var connectionStr = Properties.Settings.Default.RentalPointConnectionString;

            DataTable table = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    using (var command = conn.CreateCommand())
                    {
                        conn.Open();
                        try
                        {
                            command.CommandText = Properties.Resources.CompatibleDetails;
                            command.Parameters.AddWithValue("rent_id", rent_id);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            //table.Clear();
                            adapter.Fill(table);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Oops... Something went wrong... Error: {ex.Message}.");
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
            catch { }
            BindingSource bd = new BindingSource { DataSource = table };
            Detail_dataGridView.DataSource = bd;
        }

        private void Good_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Detail_dataGridView.Rows.Count != 0 && Detail_dataGridView.SelectedRows.Count != 0)
            {
                Amount_listBox.Enabled = true;
                FillListBox();
            }
            else
                Amount_listBox.Enabled = false;
        }
        private void FillListBox()
        {
            var row = Detail_dataGridView.SelectedRows[0];
            var amount = Convert.ToInt32(row.Cells[6].Value);
            object[] arr = new object[amount];
            for (int i = 1; i <= amount; i++)
                arr[i - 1] = i;
            this.Amount_listBox.Items.Clear();
            this.Amount_listBox.Items.AddRange(arr);
            Amount_listBox.SelectedIndex = 0;
        }
    }
}
