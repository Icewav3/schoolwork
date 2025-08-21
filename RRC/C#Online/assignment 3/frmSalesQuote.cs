using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dorman.Cole.Business;

namespace assignment_1
{
    public partial class frmSalesQuote : Form
    {
        private decimal VehicleSalePrice;
        private SalesQuote salesQuote = null;
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;

        public frmSalesQuote()
        {
            InitializeComponent();
            Calculate.Click += Calculate_Click;
            Reset.Click += Reset_Click;

            connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AMDatabase.mdb";

            // DataAdapter
            dataAdapter = new OleDbDataAdapter();

            // Populate VehicleChosenComboBox with all the vehicles from the Database
            PopulateVehicleComboBox();

            // Add event handler for SelectedIndexChanged
            VehicleChosenComboBox.SelectedIndexChanged += VehicleChosenComboBox_SelectedIndexChanged;
        }

        private void PopulateVehicleComboBox()
        {
            try
            {
                connection.Open();
                string query = "SELECT StockNumber, Make + ' ' + Model AS MakeModel, BasePrice FROM VehicleStock";
                dataAdapter.SelectCommand = new OleDbCommand(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                VehicleChosenComboBox.DisplayMember = "MakeModel";
                VehicleChosenComboBox.ValueMember = "BasePrice";
                VehicleChosenComboBox.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating the vehicle list.{Environment.NewLine}Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void VehicleChosenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VehicleChosenComboBox.SelectedItem != null)
            {
                DataRowView selectedVehicle = (DataRowView)VehicleChosenComboBox.SelectedItem;
                VehicleSalePrice = Convert.ToDecimal(selectedVehicle["BasePrice"]);
                VehicleSalePriceRead.Text = VehicleSalePrice.ToString("n");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            // Clear all fields and reset checkboxes
            VehicleSalePriceRead.Clear();
            TradeInValue.Clear();
            TradeIn.Clear();
            SalesTax.Clear();
            AmountDue.Clear();
            Total.Clear();
            Subtotal.Clear();
            MonthlyPayment.Clear();
            Options.Clear();

            chkStereo.Checked = false;
            chkLeather.Checked = false;
            chkComputer.Checked = false;
            ExtStandard.Checked = true;
            ExtPearlized.Checked = false;
            ExtCustom.Checked = false;

            numberYears.Value = 1;
            annualInterest.Value = 5;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal vehicleTradeInPrice;

            if (VehicleChosenComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(TradeInValue.Text, out vehicleTradeInPrice))
            {
                MessageBox.Show("Trade-in value is invalid. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (vehicleTradeInPrice < 0)
            {
                MessageBox.Show("Trade-in value cannot be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (vehicleTradeInPrice > VehicleSalePrice)
            {
                MessageBox.Show("Trade-in value cannot be greater than the vehicle sale price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Accessories accessoriesChosen = Accessories.None;

            if (chkStereo.Checked && chkLeather.Checked)
            {
                accessoriesChosen = Accessories.StereoAndLeather;
            }
            else if (chkStereo.Checked && chkComputer.Checked)
            {
                accessoriesChosen = Accessories.StereoAndNavigation;
            }
            else if (chkLeather.Checked && chkComputer.Checked)
            {
                accessoriesChosen = Accessories.LeatherAndNavigation;
            }
            else if (chkStereo.Checked)
            {
                accessoriesChosen = Accessories.StereoSystem;
            }
            else if (chkLeather.Checked)
            {
                accessoriesChosen = Accessories.LeatherInterior;
            }
            else if (chkComputer.Checked)
            {
                accessoriesChosen = Accessories.ComputerNavigation;
            }

            ExteriorFinish extFinish = ExteriorFinish.Standard;

            if (ExtCustom.Checked)
            {
                extFinish = ExteriorFinish.Custom;
            }
            else if (ExtPearlized.Checked)
            {
                extFinish = ExteriorFinish.Pearlized;
            }

            salesQuote = new SalesQuote(VehicleSalePrice, vehicleTradeInPrice, 0.13M);
            salesQuote.setAccessoriesChosen(accessoriesChosen);
            salesQuote.setExteriorFinishChosen(extFinish);

            TradeIn.Text = "-" + salesQuote.getTradeInAmount().ToString("n");
            SalesTax.Text = salesQuote.GetSalesTax().ToString("n");
            AmountDue.Text = salesQuote.GetAmountDue().ToString("n");
            Total.Text = salesQuote.GetTotal().ToString("c");
            Subtotal.Text = salesQuote.GetSubTotal().ToString("c");
            Options.Text = (salesQuote.getAccessoriesCost() + salesQuote.getExteriorFinishCost()).ToString();

            int payPer = Convert.ToInt32(numberYears.Value * 12);
            MonthlyPayment.Text = Financial.GetPayment(annualInterest.Value / 12 / 100, payPer, salesQuote.GetAmountDue()).ToString();
        }
    }
}
