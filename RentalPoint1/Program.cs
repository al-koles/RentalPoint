using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPoint1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!CheckDatabase())
                return;
            Properties.Settings.Default["RentalPointConnectionString"] = Properties.Settings.Default.RentalPointConnectionString + "Initial Catalog = RentalPoint";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }

        static bool CheckDatabase()
        {
            SqlConnection conn;
            try
            {
                conn = new SqlConnection(Properties.Settings.Default.RentalPointConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server. Read the Readme document and follow the instructions.\nError:" + ex.Message);
                return false;
            }
            using (conn)
            {
                try { conn.Open(); }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to server. Read the Readme document and follow the instructions.\nError:" + ex.Message);
                    return false;
                }
                try
                {
                    var dbExists = new SqlCommand("SELECT DB_ID('RentalPoint')", conn).ExecuteScalar();
                    if (dbExists == DBNull.Value)
                    {
                        // TODO: Create db
                        var query = @"CREATE DATABASE[RentalPoint]";
                        var createDB = new SqlCommand(query, conn).ExecuteNonQuery();
                        var fillDB = new SqlCommand(Properties.Resources.RentalPointTest, conn).ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating the database.\nError:" + ex.Message);
                    return false;
                }
                finally { conn.Close(); }
            }
            if (!CheckTables())
                return false;

            return true;
        }
        static bool CheckTables()
        {
            var tablesExist = true;

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.RentalPointConnectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand command = new SqlCommand(@"
                        select count(1) 
                            from RentalPoint.INFORMATION_SCHEMA.TABLES
                                where TABLE_NAME in 
                                (
                                    'Attachment',
                                    'Brand',
                                    'Client',
                                    'Detail',
                                    'DiscountType',
                                    'Good',
                                    'Model',
                                    'ModelType',
                                    'Order',
                                    'Producer',
                                    'Product',
                                    'Rent',
                                    'Set'
                                )
                    ", conn);
                    tablesExist = Convert.ToInt32(command.ExecuteScalar()) == 13;
                }
                finally { conn.Close(); }
            }

            if (tablesExist)
                return true;
            else if (MessageBox.Show("The database is broken. Do you want to recreate it?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.RentalPointConnectionString))
                {
                    connection.Open();
                    try
                    {
                        SqlCommand comm = new SqlCommand("drop database [RentalPoint]", connection);
                        comm.ExecuteNonQuery();
                        if (CheckDatabase())
                            return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't delete the database...\nError: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return false;
        }
    }
}

