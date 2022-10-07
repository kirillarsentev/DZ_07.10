using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Program
    {
        static int Num(int x1, int x2)
        {
            if (x1 > x2)
            {
                return x1;
            }

            else
            {
                return x2;
            }


        
        }
        static void Num1(ref int a, ref int b)
        {
            int per;
            per = a;
            a = b;
            b= per;
        }

        static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n-1) + Fibonachi(n-2);
        }


        static void Main(string[] args)
        {

            /* 
             Console.WriteLine("Дз.Задача 5.1");
             Console.WriteLine("Введите 2 числа");
             int x1 = int.Parse(Console.ReadLine());
             int x2 = int.Parse(Console.ReadLine());
             Console.WriteLine(Num(x1, x2)); 


            Console.WriteLine("ДЗ.Задача 5.2");
            Console.WriteLine("Введите 2 числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Num1(ref a,ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.WriteLine("ДЗ.Задача 5.4");
            int fact1 = Factorial(1);
            int fact2 = Factorial(2);
            int fact3 = Factorial(3);
            int fact4 = Factorial(4);


            Console.WriteLine("Факториал 1 : " + fact1);
            Console.WriteLine("Факториал 2 : " + fact2);
            Console.WriteLine("Факториал 3 : " + fact3);
            Console.WriteLine("Факториал 4 : " + fact4);

            Console.WriteLine("ДЗ.Задача 5.1");

            int Fibo1 = Fibonachi(1);
            int Fibo2 = Fibonachi(2);
            int Fibo3 = Fibonachi(3);
            int Fibo4 = Fibonachi(4);
            int Fibo5 = Fibonachi(5);



            Console.WriteLine(Fibo1);
            Console.WriteLine(Fibo2);
            Console.WriteLine(Fibo3);
            Console.WriteLine(Fibo4);
            Console.WriteLine(Fibo5);*/

        }
    }
}
