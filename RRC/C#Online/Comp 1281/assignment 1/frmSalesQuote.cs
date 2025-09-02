using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private SalesQuote salesQuote = null;
        public frmSalesQuote()
        {
            InitializeComponent();
            Calculate.Click += Calculate_Click;
            Reset.Click += Reset_Click;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            VehicleSalePrice.Clear();
            TradeInValue.Clear();
            TradeIn.Clear();
            VehicleSalePriceRead.Clear();
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
            decimal vehicleSalePrice = -1;
            decimal vehicleTradeInPrice;
            if (VehicleSalePrice.Text.Equals(""))
            {
                errorProvider.SetError(VehicleSalePrice, "Vehicle price is a required field.");
            }
            else if (!decimal.TryParse(VehicleSalePrice.Text, out vehicleSalePrice))
            {
                errorProvider.SetError(VehicleSalePrice, "Vehicle price cannot contain letters or special characters.");
            }
            else if (vehicleSalePrice < 0)
            {
                errorProvider.SetError(VehicleSalePrice, "Vehicle price cannot be less than or equal to 0.");
            }
            else if (TradeInValue.Text.Equals(""))
            {
                errorProvider.SetError(TradeInValue, "Trade-in value is a required field.");
            }
            else if (!decimal.TryParse(TradeInValue.Text, out vehicleTradeInPrice))
            {
                errorProvider.SetError(TradeInValue, "Trade-in value cannot contain letters or special characters.");
            }
            else if (vehicleTradeInPrice < 0)
            {
                errorProvider.SetError(TradeInValue, "Trade-in value cannot be less than 0.");
            }
            else if (vehicleTradeInPrice > vehicleSalePrice && vehicleSalePrice != -1)
            {
                errorProvider.SetError(TradeInValue, "Trade-in value cannot be greater than Sale Price");
            }
            else
            {
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
                salesQuote = new SalesQuote(vehicleSalePrice, vehicleTradeInPrice, 0.13M);
                salesQuote.setAccessoriesChosen(accessoriesChosen);
                salesQuote.setExteriorFinishChosen(extFinish);
                TradeIn.Text = "-" + salesQuote.getTradeInAmount().ToString("n");
                VehicleSalePriceRead.Text = vehicleSalePrice.ToString("n");
                SalesTax.Text = salesQuote.GetSalesTax().ToString("n");
                AmountDue.Text = salesQuote.GetAmountDue().ToString("n");
                Total.Text = salesQuote.GetTotal().ToString("c");
                Subtotal.Text = salesQuote.GetSubTotal().ToString("c");
                Options.Text = (salesQuote.getAccessoriesCost() + salesQuote.getExteriorFinishCost()).ToString();
                int payPer = Convert.ToInt32(numberYears.Value * 12);
                MonthlyPayment.Text = Financial.GetPayment(annualInterest.Value/12/100, payPer, salesQuote.GetAmountDue()).ToString();
            }
        }
    }
}
