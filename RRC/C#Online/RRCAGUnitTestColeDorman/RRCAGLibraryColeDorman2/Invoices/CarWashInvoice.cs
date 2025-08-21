using System;
using System.Collections.Generic;
using System.Text;

namespace Dorman.Cole.Business
{
    public class CarWashInvoice : Invoice
    {
        private decimal packageCost;
        private decimal fragranceCost;
        public decimal PackageCost
        {
            get 
            {
                return this.packageCost;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0");
                this.packageCost = value;
            }
        }
        public decimal FragranceCost
        {
            get
            {
                return this.fragranceCost;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0");
                this.fragranceCost = value;
            }
        }
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return this.fragranceCost * ProvincialSalesTaxRate;
            }
        }
        public override decimal GoodsAndServicesTaxCharged{
            get
            {
                return (this.fragranceCost + this.packageCost) * GoodsAndServicesTaxRate;
            }
        }
        public override decimal Subtotal
        {
            get
            {
                return this.packageCost + this.fragranceCost;
            }
        }
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {

        }
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate, decimal packageCost, decimal fragranceCost) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            if (packageCost < 0)
                throw new ArgumentOutOfRangeException("packageCost", "The arguement cannot be less than 0");
            PackageCost = packageCost;
            if (fragranceCost < 0)
                throw new ArgumentOutOfRangeException("fragranceCost", "The arguement cannot be less than 0");
            FragranceCost = fragranceCost;
        }
    }
}
