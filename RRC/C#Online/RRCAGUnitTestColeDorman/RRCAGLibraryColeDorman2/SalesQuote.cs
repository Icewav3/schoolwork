using System;

namespace Dorman.Cole.Business
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class SalesQuote
    {
        private decimal vehicleSalePrice;
        private decimal tradeInAmount;
        private decimal salesTaxRate;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;

        public event EventHandler VehiclePriceChanged;

        public decimal VehicleSalePrice
        {
            get
            {
                return this.vehicleSalePrice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than or equal to 0.");
                }
                if (this.vehicleSalePrice != value)
                {
                    this.vehicleSalePrice = value;
                    OnVehiclePriceChanged();
                } 
            }
        }

        private void OnVehiclePriceChanged()
        {
            if (VehiclePriceChanged != null) {
            VehiclePriceChanged(this, new EventArgs());
            }
        }
        private void TradeInAmountChanged()
        {
            if (VehiclePriceChanged != null)
            {
                VehiclePriceChanged(this, new EventArgs());
            }
        }
        private void AccessoriesChosenChanged()
        {
            if (VehiclePriceChanged != null)
            {
                VehiclePriceChanged(this, new EventArgs());
            }
        }
        private void ExteriorFinishChosenChanged()
        {
            if (VehiclePriceChanged != null)
            {
                VehiclePriceChanged(this, new EventArgs());
            }
        }

        //public decimal VehicleSalePriceTest{ get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicleSalePrice">the selling price of the vehicle being sold</param>
        /// <param name="tradeInAmount">the amount offered to the customer for the trade in of their vehicle</param>
        /// <param name="salesTaxRate">the tax rate applied to the sale of a vehicle</param>
        /// <param name="accessoriesChosen">the value of the chosen accessories</param>
        /// <param name="exteriorFinishChosen">the value of the chosen exterior finish</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen = Accessories.None, ExteriorFinish exteriorFinishChosen = ExteriorFinish.None)
        {
            //accessoriesChosen and exteriorFinishChosen defaults to none if the constructor is not given an argument, this is done to avoid having a second constructor
            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }
        //methods
        public void setSalesTax(decimal tax) //change me to properties
        {
            this.salesTaxRate = tax;
        }

        public decimal getTradeInAmount()
        {
            return this.tradeInAmount;
        }

        public void setTradeInAmount(decimal price)
        {
            this.tradeInAmount = price;
            TradeInAmountChanged(); //this good?
        }
        public Accessories getAccessoriesChosen()
        {
            return this.accessoriesChosen;
        }
        public void setAccessoriesChosen(Accessories accessories)
        {
            this.accessoriesChosen = accessories;
            AccessoriesChosenChanged(); //c
        }
        public ExteriorFinish getExteriorFinishChosen()
        {
            return this.exteriorFinishChosen;
        }
        public void setExteriorFinishChosen(ExteriorFinish extfinish)
        {
            this.exteriorFinishChosen = extfinish;
            ExteriorFinishChosenChanged();
        }
        public decimal getAccessoriesCost()
        {
            decimal cost;
            decimal stereo = 505.05M;
            decimal leather = 1010.10M;
            decimal compNav = 1515.15M;
            switch (this.accessoriesChosen)
            {
                case Accessories.StereoSystem:
                    cost = stereo;
                    break;
                case Accessories.LeatherInterior:
                    cost = leather;
                    break;
                case Accessories.StereoAndLeather:
                    cost = leather + stereo;
                    break;
                case Accessories.ComputerNavigation:
                    cost = compNav;
                    break;
                case Accessories.StereoAndNavigation:
                    cost = compNav + stereo;
                    break;
                case Accessories.LeatherAndNavigation:
                    cost = leather + compNav;
                    break;
                case Accessories.All:
                    cost = compNav + leather + stereo;
                    break;
                default:
                    cost = 0;
                    break;
            }
            return cost;
        }
        public decimal getExteriorFinishCost()
        {
            decimal cost;
            decimal Standard = 202.02M;
            decimal Pearlized = 404.04M;
            decimal Custom = 606.06M;
            switch (this.exteriorFinishChosen)
            {
                case ExteriorFinish.Custom:
                    cost = Custom;
                    break;
                case ExteriorFinish.Pearlized:
                    cost = Pearlized;
                    break;
                default:
                    cost = Standard;
                    break;
            }
            return cost;
        }

        public decimal GetSubTotal()
        {
            return (getExteriorFinishCost() + getAccessoriesCost());
        }
        public decimal GetSalesTax()
        {
            return salesTaxRate * GetSubTotal();
        }
        public decimal GetTotal()
        {
            return GetSubTotal() + GetSalesTax();
        }
        public decimal GetAmountDue()
        {
            return GetTotal() - getTradeInAmount();
        }
    }
    public enum Accessories //move outside if cannot refer
    {
        StereoSystem = 0,
        LeatherInterior = 1,
        StereoAndLeather = 2,
        ComputerNavigation = 3,
        StereoAndNavigation = 4,
        LeatherAndNavigation = 5,
        All = 6,
        None = 7
    }
    /// <summary>
    /// enumerators (repersents choice of accesory options)
    /// </summary>
    public enum ExteriorFinish
    {
        Standard = 0,
        Pearlized = 1,
        Custom = 2,
        None = 3
    }

}
