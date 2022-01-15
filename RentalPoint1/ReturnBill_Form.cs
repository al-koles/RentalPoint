using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPoint1
{
    public partial class ReturnBill_Form : Form
    {
        private ReturnBill_Form()
        {
            InitializeComponent();
        }
        public ReturnBill_Form(int[] rentsIds, decimal total) : this()
        {
            this.rentsIds = rentsIds;
            this.total = total;
        }
        private int[] rentsIds;
        private decimal total;
        private string result;
        private void ReturnBill_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.Client);

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";

            this.Total_textBox.Text = total.ToString();

            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Bill: Technical Equipment Rental Point");
            builder.AppendLine($"Date: {DateTime.Today.ToShortDateString()}");
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
            builder.AppendLine($"Total: {total}");

            result = builder.ToString();
        }
        private string ClientInfo()
        {
            var client_id = Convert.ToInt32(Query(rentsIds[0], "rent_id", Properties.Resources.GetClientByRent).Rows[0][0]);
            var row = clientTableAdapter.WhereId(client_id)[0].ItemArray;
            string str = $"   Name: {row[1]} {row[2]} {row[3]}";
            return str;

        }
        private string RentsInfo()
        {
            var table = Query(0, "rent_id", Properties.Resources.RentReturnInfo);
            table.Rows.Clear();
            foreach (var i in rentsIds)
            {
                var attTable = Query(i, "rent_id", Properties.Resources.RentReturnInfo);
                if (attTable.Rows.Count > 0)
                    table.Rows.Add(attTable.Rows[0].ItemArray);
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var from = Convert.ToDateTime(table.Rows[i][5]).ToShortDateString();
                table.Rows[i][5] = from;
            }
            string str = PrintDataTable(table);
            return str;
        }
        private string AttachmentsInfo()
        {
            var table = Query(0, "rent_id", Properties.Resources.AttachmentsInfo);
            table.Clear();
            foreach (var i in rentsIds)
            {
                var attTable = Query(i, "rent_id", Properties.Resources.AttachmentsInfo);
                foreach (DataRow r in attTable.Rows)
                    table.Rows.Add(r.ItemArray);
            }
            string str = PrintDataTable(table);
            return str;
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
