using Dorman.Cole.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1
{
    using assignment_1.Properties;
    using Dorman.Cole.Business;
    using System;
    using System.Windows.Forms;

    public partial class frmCarWash : Form
    {
        public CarWashInvoice carWashInvoice;
        private KeyValuePair<string, decimal> ChosenFragrance;
        private Dictionary<string, decimal> packagePrices;
        private Dictionary<string, decimal> fragrancePrices;
        public frmCarWash()
        {
            InitializeComponent();
            InitializeData();
            SubscribeToEvents();
            this.carWashInvoice = new CarWashInvoice(0.25m, 0.7m, 0m, 0m);
            //Invoice Form constuctor
            generateInvoiceToolStripMenuItem.Click += GenerateInvoiceToolStripMenuItem_Click;
        }

        private void GenerateInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarWashInvoice frmCarWashInvoiceForm1 = new frmCarWashInvoice(this);
            frmCarWashInvoiceForm1.MdiParent = this.MdiParent;
            frmCarWashInvoiceForm1.Show();
        }

        private void InitializeData()
        {

            packagePrices = new Dictionary<string, decimal>
            {
                { "Standard", 7.50m },
                { "Deluxe", 15.00m },
                { "Executive", 35.00m },
                { "Luxury", 55.00m }
            };

            fragrancePrices = new Dictionary<string, decimal>
            {
            };
            //Attempt reading the file
            try
            {
                string fragrancesText = File.ReadAllText("Fragrances.txt");
                string[] fragrances = fragrancesText.Split(',');
                int n = 0;
                decimal cost;
                string fragranceName = "";
                foreach (string fragrance in fragrances)
                {
                    n += 1;
                    string trimmedFragrance = fragrance.Trim();
                    if (n % 2 == 0)
                    {
                        cost = decimal.Parse(trimmedFragrance);
                        fragrancePrices.Add(fragranceName, cost);
                    }
                    else
                    {
                        fragranceName = (trimmedFragrance);
                    }

                }
                // Set data source for Fragrance ComboBox
                FragDrop.DataSource = new BindingSource(fragrancePrices, null);
                FragDrop.DisplayMember = "Key";
                FragDrop.ValueMember = "Value";
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fragrances Data File not Found", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured While Reading the Data File", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
            }

            // Set data source for Package ComboBox
            PackDrop.DataSource = new BindingSource(packagePrices, null);
            PackDrop.DisplayMember = "Key";
            PackDrop.ValueMember = "Value";


        }

        private void SubscribeToEvents()
        {

            this.PackDrop.SelectedIndexChanged += new System.EventHandler(this.PackDrop_SelectedIndexChanged);
            this.FragDrop.SelectedIndexChanged += new System.EventHandler(this.FragDrop_SelectedIndexChanged);
        }

        private void PackDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            KeyValuePair<string, decimal> selectedPackage = (KeyValuePair<string, decimal>)comboBox.SelectedItem;
            string selectedItem = selectedPackage.Key;
            decimal cost = selectedPackage.Value;
            carWashInvoice.PackageCost = cost;
            UpdateTotals();
            PackBox.Items.Clear();
            switch (selectedPackage.Key)
            {
                case "Luxury":
                    PackBox.Items.Add("Fragrance " + ChosenFragrance.Key);
                    PackBox.Items.Add("Shampoo Carpets");
                    PackBox.Items.Add("Shampoo Upholstery");
                    PackBox.Items.Add("Interior Protection Coat");
                    break;
                case "Executive":
                    PackBox.Items.Add("Fragrance " + ChosenFragrance.Key);
                    PackBox.Items.Add("Shampoo Carpets");
                    PackBox.Items.Add("Shampoo Upholstery");
                    break;
                case "Deluxe":
                    PackBox.Items.Add("Fragrance " + ChosenFragrance.Key);
                    PackBox.Items.Add("Shampoo Carpets");
                    break;
                case "Standard":
                    PackBox.Items.Add("Fragrance " + ChosenFragrance.Key);
                    break;
                default:
                    break;
            }
            ExtBox.Items.Clear();

            // Populate the Package ListBox based on the selected package
            switch (selectedPackage.Key)
            {
                case "Luxury":
                    ExtBox.Items.Add("Hand Wash");
                    ExtBox.Items.Add("Hand Wax");
                    ExtBox.Items.Add("Wheel Polish");
                    ExtBox.Items.Add("Detail Engine Compartment");
                    break;
                case "Executive":
                    ExtBox.Items.Add("Hand Wash");
                    ExtBox.Items.Add("Hand Wax");
                    ExtBox.Items.Add("Wheel Polish");
                    break;
                case "Deluxe":
                    ExtBox.Items.Add("Hand Wash");
                    ExtBox.Items.Add("Hand Wax");
                    break;
                case "Standard":
                    ExtBox.Items.Add("Hand Wash");
                    break;
                default:
                    break;
            }
        }

        private void FragDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            KeyValuePair<string, decimal> selectedFragrance = (KeyValuePair<string, decimal>)comboBox.SelectedItem;
            string selectedItem = selectedFragrance.Key;
            decimal cost = selectedFragrance.Value;
            carWashInvoice.FragranceCost = cost;
            UpdateTotals();
            ChosenFragrance = selectedFragrance;
        }

        private decimal GetCost(string selectedItem)
        {
            decimal cost = 0m;
            switch (selectedItem)
            {
                case "Basic":
                    cost = 50m;
                    break;
                case "Silver":
                    cost = 75m;
                    break;
                case "Gold":
                    cost = 100m;
                    break;
                case "Platinum":
                    cost = 125m;
                    break;
                case "None":
                    cost = 0m;
                    break;
                case "Regular":
                    cost = 25m;
                    break;
                case "Deluxe":
                    cost = 50m;
                    break;
                case "Pine":
                    cost = 0m;
                    break;
            }
            return cost;
        }

        private void UpdateTotals()
        {
            decimal subtotal = carWashInvoice.Subtotal;
            decimal pst = carWashInvoice.ProvincialSalesTaxCharged;
            decimal gst = carWashInvoice.GoodsAndServicesTaxCharged;
            decimal total = carWashInvoice.Total;

            this.SubtotalBox.Text = subtotal.ToString("C");
            this.PSTBox.Text = pst.ToString("C");
            this.GSTBox.Text = gst.ToString("C");
            this.TotalBox.Text = total.ToString("C");
        }
        public decimal GetInvoiceSubtotal()
        {
            return carWashInvoice.Subtotal;
        }
        public decimal GetInvoiceFragrancel()
        {
            return carWashInvoice.FragranceCost;
        }
        public decimal GetInvoiceTaxes()
        {
            return carWashInvoice.GoodsAndServicesTaxCharged + carWashInvoice.ProvincialSalesTaxCharged;
        }
        public decimal GetInvoiceTotal()
        {
            return carWashInvoice.Total;
        }
    }
}