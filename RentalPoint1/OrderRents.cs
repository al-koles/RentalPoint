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
    public partial class OrderRents : Form
    {
        private OrderRents()
        {
            InitializeComponent();
        }
        public OrderRents(int order_id) : this()
        {
            this.order_id = order_id;
        }
        private int order_id;
        private void OrderRents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentalPointDataSet.Client);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.rentalPointDataSet.Rent);
            // TODO: This line of code loads data into the 'rentalPointDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.rentalPointDataSet.Order);

            var orderRow = orderTableAdapter.WhereId(order_id).Rows[0];
            int client_id = Convert.ToInt32(orderRow[1]);
            var clientRow = clientTableAdapter.WhereId(client_id).Rows[0];

            this.order_idTextBox.Text = order_id.ToString();
            this.client_idTextBox.Text = client_id.ToString();
            this.LastName_textBox.Text = clientRow[5].ToString();
            this.OrderDate_textBox.Text = orderRow[2].ToString();
            this.noteTextBox.Text = orderRow[3].ToString();
            this.CancelDate_textBox.Text = orderRow[4].ToString();
            var table = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.RentalPointConnectionString))
            {
                using(SqlCommand command = new SqlCommand(Properties.Resources.OrderRents, conn))
                {
                    conn.Open();
                    try
                    {
                        command.Parameters.AddWithValue("order_id", order_id);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                        this.rentDataGridView.DataSource = table;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ooops... Something went wrong while loading rents... \n Error: {ex.Message}");
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
