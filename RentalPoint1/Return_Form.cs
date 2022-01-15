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
    public partial class Return_Form : Form
    {
        private Return_Form()
        {
            InitializeComponent();
        }
        public Return_Form(int client_id, int[] rentId_Arr) : this()
        {
            this.client_id = client_id;
            this.rentId_Arr = rentId_Arr;
        }
        int client_id;
        int[] rentId_Arr;
        private DataTable rents_DataTable;
        private DataTable attachments_DataTable;
        private void ReturnForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.rentalPointDataSet.Detail);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Attachment' table. You can move, or remove it, as needed.
            this.attachmentTableAdapter.Fill(this.rentalPointDataSet.Attachment);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.rentalPointDataSet.Rent);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.Client);

            rents_DataTable = new DataTable();
            Rents_dataGridView.DataSource = rents_DataTable;
            attachments_DataTable = new DataTable();
            Attachments_dataGridView.DataSource = attachments_DataTable;

            FillClientInfo();
            UpdateAllPenalties();
            UpdateRentTable();
            UpdateAttachmentsTable();
            Attachments_SelectionChanged();
        }
        private void FillClientInfo()
        {
            var rows = clientTableAdapter.WhereId(client_id);
            var row = rows[0].ItemArray;
            this.clientId_TextBox.Text = client_id.ToString();
            this.FirstName_TextBox.Text = row[3].ToString();
            this.SecondName_TextBox.Text = row[4].ToString();
            this.LastName_TextBox.Text = row[5].ToString();
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
                        command.CommandText = Properties.Resources.RentReturnInfo;
                        rents_DataTable.Clear();
                        foreach (var a in rentId_Arr)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("rent_id", a);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(rents_DataTable);
                        }
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
            CountTotal();
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
                Query(attachments_DataTable, "rent_id", rent_id, Properties.Resources.ReturnAttachments);
            }
            CountTotal();
        }
        private void UpdateAllPenalties()
        {
            foreach (var a in rentId_Arr)
                UpdateRentPenalty(a);
        }
        private void UpdateRentPenalty(int rent_id)
        {
            var row = rentTableAdapter.WhereID(rent_id)[0];
            var cond = Convert.ToBoolean(row[8]);
            double penalty = 0;
            if (cond)
            {

                var price = Query(new DataTable(), "good_id", Convert.ToInt32(row[2]), Properties.Resources.GoodPrice).Rows[0][0];
                penalty = (DateTime.Now - Convert.ToDateTime(row[4])).TotalDays * Convert.ToDouble(price);
                if (penalty < 0)
                    penalty = 0;
                if (penalty > Convert.ToDouble(row[7]))
                    penalty = Convert.ToDouble(row[7]);
            }
            else
                penalty = Convert.ToDouble(row[7]);
            rentTableAdapter.UpdatePenalty(Convert.ToDecimal(penalty), rent_id);
        }
        private DataTable Query(DataTable table, string propertyName, int propertyValue, string commandText)
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    try
                    {
                        command.CommandText = commandText;
                        command.Parameters.AddWithValue(propertyName, propertyValue);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        table.Clear();
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
        private void Accept_button_Click(object sender, EventArgs e)
        {
            foreach (var a in rentId_Arr)
            {
                rentTableAdapter.UpdateReturnDate(DateTime.Today.ToShortDateString(), a);
                var row = rentTableAdapter.WhereID(a)[0];
                bool condition = Convert.ToBoolean(row[8]);
                UpdateGoodCondition(a, condition);

                var detailsToAdd = Query(new DataTable(), "rent_id", a, Properties.Resources.DetailsToAdd);
                foreach(DataRow r in detailsToAdd.Rows)
                {
                    int detail_id = Convert.ToInt32(r[0]);
                    int amount = Convert.ToInt32(detailTableAdapter.WhereId(detail_id).Rows[0][4]);
                    int rentunAmount = 0;
                    if (!(r[1] is DBNull))
                        rentunAmount = Convert.ToInt32(r[1]);
                    detailTableAdapter.UpdateAmount(amount + rentunAmount, detail_id);
                }
            }
            var result = new ReturnBill_Form(rentId_Arr, Convert.ToDecimal(Price_textBox.Text));
            result.ShowDialog();
        }
        private void UpdateGoodCondition(int rent_id, bool Condition)
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    try
                    {
                        command.CommandText = Properties.Resources.UpdateGoodCondition;
                        command.Parameters.AddWithValue("rent_id", rent_id);
                        command.Parameters.AddWithValue("Condition", Condition);
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
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            foreach (var a in rentId_Arr)
            {
                rentTableAdapter.CancelReturning(a);
                attachmentTableAdapter.CancelReturn(a);
            }       
        }
        private void Condition_button_Click(object sender, EventArgs e)
        {
            if(Rents_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected. Please select one.");
                return;
            }
            var row = Rents_dataGridView.SelectedRows[0];
            var condition = Convert.ToBoolean(row.Cells[7].Value);
            if (condition)
                rentTableAdapter.UpdateReturnCondition(false, Convert.ToInt32(row.Cells[0].Value));
            else
                rentTableAdapter.UpdateReturnCondition(true, Convert.ToInt32(row.Cells[0].Value));
            UpdateRentPenalty(Convert.ToInt32(row.Cells[0].Value));
            UpdateRentTable();
        }
        private void Rents_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdateAttachmentsTable();
            Attachments_SelectionChanged();
        }
        private void Attachments_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Attachments_SelectionChanged();
        }
        private void Attachments_SelectionChanged()
        {
            ReturnAmount_listBox.Items.Clear();
            if (Attachments_dataGridView.SelectedRows.Count == 0)
                return;
            var row = Attachments_dataGridView.SelectedRows[0];
            int amount = Convert.ToInt32(row.Cells[5].Value);
            int current = 0;
            if (!(row.Cells[6].Value is DBNull))
                current = Convert.ToInt32(row.Cells[6].Value.ToString());
            FillListBox(amount, current);
        }
        private void FillListBox(int amount, int selected)
        {
            object[] arr = new object[amount];
            for (int i = 1; i <= amount; i++)
                arr[i-1] = i;
            this.ReturnAmount_listBox.Items.Clear();
            this.ReturnAmount_listBox.Items.AddRange(arr);
            ReturnAmount_listBox.SelectedIndex = selected-1;
        }
        private void SelectAmount_button_Click(object sender, EventArgs e)
        {
            if (Attachments_dataGridView.SelectedRows.Count == 0)
                return;
            var row = Attachments_dataGridView.SelectedRows[0];
            int attachment_id = Convert.ToInt32(row.Cells[0].Value);
            int currentAmount = Convert.ToInt32(ReturnAmount_listBox.SelectedItem);
            decimal Price = Convert.ToDecimal(Query(new DataTable(), "attachment_id", attachment_id, Properties.Resources.AttachmentPrice).Rows[0][0]) * currentAmount;
            
            attachmentTableAdapter.UpdateReturnAmountAndPrice(currentAmount, Price, attachment_id);
            UpdateAttachmentsTable();
        }
        private void UpdateQuery(string propertyName, int propertyValue, string commandText)
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                using (var command = conn.CreateCommand())
                {
                    conn.Open();
                    try
                    {
                        command.CommandText = commandText;
                        command.Parameters.AddWithValue(propertyName, propertyValue);
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
        private void CountTotal()
        {
            //int[] rentIds = rents_DataTable.AsEnumerable().Select(r => r.Field<int>(0)).ToArray();
            decimal penalty = 0;
            decimal returnSum = 0;
            foreach(var a in rentId_Arr)
            {
                penalty += Convert.ToDecimal(rentTableAdapter.PenaltySum(a));
                returnSum += Convert.ToDecimal(attachmentTableAdapter.ReturnPriceSum(a)) + Convert.ToDecimal(rentTableAdapter.WhereID(a).Rows[0][7]);
            }
            Price_textBox.Text = (returnSum - penalty).ToString();
        }
    }
}
