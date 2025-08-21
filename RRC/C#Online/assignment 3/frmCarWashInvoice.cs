using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Dorman.Cole.Business;

namespace assignment_1
{
    public partial class frmCarWashInvoice : assignment_1.Properties.InvoiceForm
    {
        private frmCarWash carWashForm;

        public frmCarWashInvoice(frmCarWash carWashForm)
        {
            InitializeComponent();
            this.Text = "Car Wash Invoice";
            InvoiceTitleLabel.Text = "Car Wash Invoice";
            this.carWashForm = carWashForm;

            FragrancePriceLabel.Text = carWashForm.GetInvoiceFragrancel().ToString("C");
            PackagePriceLabel.Text = carWashForm.GetInvoiceSubtotal().ToString("C");
            TaxesLabel.Text = carWashForm.GetInvoiceTaxes().ToString("C");
            TotalPriceLabel.Text = carWashForm.GetInvoiceTotal().ToString("C");
            SubtotalLabel.Text = carWashForm.GetInvoiceSubtotal().ToString("C");
        }
    }
}
