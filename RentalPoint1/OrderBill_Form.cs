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
using System.IO;

namespace RentalPoint1
{
    public partial class OrderBill_Form : Form
    {
        private OrderBill_Form()
        {
            InitializeComponent();
        }
        public OrderBill_Form(int order_id, decimal price, decimal deposit) : this()
        {
            this.order_id = order_id;
            this.price = price;
            this.deposit = deposit;
        }
        private int order_id;
        private decimal price;
        private decimal deposit;
        private string result;

        private void OrderResults_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.rentalPointDataSet.Order);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.Client);
            //richTextBox1.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
            //richTextBox1.Document.PageWidth = 1000;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            var row = orderTableAdapter.WhereId(order_id)[0];
            DateTime date = Convert.ToDateTime(row[2]).Date;
            this.Price_textBox.Text = price.ToString();
            this.Deposit_textBox.Text = deposit.ToString();
            this.Total_textBox.Text = (price + deposit).ToString();

            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Bill: Technical Equipment Rental Point");
            builder.AppendLine($"Date: {date.ToShortDateString()}");
            builder.AppendLine();
            builder.AppendLine("Client Info:");
            builder.AppendLine(ClientInfo());
            builder.AppendLine();
            builder.AppendLine("Goods info:");
            builder.AppendLine(RentsInfo());
            //builder.AppendLine();
            builder.AppendLine("Details info:");
            builder.AppendLine(AttachmentsInfo());
            //builder.AppendLine();
            builder.AppendLine($"Price: {price}");
            builder.AppendLine($"Deposit: {deposit}");
            builder.AppendLine($"To Pay: {price + deposit}");

            result = builder.ToString();
        }
        private string ClientInfo()
        {
            var arr = Query(order_id, "order_id", Properties.Resources.ClientBillInfo).Rows[0].ItemArray;
            string str = $"   Name: {arr[1]} {arr[2]} {arr[3]} \n   Discount: {arr[4]}";
            //string str = Print(table);
            return str;

        }
        private string RentsInfo()
        {
            var table = Query(order_id, "order_id", Properties.Resources.OrderBill);
            for(int i = 0; i < table.Rows.Count; i++)
            {
                var from = Convert.ToDateTime(table.Rows[i][7]).ToShortDateString();
                var to = Convert.ToDateTime(table.Rows[i][8]).ToShortDateString();
                table.Rows[i][7] = from;
                table.Rows[i][8] = to;
            }
            string str = PrintDataTable(table);
            return str;
        }
        private string AttachmentsInfo()
        {
            var table = Query(order_id, "order_id", Properties.Resources.OrderAttachmentsBill);
            if (table.Rows.Count == 0)
                return "Empty\n";
            string str = PrintDataTable(table);
            return str;
        }
        private static string Print(DataTable table)
        {
            string data = string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    sb.Append("   " + table.Columns[j].ColumnName + ": ");
                    sb.Append("   " + table.Rows[i].ItemArray[j]);
                    sb.AppendLine();
                }
                sb.AppendLine();
            }
            data = sb.ToString();
            return data;
        }
        private DataTable Query(int propValue, string propName, string commandText)
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
                        command.CommandText = commandText;
                        command.Parameters.AddWithValue(propName, propValue);
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
        private string PrintDataTable(DataTable table)
        {
            StringBuilder builder = new StringBuilder();
            PrintDataExtensions.SetOutputStringBuilder(builder);
            table.Print();
            string str = builder.ToString();
            return str;
        }
        private void Print_button_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, result);
            MessageBox.Show($"Bill saved to {filename}");
        }
    }
}
