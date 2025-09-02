using System;
using System.Collections.Generic;
using System.Text;

namespace Dorman.Cole.Business
{
    public abstract class Invoice
    {
        private decimal provincialSalesTaxRate;
        private decimal goodsAndServicesTaxRate;

        public decimal ProvincialSalesTaxRate
        {
            get
            {
                return this.provincialSalesTaxRate;
            }
            set
            {
                if (value > 1)
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value", "The value cannot be greater than 1");
                this.provincialSalesTaxRate = value;
            }
        }
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return this.goodsAndServicesTaxRate;
            }
            set
            {
                if (value > 1)
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value", "The value cannot be greater than 1");
                this.goodsAndServicesTaxRate = value;
            }
        }
        public abstract decimal ProvincialSalesTaxCharged { get; } //no set - only get
        public abstract decimal GoodsAndServicesTaxCharged { get; }
        public abstract decimal Subtotal { get; }
        public decimal Total { get { return Subtotal + GoodsAndServicesTaxCharged + ProvincialSalesTaxCharged; } }
        //methods
        //constructor
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            if (provincialSalesTaxRate < 0)
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be less than 0.");
            if (provincialSalesTaxRate > 1)
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be greater than 1.");
            if (goodsAndServicesTaxRate < 0)
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be less than 0.");
            if (goodsAndServicesTaxRate > 1)
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be greater than 1.");
            this.provincialSalesTaxRate = provincialSalesTaxRate;
            this.goodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }
    }
}
