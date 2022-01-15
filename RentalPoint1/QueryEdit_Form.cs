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
    public partial class QueryEdit_Form : Form
    {
        public QueryEdit_Form()
        {
            InitializeComponent();
        }

        private void Do_button_Click(object sender, EventArgs e)
        {
            string connStr = Properties.Settings.Default.RentalPointConnectionString;
            try
            {
                using(SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(richTextBox1.Text, conn);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
