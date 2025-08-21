using System;
using System.Collections.Generic;
using System.Text;

namespace Dorman.Cole.Business
{
    public class ServiceInvoice: Invoice //The LabourCost, PartsCost and MaterialCost properties have a private set accessor. <--- what
    {
        public decimal LabourCost { get; private set; }
        public decimal PartsCost { get; private set; }
        public decimal MaterialsCost { get; private set; }
        public ServiceInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate):base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {

        }

        public override decimal ProvincialSalesTaxCharged { get { return (PartsCost + MaterialsCost) * ProvincialSalesTaxRate; } }

        public override decimal GoodsAndServicesTaxCharged {
            get { return (LabourCost + PartsCost + MaterialsCost) * GoodsAndServicesTaxRate; }
        }

        public override decimal Subtotal { get { return (LabourCost + MaterialsCost + PartsCost); } }

        public void AddCost(CostType CostType, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("amount", "The argument cannot be less than or equal to 0.");
            switch (CostType)
            {
                case CostType.Labour:
                    LabourCost += amount;
                    break;
                case CostType.Material:
                    MaterialsCost += amount;
                    break;
                case CostType.Part:
                    PartsCost += amount;
                    break;
                default:
                    throw new System.ComponentModel.InvalidEnumArgumentException("The arguement is an invalid enumeration value");
            }
        }
    }
    public enum CostType
    {
        Labour = 0,
        Part = 1,
        Material = 2
    }
}
