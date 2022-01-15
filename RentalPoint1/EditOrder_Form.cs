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
    public partial class EditOrder_Form : Form
    {
        private EditOrder_Form()
        {
            InitializeComponent();
        }
        public EditOrder_Form(int order_id) : this()
        {
            this.order_id = order_id;
        }
        private int order_id;
        private bool firstValue;
        private void EditOrder_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.rentalPointDataSet.Detail);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Attachment' table. You can move, or remove it, as needed.
            this.attachmentTableAdapter.Fill(this.rentalPointDataSet.Attachment);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.rentalPointDataSet.Rent);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.rentalPointDataSet.Order);

            var row = orderTableAdapter.WhereId(order_id)[0].ItemArray;
            this.OrderID_textBox.Text = order_id.ToString();
            this.clientId_textBox.Text = row[1].ToString();
            this.OrderDate_textBox.Text = Convert.ToDateTime(row[2]).ToShortDateString();
            this.Note_textBox.Text = row[3].ToString();
            if (row[4].ToString() != "")
            {
                Cancel_checkBox.Checked = true;
                Cancel_checkBox.Enabled = false;
            }
            firstValue = Cancel_checkBox.Checked;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            //If user wants to cancel the order:
            if(Cancel_checkBox.Checked != firstValue && Cancel_checkBox.Checked == true)
            {
                var theFirstRentDate = Convert.ToDateTime(rentTableAdapter.TheFirstRentDate(order_id));
                bool IsCancelAvailable = theFirstRentDate > DateTime.Now;
                if (IsCancelAvailable)
                {
                    orderTableAdapter.UpdateCancelDate(DateTime.Now, order_id);

                    DataTable attachments = new DataTable();
                    SQLCommandParams par = new SQLCommandParams { FieldName = "order_id", Text = order_id.ToString() };
                    Query(attachments, Properties.Resources.OrderAttachments, par);
                    foreach (DataRow a in attachments.Rows)
                        ReturnDetails(Convert.ToInt32(a[0]));
                }
                else
                {
                    MessageBox.Show("Sorry, canceling of this order is not available becase some of it's rents have already starded...");
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }
            orderTableAdapter.UpdateNote(Note_textBox.Text, order_id);
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
    }
}
