using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RentalPoint1.Resources;

namespace RentalPoint1
{
    public partial class Order_Form : Form
    {
        private Order_Form()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'rentalPointDataSet.DiscountType' table. You can move, or remove it, as needed.
            this.discountTypeTableAdapter.Fill(this.rentalPointDataSet.DiscountType);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.Client);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.rentalPointDataSet.Order);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.rentalPointDataSet.Rent);
        }
        public Order_Form(int client_id) : this()
        {
            this.client_id = client_id;
            order_id = Convert.ToInt32(orderTableAdapter.TheLastID()) + 1;
            orderTableAdapter.Insert(order_id, client_id, DateTime.Now, "", null);
        }

        private int client_id;
        private int order_id;
        private DataTable rents_DataTable;
        private DataTable attachments_DataTable;
        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.rentalPointDataSet.Set);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Attachment' table. You can move, or remove it, as needed.
            this.attachmentTableAdapter.Fill(this.rentalPointDataSet.Attachment);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.rentalPointDataSet.Detail);
            FillClientInfo();
            rents_DataTable = new DataTable();
            attachments_DataTable = new DataTable();
            Rents_dataGridView.DataSource = rents_DataTable;
            Attachments_dataGridView.DataSource = attachments_DataTable;
        }
        private void FillClientInfo()
        {
            var rows = clientTableAdapter.WhereId(client_id);
            var row = rows[0].ItemArray;
            this.clientId_TextBox.Text = client_id.ToString();
            this.Discount_maskedTextBox.Text = row[1].ToString();
            this.discountType_comboBox.SelectedValue = row[2].ToString();
            this.FirstName_TextBox.Text = row[3].ToString();
            this.SecondName_TextBox.Text = row[4].ToString();
            this.LastName_TextBox.Text = row[5].ToString();
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            SelectGood_Form selectGood_Form = new SelectGood_Form(order_id);
            if (selectGood_Form.ShowDialog() == DialogResult.OK)
            {
                rentTableAdapter.Fill(rentalPointDataSet.Rent);
                UpdateRentTable();
                UpdateAttachmentsTable();
            }
            CountTotal();
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            if (Rents_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rent selected. Please select one.");
                return;
            }
            row = Rents_dataGridView.SelectedRows[0];
            int rent_id = Convert.ToInt32(row.Cells[0].Value);

            DataTable table;
            table = attachmentTableAdapter.RentAttachments(rent_id); // Excaption
            foreach (DataRow a in table.Rows)
                ReturnDetails(Convert.ToInt32(a[0]));
            rentTableAdapter.DeleteQuery(rent_id);
            UpdateRentTable();
            CountTotal();
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            if (Rents_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rent selected. Please select one.");
                return;
            }
            row = Rents_dataGridView.SelectedRows[0];
            int rent_id = Convert.ToInt32(row.Cells[0].Value);
            var edit = new EditRentFromTo_Form(rent_id);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                Update_RentTotalPrice(rent_id);
                rentTableAdapter.Fill(rentalPointDataSet.Rent);
                UpdateRentTable();
            }
            CountTotal();
        }
        private void Update_RentTotalPrice(int rent_id)
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = Properties.Resources.UpdateRentPriceAt;
                    command.Parameters.AddWithValue("id", rent_id);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        private void UpdateRentTable()
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    try
                    {
                        command.CommandText = Properties.Resources.RentsInfoQuery;
                        command.Parameters.AddWithValue("id", order_id);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        rents_DataTable.Clear();
                        adapter.Fill(rents_DataTable);
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
        private void AddAttachment_button_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            if (Rents_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rent selected. Please select one.");
                return;
            }
            row = Rents_dataGridView.SelectedRows[0];
            int rent_id = Convert.ToInt32(row.Cells[0].Value);
            var form = new SelectAttachment_Form(rent_id);
            form.ShowDialog();
            UpdateAttachmentsTable();
            CountTotal();
        }
        private void Accept_button_Click(object sender, EventArgs e)
        {
            if(rents_DataTable.Rows.Count == 0)
            {
                MessageBox.Show("The order must contain products. Please add some");
                return;
            }
            var m = MessageBox.Show("Do you want to save the order?", "Saving order", MessageBoxButtons.OKCancel);
            if (m == DialogResult.OK)
            {
                UpdateClientDiscount();
                var result = new OrderBill_Form(order_id, Convert.ToDecimal(Price_textBox.Text), Convert.ToDecimal(Deposit_textBox.Text));
                result.ShowDialog();
            }
            else if (m == DialogResult.Cancel)
                this.DialogResult = DialogResult.None;
        }
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel all changes and leave?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataTable attachments = new DataTable();
                SQLCommandParams par = new SQLCommandParams { FieldName = "order_id", Text = order_id.ToString() };
                Query(attachments, Properties.Resources.OrderAttachments, par);
                foreach (DataRow a in attachments.Rows)
                    ReturnDetails(Convert.ToInt32(a[0]));

                orderTableAdapter.DeleteQuery(order_id);
            }
            else
                this.DialogResult = DialogResult.None;
        }
        private void Rents_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdateAttachmentsTable();
        }
        private void UpdateAttachmentsTable()
        {
            if (Rents_dataGridView.Rows.Count == 0 || Rents_dataGridView.SelectedRows.Count == 0)
            {
                attachments_DataTable.Clear();
            }
            else
            {
                var row = Rents_dataGridView.SelectedRows[0];
                int rent_id = Convert.ToInt32(row.Cells[0].Value);
                string connStr = Properties.Settings.Default.RentalPointConnectionString;
                using (var conn = new SqlConnection(connStr))
                {
                    using (var command = conn.CreateCommand())
                    {
                        conn.Open();
                        try
                        {
                            command.CommandText = Properties.Resources.AttachmentsInfo;
                            command.Parameters.AddWithValue("rent_id", rent_id);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            attachments_DataTable.Clear();
                            adapter.Fill(attachments_DataTable);
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
        }
        private void EditAtt_button_Click(object sender, EventArgs e)
        {
            if (Attachments_dataGridView.Rows.Count == 0 || Attachments_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected. Please select one.");
                return;
            }
            var row = Attachments_dataGridView.SelectedRows[0];
            int attachment_id = Convert.ToInt32(row.Cells[0].Value);
            var editForm = new EditAttachmentAmount_Form(attachment_id);
            editForm.ShowDialog();
            rentTableAdapter.Fill(rentalPointDataSet.Rent);
            detailTableAdapter.Fill(rentalPointDataSet.Detail);
            UpdateAttachmentsTable();
            CountTotal();
        }
        private void DeleteAtt_button_Click(object sender, EventArgs e)
        {
            if (Attachments_dataGridView.Rows.Count == 0 || Attachments_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected. Please select one.");
                return;
            }
            var row = Attachments_dataGridView.SelectedRows[0];
            int attachment_id = Convert.ToInt32(row.Cells[0].Value);
            ReturnDetails(attachment_id);
            attachmentTableAdapter.DeleteQuery(attachment_id);

            attachmentTableAdapter.Fill(rentalPointDataSet.Attachment);
            detailTableAdapter.Fill(rentalPointDataSet.Detail);

            UpdateAttachmentsTable();
            CountTotal();
        }
        private void ReturnDetails(int attachment_id) //Returns details to datail table from attachment
        {
            var attachmentRow = attachmentTableAdapter.WhereId(attachment_id)[0];
            int attAmount = Convert.ToInt32(attachmentRow[3]);
            int[] detail = GetDetailByAttachment(attachment_id);
            detailTableAdapter.UpdateAmount(detail[1] + attAmount, detail[0]);
        }
        private int[] GetDetailByAttachment(int attachment_id)
        {
            var dataTable = new DataTable();
            SQLCommandParams par = new SQLCommandParams { FieldName = "attachment_id", Text = attachment_id.ToString() };
            Query(dataTable, Properties.Resources.GetDetailByAttachment, par);

            int[] arr;
            if (dataTable.Rows.Count == 0)
                return null;
            var oArr = dataTable.Rows[0].ItemArray;
            arr = new int[2];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(oArr[i]);
            return arr;
        }
        private DataTable Query(DataTable table, string commandText, params SQLCommandParams[] commandParams)
        {
            table = table ?? new DataTable();
            var connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    try
                    {
                        command.CommandText = commandText;
                        foreach (var a in commandParams)
                            command.Parameters.AddWithValue(a.FieldName, a.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
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
            return table;
        }
        private void Discount_maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            CountTotal();
        }
        private void CountTotal()
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            DataTable table = new DataTable();
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    try
                    {
                        command.CommandText = Properties.Resources.TotalPrice;
                        command.Parameters.AddWithValue("order_id", order_id);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
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
            if(table.Rows.Count == 0)
            {
                Price_textBox.Text = "0";
                Deposit_textBox.Text = "0";
                return;
            }
            var row = table.Rows[0];
            decimal totalPrice = 0;
            if (row[0].ToString() != "")
                totalPrice += Convert.ToDecimal(row[0]);
            if (row[1].ToString() != "")
                totalPrice += Convert.ToDecimal(row[1]);

            decimal totalDeposit = 0;
            if (row[2].ToString() != "")
                totalDeposit = Convert.ToDecimal(row[2]);

            if (Discount_maskedTextBox.MaskCompleted)
                totalPrice -= totalPrice * Convert.ToDecimal(Discount_maskedTextBox.Text) / 100;
            Price_textBox.Text = totalPrice.ToString();
            Deposit_textBox.Text = totalDeposit.ToString();
        }
        private void UpdateClientDiscount()
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    try
                    {
                        command.CommandText = Properties.Resources.UpdateCLientDiscount;
                        command.Parameters.AddWithValue("client_id", client_id);
                        command.Parameters.AddWithValue("Discount", Convert.ToInt32(Discount_maskedTextBox.Text));
                        command.Parameters.AddWithValue("discountType_id", Convert.ToInt32(discountType_comboBox.SelectedValue));
                        command.ExecuteNonQuery();
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
    }
}
