using System;
using System.Collections.Generic;
using System.Text;

namespace Dorman.Cole.Business
{
    public static class Financial
    {
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods, decimal presentValue)
        {
            if (numberOfPaymentPeriods <= 0)
                throw new ArgumentOutOfRangeException("numberOfPaymentPeriods", "The argument cannot be less than or equal to 0");
            if (rate < 0)
                throw new ArgumentOutOfRangeException("rate", "The argument cannot be less than 0");
            if (rate > 1)
                throw new ArgumentOutOfRangeException("rate", "The argument cannot be greater than 1");
            if (presentValue <= 0)
                throw new ArgumentOutOfRangeException("presentValue", "The argument cannot be less than or equal to 0");
            
            decimal futureValue = 0;
            decimal type = 0;
            decimal payment = 0;

            if (rate == 0)
                payment = presentValue / numberOfPaymentPeriods;
            else
                payment = rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods)) /
                              (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));

            return Math.Round(payment, 2);
        }
    }
}
