using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
            //Moved methods for calculation of addition, subtraction, multiplipication and division into the corresponding method in calculator class.
            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    calculator.Add();
                    break;

                case "2":
                    calculator.Subtract();
                    break;

                case "3":
                    calculator.Multiply();
                    break;

                case "4":
                    calculator.Divide();
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}