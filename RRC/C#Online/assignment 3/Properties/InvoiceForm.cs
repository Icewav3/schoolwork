using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1.Properties
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            //Assembly assembly = Assembly.GetEntryAssembly();
            //String CompanyName = assembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
            CompanyNameLabel.Text = "RRC Automotive Group";
            AddressLabel.Text = "777 Inheritance Drive";
            CityProvicePostalLabel.Text = "Winnipeg, Manitoba, I0I 0I0";
            PhoneLabel.Text = "204-867-5309";
            DateLabel.Text = System.DateTime.Now.ToShortDateString();
        }
    }
}
