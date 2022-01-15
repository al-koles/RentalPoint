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
    public partial class EditCompatibleDetails_Form : Form
    {
        private EditCompatibleDetails_Form()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'rentalPointDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.rentalPointDataSet.Set);
        }
        private int product_id;
        private bool isEdit;
        private int set_id;
        public EditCompatibleDetails_Form(int product_id) : this()
        {
            this.product_id = product_id;
            isEdit = false;
        }
        public EditCompatibleDetails_Form(int set_id, int product_id) : this(product_id)
        {
            this.set_id = set_id;
            isEdit = true;
        }
        private void EditCompatibleDetails_Form_Load(object sender, EventArgs e)
        {
            //Неверно!!!
            string sqlText = Properties.Resources.DetailFill + $"where Detail.detail_id not in (select detail_id from [Set] where product_id = {product_id}";
            if (isEdit)
                sqlText += $" and set_id != {set_id}";
            sqlText += ")";
            detailsDataGridView.DataSource = Query(sqlText);
            if(isEdit)
            {
                int selectedDetail = setTableAdapter.WhereId(set_id)[0].detail_id;
                foreach (DataGridViewRow row in detailsDataGridView.Rows)
                    if (selectedDetail == Convert.ToInt32(row.Cells[0].Value))
                        row.Selected = true;
            }
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

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if(detailsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No detail selected. Please select one.");
                return;
            }
            var detail_id = Convert.ToInt32(detailsDataGridView.SelectedRows[0].Cells[0].Value);
            if (isEdit == false)
            {
                var set_id = Convert.ToInt32(setTableAdapter.TheLastID()) + 1;
                setTableAdapter.Insert(set_id, product_id, detail_id);
            }
            else
            {
                setTableAdapter.UpdateQuery(set_id, product_id, detail_id, set_id);
            }
        }
    }
}
