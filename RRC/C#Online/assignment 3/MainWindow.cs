using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            salesQuoteToolStripMenuItem.Click += SalesQuoteToolStripMenuItem_Click;
            carWashToolStripMenuItem.Click += CarWashToolStripMenuItem_Click;
            vehicleToolStripMenuItem.Click += vehicleToolStripMenuItem_Click;
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleData vehicle = new frmVehicleData();
            if (!vehicle.IsDisposed)
            {
                vehicle.Show();
            } 
        }

        private void CarWashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarWash carWash = new frmCarWash();
            carWash.MdiParent = this;
            if (!carWash.IsDisposed)
            {
                carWash.Show();
            }
        }

        private void SalesQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesQuote salesQuote = new frmSalesQuote();
            salesQuote.MdiParent = this;
            salesQuote.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
