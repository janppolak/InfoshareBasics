using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoshare.Basics.Classes
{
    internal class Calculator
    {
        private double _number1;
        private double _number2;

        public Calculator(double number1, double number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public double Sum(out string message)
        {
            message = "Wywołano metodę Sum";
            return _number1 + _number2;
        }
        public double Sub(out string message)
        {
            message = "Wywołano metodę Sub";
            return _number1 - _number2;
        }
        public double Multiply(out string message)
        {
            message = "Wywołano metodę Multiply";
            Console.WriteLine(message);
            return _number1 * _number2;
        }
        public double Div(out string message)
        {
            if (_number2 == 0)
            {
                message = "Nie wolno dzielić przez 0";
                return 0;
            }
            message = "Wywołano metodę Div";
            return _number1 / _number2;
        }
    }
}
