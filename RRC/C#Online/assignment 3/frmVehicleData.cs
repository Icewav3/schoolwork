using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace assignment_1
{
    public partial class frmVehicleData : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        private bool hasChanges;

        public frmVehicleData()
        {
            InitializeComponent();

            try
            {
                // Connection
                connection = new OleDbConnection();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AMDatabase.mdb";

                // DataAdapter
                dataAdapter = new OleDbDataAdapter();

                // DataTable
                dataTable = new DataTable();

                // Events
                closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
                saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
                deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
                dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
                this.FormClosing += frmVehicleData_FormClosing;

                // Set data source
                dataGridView1.DataSource = dataTable;

                // Fill DataTable
                FillDataTable();

                // Hide ID & SoldBy
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["SoldBy"].Visible = false;

                // Set init
                hasChanges = false;
                this.Text = "Vehicle Data";
                saveToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDatabase();

            if (hasChanges)
            {
                DialogResult result = MessageBox.Show("An error occurred while saving the changes. Do you still wish to close this window?", "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    // Prevent close
                    this.DialogResult = DialogResult.None;
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataTable.AcceptChanges();
            hasChanges = true;
            this.Text = "* Vehicle Data";
            saveToolStripMenuItem.Enabled = true;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow && dataGridView1.CurrentRow.Selected)
            {
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void FillDataTable()
        {
            try
            {
                // Connect
                connection.Open();

                // Create SQL command
                OleDbCommand command = new OleDbCommand("SELECT * FROM VehicleStock", connection);

                // Set command
                dataAdapter.SelectCommand = command;

                // DataAdapter to fill dataTable
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateDatabase()
        {
            try
            {
                // Connect
                connection.Open();

                // Update changes
                dataAdapter.Update(dataTable);
                hasChanges = false;
                this.Text = "Vehicle Data";
                saveToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data." + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int selectedRowIndex = dataGridView1.CurrentRow.Index;
                int stockItem = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StockNumber"].Value);

                DialogResult result = MessageBox.Show($"Are you sure you want to permanently delete stock item {stockItem}?", "Delete Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dataTable.Rows[selectedRowIndex].Delete();
                        dataTable.AcceptChanges();

                        // Update the database
                        UpdateDatabase();

                        // Disable the delete menu item after successful deletion
                        deleteToolStripMenuItem.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the selected vehicle." + Environment.NewLine + "Error: " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void frmVehicleData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChanges)
            {
                DialogResult result = MessageBox.Show("Do you wish to save the changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    UpdateDatabase();
                    if (hasChanges)
                    {
                        DialogResult closeResult = MessageBox.Show("An error occurred while saving the changes. Do you still wish to close this window?", "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                        if (closeResult == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                    }
                }
            }
        }
    }
}
