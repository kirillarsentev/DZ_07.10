using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;


enum level
{
    добрый = 1,
    слегка_ворчливый = 2,
    ворчливый = 3,
    очень_ворчливый = 4

}


struct grandfather
{
    private string name;
    private string[] saysomthing;
    private int numberOfBeats;
    private level kirillhuisos;
    public void put(string[] c, string d, int a)
    {
        name = d;
        saysomthing = c;
        numberOfBeats = 0;
        kirillhuisos = (level)a;

    }
    public void updateNumberOfBeats(int a)
    {
        numberOfBeats = a;
    }
    public void getName()
    {
        System.Console.WriteLine(name);
    }
    public void getSay()
    {
        int i = 0;
        while (i < saysomthing.Length)
        {
            System.Console.WriteLine(saysomthing[i]);
            i++;
        }
    }
    public void getSayLvl()
    {
        System.Console.WriteLine(kirillhuisos);
    }
    public void getNumberOfBeats()
    {
        System.Console.WriteLine(numberOfBeats);
    }

};

namespace DZ_07._10
{
    internal class Program
    {
        /*static int FindPivot(int[] massive, int minindex, int maxindex)
        {
            int pivot = minindex - 1;
            int temp = 0;
            for (int i = minindex; i < maxindex; i++)
            {
                if (massive[i] < massive[maxindex])
                {
                    pivot++;
                    temp = massive[pivot];
                    massive[pivot] = massive[i];
                    massive[i] = temp;
                }
            }
            pivot++;
            temp = massive[pivot];
            massive[pivot] = massive[maxindex];
            massive[maxindex] = temp;
            return pivot;
        }
        static int[] QuickSort(int[] massive, int minindex, int maxindex)
        {
            if (minindex >= maxindex)
            {
                return massive;
            }
            int pivot = FindPivot(massive, minindex, maxindex);
            QuickSort(massive, minindex, pivot - 1);
            QuickSort(massive, minindex, pivot + 1);
            return massive;
        }*/
        static string Equation(double a, double b, double c)
        {

            double discrim = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(discrim)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discrim)) / (2 * a);
            string result = "Корень 1: " + x1 + '\n' + "Корень 2: " + x2;
            return result;



        }
        static int[] Sort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            for (int k = 0; k < mas.Length; k++)
            {
                Console.Write(mas[k] + " ");
            }
            return mas;
        }


        static int Met3(ref int mult, out double ar, params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                mult = mult * array[i];

            }
            Console.WriteLine("Произведение : " + mult);
            ar = array.Sum() / array.Length;
            Console.WriteLine("Среднее арифметическое : " + ar);
            int sum = array.Sum();
            Console.WriteLine("Cумма");
            return sum;
        }
        static int Beats(string[] dedword)
        {
            string[] babkaword = { "олени", "чувырло", "титька тараканья", "жаба тошная", "хрен моржовый", "еклмн" };
            int count = 0;
            for (int i = 0; i < dedword.Length; i++)
            {
                for (int j = 0; j < babkaword.Length; j++)
                {
                    if (dedword[i] == babkaword[j])
                    {
                        count++;
                    }
                }

            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Дз.Задача 1");
            Console.WriteLine("Введите коэффициенты уравнения");
            string result;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            result = Equation(a, b, c);
            
            Console.WriteLine(result);

            Console.WriteLine("ДЗ.Задача 2");
            int[] mas = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                mas[i] = rnd.Next(0, 100);
                Console.Write(mas[i] + " ");
            }
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());  
            int index1 = Array.IndexOf(mas, num1);
            int index2 = Array.IndexOf(mas, num2);
            int per = mas[index1];
            mas[index1] = mas[index2];
            mas[index2] = per;
            for (int i = 0; i < 20; i++)
            {
          
                Console.Write(mas[i] + " ");
            }

            Console.WriteLine("ДЗ.Задача 3");
            int[] bubble = { 72, 12, 13, 19, 1, 28, 98, 14};
            Sort(bubble);

            Console.WriteLine("ДЗ.Задача4");
            int mult = 1;
            double ar = 1;
            int[] array = { 23, 4, 1, 2, 6, 7, 10, 8, 6, 3 };
            int sum = Met3(ref mult,out ar, array);
            Console.WriteLine(sum);


            Console.WriteLine("ДЗ.Задача 6");
            string[] dedword1 = { "чувырло", "еклмн" , "фотд", "олени"};
            grandfather one = new grandfather();
            one.put(dedword1, "Дед 1", 3);
            one.getName();
            one.updateNumberOfBeats(Beats(dedword1));
            one.getNumberOfBeats();
            level tt1 = (level)3;
            Console.WriteLine(tt1);


            string[] dedword2 = { "чувырло", "хрен моржовый", "титька тараканья", "жаба тошная" };
            grandfather two = new grandfather();
            two.put(dedword2, "Дед 2", 4);
            two.getName();
            two.updateNumberOfBeats(Beats(dedword2));
            two.getNumberOfBeats();
            level tt2 = (level)4;
            Console.WriteLine(tt2);


            string[] dedword3 = { "хрен моржовый", "еклмнtkjn", "олениknbwk", "klvner" };
            grandfather three = new grandfather();
            three.put(dedword3, "Дед 3", 1);
            three.getName();
            three.updateNumberOfBeats(Beats(dedword3));
            three.getNumberOfBeats();
            level tt3 = (level)1;
            Console.WriteLine(tt3);


            string[] dedword4 = { "akvme;bo", "жаба тошная", "олени" };
            grandfather four = new grandfather();
            four.put(dedword3, "Дед 4", 2);
            four.getName();
            four.updateNumberOfBeats(Beats(dedword4));
            four.getNumberOfBeats();
            level tt4 = (level)2;
            Console.WriteLine(tt4);

            string[] dedword5 = { "чувырло", "еклмн", "титька тараканья", "kngtnqon" };
            grandfather five = new grandfather();
            five.put(dedword3, "Дед 5", 1);
            five.getName();
            five.updateNumberOfBeats(Beats(dedword5));
            five.getNumberOfBeats();
            level tt5 = (level)1;
            Console.WriteLine(tt5);

            Console.WriteLine("Дз.Задача5");
            try
            {
                while (true)
                {
                    Console.WriteLine(" Введите числа");
                    string number = Console.ReadLine();
                    if (number == "exit" || number == "закрыть")
                    {
                        Environment.Exit(0);
                    }
                    if (int.Parse(number) < 0 || int.Parse(number) > 9)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Ошибка!!!");
                    }
                    
                    int number1 = Convert.ToInt32(number);
                    switch (number1)
                    {
                        case 0:
                            Console.WriteLine("###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###");
                            break;
                        case 1:
                            Console.WriteLine(" # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + "###");
                            break;
                        case 2:
                            Console.WriteLine(" # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "###");
                            break;
                        case 3:
                            Console.WriteLine("## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ");
                            break;
                        case 4:
                            Console.WriteLine("# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###");
                            break;
                        case 5:
                            Console.WriteLine("###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "## ");
                            break;
                        case 6:
                            Console.WriteLine(" ##" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###");
                            break;
                        case 7:
                            Console.WriteLine("###" + "\n" + "  #" + "\n" + "  #" + "\n" + " # " + "\n" + " # ");
                            break;
                        case 8:
                            Console.WriteLine("###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###");
                            break;
                        case 9:
                            Console.WriteLine("###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###");
                            break;
                    }

                }
            }
            catch
            { 

                Console.WriteLine("Вы ввели не число");
            }
            




            Console.WriteLine("ДЗ.Задача7");
            int[] inputArray = { 9, 12, 9, 2, 17, 1, 6 };

            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");
        }



        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;


        }


    }
}
