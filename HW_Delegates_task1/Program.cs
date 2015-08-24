using System;

namespace HW_Delegates_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter first double number");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, enter the sign of operation +, -, * or /");
            string sign = Console.ReadLine();
            Console.WriteLine("Please, enter second double number");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            Calculator calculator = new Calculator();
 
            try
            {
                Console.WriteLine(String.Format("The result of the operation is {0}", calculator.Calculate(operand1, operand2, sign)));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid sign.");
            }
            
            Console.ReadKey();
        }
    }
}
