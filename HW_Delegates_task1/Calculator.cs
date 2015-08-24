using System;
using System.Collections.Generic;

namespace HW_Delegates_task1
{
    public class Calculator
    {
        private delegate double CalculatorAction(double op1, double op2);

        private Dictionary<string, CalculatorAction> _actionsMap = new Dictionary<string,CalculatorAction>();

        public Calculator()
        {
            _actionsMap.Add("+", (op1, op2) => { return op1 + op2; });
            _actionsMap.Add("-", (op1, op2) => { return op1 - op2; });
            _actionsMap.Add("*", (op1, op2) => { return op1 * op2; });
            _actionsMap.Add("/", (op1, op2) =>
            {
                if (op2 == 0)
                {
                    throw new DivideByZeroException("You can not divide by zero");
                }
                return op1 / op2;
            });
        }

        public double Calculate(double operand1, double operand2, string sign)
        {
            if (!_actionsMap.ContainsKey(sign))
            {
                throw new ArgumentException("This is not a valid sign");
            }
            return _actionsMap[sign](operand1, operand2);
        }
    }
}
