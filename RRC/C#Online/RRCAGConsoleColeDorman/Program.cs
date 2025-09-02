using System;
using Dorman.Cole.Business;

namespace RRCAGConsoleColeDorman
{  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing instantiating a salesquote");
            SalesQuote salesquote1 = new SalesQuote(20000, 10, 60000);
            Console.WriteLine("test 1\nExpected: 20000");
            Console.WriteLine("Actual: "+salesquote1.getVehicleSalePrice()+"\n");

            Console.WriteLine("testing set/get VehicleSalePrice");
            salesquote1.setVehicleSalePrice(50);
            Console.WriteLine("test 2\nExpected: 50");
            Console.WriteLine("Actual: " + salesquote1.getVehicleSalePrice() + "\n");

            Console.WriteLine("testing set/get ExteriorFinishChosen");
            salesquote1.setExteriorFinishChosen(SalesQuote.ExteriorFinish.Custom);
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
            salesquote1.setAccessoriesChosen(SalesQuote.Accessories.ComputerNavigation);
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
        }
    }
}
