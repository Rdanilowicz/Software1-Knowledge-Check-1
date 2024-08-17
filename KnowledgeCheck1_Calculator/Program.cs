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
            //Moved the methods for each action to their corresponding method in the calculator class. Each switch statement now calls a constructor for each depending on the input. 
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