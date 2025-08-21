using System;
using System.Runtime;
using System.Collections.Generic;
using Dorman.Cole.Business;


namespace RRCAGAppColeDorman //new program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 3 for assignment 3 and 4 for assignment 4");
            if (Console.ReadKey().Key == ConsoleKey.D4)
            {
                stuff();
            }
            Console.WriteLine("testing instantiating a service invoice\n");
            ServiceInvoice ServiceInvoice1 = new ServiceInvoice(0.1m, 0.2m);
            Console.WriteLine("test 1\nExpected: 0.1");
            Console.WriteLine("Actual: " + ServiceInvoice1.ProvincialSalesTaxRate + "\n");
            Console.WriteLine("test 2\nExpected: 0.2");
            Console.WriteLine("Actual: " + ServiceInvoice1.GoodsAndServicesTaxRate + "\n");

            Console.WriteLine("testing adding costs\n");
            ServiceInvoice1.AddCost(CostType.Labour, 100);
            ServiceInvoice1.AddCost(CostType.Material, 300);
            ServiceInvoice1.AddCost(CostType.Part, 50);
            Console.WriteLine("test labour cost\nExpected: 100");
            Console.WriteLine("Actual: " + ServiceInvoice1.LabourCost + "\n");
            Console.WriteLine("test material cost\nExpected: 300");
            Console.WriteLine("Actual: " + ServiceInvoice1.MaterialsCost + "\n");
            Console.WriteLine("test part cost\nExpected: 50");
            Console.WriteLine("Actual: " + ServiceInvoice1.PartsCost + "\n");
            Console.WriteLine("test subtotal\nExpected: 450");
            Console.WriteLine("Actual: " + ServiceInvoice1.Subtotal + "\n");
            Console.WriteLine("test total\nExpected: 575");
            Console.WriteLine("Actual: " + ServiceInvoice1.Total + "\n");

            Console.WriteLine("\nService Invoice testing complete\n");
            Console.WriteLine("testing instantiating a car wash invoice\n");
            CarWashInvoice CarWashInvoice1 = new CarWashInvoice(0.25m, 0.7m, 200m, 300m);
            Console.WriteLine("test 1\nExpected: 0.25");
            Console.WriteLine("Actual: " + CarWashInvoice1.ProvincialSalesTaxRate + "\n");
            Console.WriteLine("test 2\nExpected: 0.7");
            Console.WriteLine("Actual: " + CarWashInvoice1.GoodsAndServicesTaxRate + "\n");
            Console.WriteLine("test 3\nExpected: 200");
            Console.WriteLine("Actual: " + CarWashInvoice1.PackageCost + "\n");
            Console.WriteLine("test subtotal\nExpected: 500");
            Console.WriteLine("Actual: " + CarWashInvoice1.Subtotal + "\n");
            Console.WriteLine("test total\nExpected: 925");
            Console.WriteLine("Actual: " + CarWashInvoice1.Total + "\n");
            CarWashInvoice1.PackageCost = 150.0m;
            Console.WriteLine("test change packageCost\nExpected: 150");
            Console.WriteLine("Actual: " + CarWashInvoice1.PackageCost + "\n");
            CarWashInvoice1.FragranceCost = 774.0m;
            Console.WriteLine("test change FragranceCost\nExpected: 774");
            Console.WriteLine("Actual: " + CarWashInvoice1.FragranceCost + "\n");
            Console.WriteLine("test change GetPayment of carwashinvoice1 total\nExpected: 208.37");
            Console.WriteLine("Actual: " + Financial.GetPayment(0.2m, 12, 925) + "\n");

            Console.ReadKey();
        }
        public static void stuff()
        {
            Console.WriteLine("testing instantiating a salesquote");
            SalesQuote salesquote1 = new SalesQuote(20000, 10, 60000);
            Console.WriteLine("test 1\nExpected: 20000");
            Console.WriteLine("Actual: "+salesquote1.VehicleSalePrice+"\n");

            salesquote1.VehiclePriceChanged += buttonPrice; //called subscribing
            salesquote1.ExteriorFinishChosenChanged += buttonExt;
            salesquote1.TradeInAmountChanged += buttonTradein;
            salesquote1.AccessoriesChosenChanged += buttonAccessories;

            Console.WriteLine("testing set/get VehicleSalePrice");
            salesquote1.VehicleSalePrice=50;
            Console.WriteLine("test 2\nExpected: 50");
            Console.WriteLine("Actual: " + salesquote1.VehicleSalePrice + "\n");

            Console.WriteLine("testing set/get ExteriorFinishChosen");
            salesquote1.setExteriorFinishChosen(ExteriorFinish.Custom);
            Console.WriteLine("test 3\nExpected: Custom");
            Console.WriteLine("Actual: " + salesquote1.getExteriorFinishChosen() + "\n");

            Console.WriteLine("testing get ExteriorFinishCost");
            Console.WriteLine("test 4\nExpected: 606.06");
            Console.WriteLine("Actual: " + salesquote1.getExteriorFinishCost() + "\n");

            Console.WriteLine("testing set/get TradeInAmount");
            salesquote1.setTradeInAmount(800.50M);
            Console.WriteLine("test 5\nExpected: 800.50");
            Console.WriteLine("Actual: " + salesquote1.getTradeInAmount() + "\n");

            Console.WriteLine("testing set/get AccessoriesChosen");
            salesquote1.setAccessoriesChosen(Accessories.ComputerNavigation);
            Console.WriteLine("test 6\nExpected: ComputerNavigation");
            Console.WriteLine("Actual: " + salesquote1.getAccessoriesChosen() + "\n");

            Console.WriteLine("testing get AccessoriesChosenCost");
            Console.WriteLine("test 7\nExpected: 1515.15");
            Console.WriteLine("Actual: " + salesquote1.getAccessoriesCost() + "\n");

            Console.WriteLine("testing get Subtotal");
            Console.WriteLine("test 8\nExpected: 2121.21");
            Console.WriteLine("Actual: " + salesquote1.GetSubTotal() + "\n");

            Console.WriteLine("testing get/set salestax");
            salesquote1.setSalesTax(0.1M);
            Console.WriteLine("test 9\nExpected: 212.121");
            Console.WriteLine("Actual: " + salesquote1.GetSalesTax() + "\n");

            Console.WriteLine("testing get Total");
            Console.WriteLine("test 10\nExpected: 2333.331");
            Console.WriteLine("Actual: " + salesquote1.GetTotal() + "\n");

            Console.WriteLine("testing GetAmountDue");
            Console.WriteLine("test 11\nExpected: 1532.831");
            Console.WriteLine("Actual: " + salesquote1.GetAmountDue() + "\n");

            Console.ReadKey();
        }
        public static void buttonPrice(object sender, EventArgs e)
        {
            Console.WriteLine("#############price has changed#################");
        }
        public static void buttonExt(object sender, EventArgs e)
        {
            Console.WriteLine("#############Exterior finish has changed#################");
        }
        public static void buttonTradein(object sender, EventArgs e)
        {
            Console.WriteLine("#############Trade in amount has changed#################");
        }
        public static void buttonAccessories(object sender, EventArgs e)
        {
            Console.WriteLine("#############Accessories chosen have changed#################");
        }
    }
}
