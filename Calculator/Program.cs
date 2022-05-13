using Calculator.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new NumberModel();
            Console.WriteLine("Enter 1st input");
            model.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            model.y = Convert.ToInt32(Console.ReadLine());
            var result = Results(model.x, model.y); 
            Console.WriteLine(result.Addition);
            Console.WriteLine(result.Subtraction);
            Console.WriteLine(result.Multiplication);
            Console.WriteLine(result.Division);
            Console.ReadKey();
        }
        public static ResultsModel Results(decimal inputX, decimal inputY)
        {
            var model = new ResultsModel()
            {
                Addition = inputX + inputY,
                Subtraction = inputX - inputY,
                Multiplication = inputX * inputY,
                Division = inputX / inputY,
            };
            return model;
        }
    }
}