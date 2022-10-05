using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_07._10
{
    internal class Program
    {
        static string Equation(double a, double b, double c)
        {

            double discrim = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(discrim) )/ (2 * a);
            double x2 = (-b - Math.Sqrt(discrim) )/ (2 * a);
            string result = "Корень 1: " + x1 + '\n' + "Корень 2: " + x2;  
            return result;



        }
        static void Main(string[] args)
        {
            string result;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            result = Equation(a, b, c);
            
            Console.WriteLine(result);
            
        }
    }
}
