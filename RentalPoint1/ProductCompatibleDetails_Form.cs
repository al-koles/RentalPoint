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
    public partial class ProductCompatibleDetails_Form : Form
    {
        private ProductCompatibleDetails_Form()
        {
            InitializeComponent();
        }
        public ProductCompatibleDetails_Form(int product_id) : this()
        {
            this.product_id = product_id;
        }
        private int product_id;
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalPointDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.rentalPointDataSet.Detail);
            
            // TODO: This line of code loads data into the 'rentalPointDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.rentalPointDataSet.Set);
            rentalPointDataSet.Set.set_idColumn.AutoIncrement = true;
            rentalPointDataSet.Set.set_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Set.set_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(setTableAdapter.TheLastID());

            // TODO: This line of code loads data into the 'rentalPointDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.rentalPointDataSet.Product);
            rentalPointDataSet.Product.product_idColumn.AutoIncrement = true;
            rentalPointDataSet.Product.product_idColumn.AutoIncrementStep = 1;
            rentalPointDataSet.Product.product_idColumn.AutoIncrementSeed = 1 + Convert.ToInt32(productTableAdapter.TheLastID());

            var row = Query(new DataTable(), "product_id", product_id, Properties.Resources.ProductWhereId).Rows[0].ItemArray;
            this.productId_textBox.Text = product_id.ToString();
            this.ModelType_textBox.Text = row[0].ToString();
            this.Producer_textBox.Text = row[1].ToString();
            this.Brand_textBox.Text = row[2].ToString();
            this.Model_textBox.Text = row[3].ToString();

            var setTable = Query(new DataTable(), "product_id", product_id, Properties.Resources.SetsWhereProductId);
            this.setDataGridView.DataSource = setTable;
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
            //var m = MessageBox.Show("Do you want to save changes?", "Saving changes", MessageBoxButtons.YesNoCancel);
            //if (m == DialogResult.Yes)
            //{
                productBindingSource.EndEdit();
                productTableAdapter.Update(rentalPointDataSet.Product);
                setTableAdapter.Update(rentalPointDataSet.Set);
            //}
            //else if (m == DialogResult.No)
            //    return;
            //else if (m == DialogResult.Cancel)
            //    this.DialogResult = DialogResult.None;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Do you want to cancel all changes asn leave?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    return;
            //else
            //    this.DialogResult = DialogResult.None;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            EditCompatibleDetails_Form form = new EditCompatibleDetails_Form(product_id);
            form.ShowDialog();
            var setTable = Query(new DataTable(), "product_id", product_id, Properties.Resources.SetsWhereProductId);
            this.setDataGridView.DataSource = setTable;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if(setDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Set selected. Please select one.");
                return;
            }
            int set_id = Convert.ToInt32(setDataGridView.SelectedRows[0].Cells[0].Value);
            EditCompatibleDetails_Form form = new EditCompatibleDetails_Form(set_id, product_id);
            form.ShowDialog();
            var setTable = Query(new DataTable(), "product_id", product_id, Properties.Resources.SetsWhereProductId);
            this.setDataGridView.DataSource = setTable;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (setDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Set selected. Please select one.");
                return;
            }
            int set_id = Convert.ToInt32(setDataGridView.SelectedRows[0].Cells[0].Value);
            try
            {
                setTableAdapter.DeleteQuery(set_id);
                setTableAdapter.Fill(rentalPointDataSet.Set);
                rentalPointDataSet.AcceptChanges();
                var setTable = Query(new DataTable(), "product_id", product_id, Properties.Resources.SetsWhereProductId);
                this.setDataGridView.DataSource = setTable;
            }
            catch { MessageBox.Show("There is some connected data in table 'Order'. Delete it before."); }
        }
    }
}
