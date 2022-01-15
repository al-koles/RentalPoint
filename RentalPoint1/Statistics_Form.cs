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
    public partial class Statistics_Form : Form
    {
        private Statistics_Form()
        {
            InitializeComponent();
        }
        public Statistics_Form(string type) : this()
        {
            this.type = type;
        }
        private string type;
        DataTable dataTable;
        private void Statistics_Form_Load(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";

            this.Type_label.Text = type;
            dataTable = new DataTable();

            if (type == "Client Activity")
                dataTable = Query(Properties.Resources.Statistics_ClientActivity);
            else if (type == "Client Paid")
                dataTable = Query(Properties.Resources.Statistics_ClientPaid);
            else if (type == "Detail Popularity")
                dataTable = Query(Properties.Resources.Statistics_DetailPopularity);
            else if (type == "Product Popularity")
                dataTable = Query(Properties.Resources.Statistics_ProductPopularity);

            dataGridView1.DataSource = dataTable;
        }
        private DataTable Query(string commandText)
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

        private void Print_button_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            if (dataTable.Rows.Count == 0)
                return;
            string str = PrintDataTable(dataTable);

            builder.AppendLine(type);
            builder.AppendLine(DateTime.Now.ToString());
            builder.AppendLine(str);

            string result = builder.ToString();

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, result);
            MessageBox.Show($"Bill saved to {filename}");
        }
        private string PrintDataTable(DataTable table)
        {
            StringBuilder builder = new StringBuilder();
            PrintDataExtensions.SetOutputStringBuilder(builder);
            table.Print();
            string str = builder.ToString();
            return str;
        }
    }
}
