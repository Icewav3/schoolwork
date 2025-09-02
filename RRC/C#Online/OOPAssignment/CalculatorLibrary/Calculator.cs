using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Calculator //I did this so that I could access the number1 & 2 from InputNumber
    {
        //fields
        public InputNumber number1 = new InputNumber();
        public InputNumber number2 = new InputNumber();
        public InputNumber expectedResult = new InputNumber();
        public string operation;
        private bool isCorrect;


        //properties

        public bool IsCorrect
        {
            get
            {
                return this.isCorrect;
            }
            private set
            {
                isCorrect = value;
            }
        }
        public string Operation
        {
            get
            {
                return this.operation;
            }
            set
            {
                List<String> allowedSet = new List<string> { "+", "-", "*", "/", "x" };
                if (!allowedSet.Contains(value.ToLower()))
                    throw new Exception("Use valid operation type");
                this.operation = value.ToLower(); 
            }
        }
        //calculation method
        public decimal Calculate()
        {
            decimal result = 0;
            if (!number1.Valid)
                throw new ArgumentException("invalid arguement", "number1");
            if (!number2.Valid)
                throw new ArgumentException("invalid arguement", "number2");
            if (!expectedResult.Valid)
                throw new ArgumentException("invalid arguement", "expectedResult");
            switch (this.Operation)
            {
                case "+":
                    result = (number1.Number + number2.Number);
                    break;
                case "-":
                    result = (number1.Number - number2.Number);
                    break;
                case "x": case "*":
                    result = (number1.Number * number2.Number);
                    break;
                case "/":
                    result = (number1.Number / number2.Number);
                    break;
                default:
                    throw new ArgumentException("invalid arguement", "Operation");
            }
            isCorrect = (expectedResult.Number == result);
            return result;
        }
    }
}
