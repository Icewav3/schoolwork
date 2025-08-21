using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public abstract class Input
    {
        protected bool valid;
        public bool Valid
        {
            get
            {
                return this.valid;
            }
            protected set
            {
                valid = value;
            }
        }
        protected abstract void Validate(string value);
        
        public void Enter(string value)
        {
            Validate(value);
        }
    }
}
