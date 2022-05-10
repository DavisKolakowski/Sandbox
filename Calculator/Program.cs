using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new DataModel();
            Console.WriteLine("Enter 1st input");
            model.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            model.y = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            result = Addition(model.x, model.y);           
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
        //Addition  
        public static int Addition(int inputX, int inputY)
        {
            int result = inputX + inputY;
            return result;
        }
    }
}