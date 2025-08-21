using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dorman.Cole.Business;
using System;

namespace Testproject1
{
    [TestClass]
    public class UnitTest1
    {
        //Service invoice testing

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoice_negativePST_throws()
        {
            new ServiceInvoice(-0.1m, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoice_negativeGST_throws()
        {
            new ServiceInvoice(0, -0.1m);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoice_positiveGST_throws()
        {
            new ServiceInvoice(0, 2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoice_positivePST_throws()
        {
            new ServiceInvoice(2, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoiceAddcost_negative_throws()
        {
            ServiceInvoice ServiceInvoice1 = new ServiceInvoice(0.1m, 0.1m);
            ServiceInvoice1.AddCost(CostType.Labour, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoiceAddcost_zero_throws()
        {
            ServiceInvoice ServiceInvoice1 = new ServiceInvoice(0.1m, 0.1m);
            ServiceInvoice1.AddCost(CostType.Labour, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ComponentModel.InvalidEnumArgumentException))]
        public void ServiceInvoiceAddcost_invalid_throws()
        {
            ServiceInvoice ServiceInvoice1 = new ServiceInvoice(0.1m, 0.1m);    
            ServiceInvoice1.AddCost((CostType) 5, 1); //interesting
        }

        //carwash invoice testing

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_PackageCost_negative_throws()
        {
            CarWashInvoice CarWashInvoice1 = new CarWashInvoice(0.1m, 0.1m);
            CarWashInvoice1.PackageCost = -1m;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_FragranceCost_negative_throws()
        {
            CarWashInvoice CarWashInvoice1 = new CarWashInvoice(0.1m, 0.1m);
            CarWashInvoice1.FragranceCost = -1m;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_NegativePST_throws()
        {
            new CarWashInvoice(-0.1m, 0.1m);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_PositivePST_throws()
        {
            new CarWashInvoice(2, 0.1m);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_PositiveGST_throws()
        {
            new CarWashInvoice(0.1m, 2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_NegativeGST_throws()
        {
            new CarWashInvoice(0.1m, -0.1m);
        }

    }
}
