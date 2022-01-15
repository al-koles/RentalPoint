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

namespace RentalPoint1
{
    public partial class SelectGood_Form : Form
    {
        private SelectGood_Form()
        {
            InitializeComponent();
        }
        //private List<string> selectedGood;
        private int order_id;
        public SelectGood_Form(int order_id) : this()
        {
            this.order_id = order_id;
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.rentalPointDataSet.Rent);

            var connectionStr = Properties.Settings.Default.RentalPointConnectionString;

            DataTable table = new DataTable();
            try
            {
                var sqlText = Properties.Resources.AvailableGoodsQuery;
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlText, connection);
                    dataAdapter.Fill(table);
                }
            }
            catch { }
            BindingSource bd = new BindingSource { DataSource = table };
            Good_dataGridView.DataSource = bd;

            From_dateTimePicker.MinDate = DateTime.Today;
            To_dateTimePicker.MinDate = DateTime.Today;
            From_dateTimePicker.Value = DateTime.Today;
            To_dateTimePicker.Value = DateTime.Today;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if (Good_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No good selected. Please select one.");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                DateTime from;
                DateTime to;
                try { from = From_dateTimePicker.Value; }
                catch
                {
                    MessageBox.Show("'From' date is not selected. Please select.");
                    this.DialogResult = DialogResult.None;
                    return;
                }
                try { to = To_dateTimePicker.Value; }
                catch
                {
                    MessageBox.Show("'To' date is not selected. Please select.");
                    this.DialogResult = DialogResult.None;
                    return;
                }
                if(from >= to)
                {
                    MessageBox.Show("'To' date must be after 'From' date. Please change it.");
                    this.DialogResult = DialogResult.None;
                    return;
                }

                DataGridViewRow row = Good_dataGridView.SelectedRows[0];
                int rentId = Convert.ToInt32(rentTableAdapter.TheLastID()) + 1;
                rentTableAdapter.Insert(
                    rentId,
                    order_id,
                    Convert.ToInt32(row.Cells[0].Value),
                    from,
                    to,
                    null,
                    Convert.ToInt32(row.Cells[6].Value),
                    null,
                    true,
                    0
                    );
                Update_RentTotalPrice(rentId);
            }
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

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Do you realy want to cancel all changes and leave?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.No)
            //    this.DialogResult = DialogResult.None;
        }
    }
}
