using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment;

namespace OOPAssignment
{
    public class InputNumber:Input
    {
        private decimal number;
        public decimal Number
        {
            get
            {
                return this.number;
            }
            set
            {
                number = value;
            }
        }
        protected override void Validate(string value) 
        {
            try { number = int.Parse(value); valid = true; }
            catch { number = 0; valid = false; }
            Valid = valid;
        }
    }
}
