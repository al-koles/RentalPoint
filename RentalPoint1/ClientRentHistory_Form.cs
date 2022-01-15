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
    public partial class ClientRentHistory_Form : Form
    {
        private ClientRentHistory_Form()
        {
            InitializeComponent();
        }
        public ClientRentHistory_Form(int client_id) : this()
        {
            this.client_id = client_id;
        }
        private int client_id;
        private void EditClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.rentalPointDataSet.Rent);
            rentalPointDataSet.Rent.rent_idColumn.AutoIncrement = true;
            rentalPointDataSet.Rent.rent_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Rent.rent_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(rentTableAdapter.TheLastID());

            // TODO: This line of code loads data into the 'rentalPointDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.Client);
            rentalPointDataSet.Client.client_idColumn.AutoIncrement = true;
            rentalPointDataSet.Client.client_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Client.client_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(clientTableAdapter.TheLastID());

            var rows = clientTableAdapter.WhereId(client_id);
            var row = rows[0].ItemArray;
            this.clientId_TextBox.Text = client_id.ToString();
            this.FirstName_TextBox.Text = row[3].ToString();
            this.SecondName_TextBox.Text = row[4].ToString();
            this.LastName_TextBox.Text = row[5].ToString();

            activeTable = new DataTable();
            inactiveTable = new DataTable();
            ActiveRents_dataGridView.DataSource = activeTable;
            InactiveRents_dataGridView.DataSource = inactiveTable;

            UpdateTables();
        }
        private DataTable activeTable;
        private DataTable inactiveTable;
        private void UpdateTables()
        {
            Query(Properties.Resources.ActiveRents, activeTable);
            Query(Properties.Resources.InactiveRents, inactiveTable);
        }
        private void Return_button_Click(object sender, EventArgs e)
        {
            if(ActiveRents_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("You need to select some rows before.");
                return;
            }
            var rows = ActiveRents_dataGridView.SelectedRows;
            int[] rentId_Arr = new int[rows.Count];
            for (int i = 0; i < rows.Count; i++)
                rentId_Arr[i] = Convert.ToInt32(rows[i].Cells[0].Value);
            Return_Form return_Form = new Return_Form(client_id, rentId_Arr);
            return_Form.ShowDialog();
            rentTableAdapter.Fill(rentalPointDataSet.Rent);
            UpdateTables();
        }
        private void Query(string commandText, DataTable dt)
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
                        command.Parameters.AddWithValue("client_id", client_id);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        dt.Clear();
                        adapter.Fill(dt);
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
