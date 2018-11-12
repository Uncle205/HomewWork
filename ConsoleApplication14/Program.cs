using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 20;
            int sum = 0;
            double[] array = new double[n];
            for (int i = 0; i < n; i++) { array[i] = rnd.Next(0, 50); }
            int a = int.MinValue;
            int b = int.MinValue;
            foreach (int i in array)
            {
                if (i > a)
                {
                    b = a;
                    a = i;
                }
                else if (i > b)
                    b = i;

                if (i % 2 == 0) 
                    sum += i;
            }


            int index = Array.IndexOf(array, b);
            Console.WriteLine("Исходный массив");
            Print(array);
            Console.WriteLine("{0}-элемент, является вторым по величине = {1}", index + 1, b);
            BubbleSort(array);
            Console.WriteLine("Отсортированный массив");
            Print(array);


            Console.WriteLine("sum:" + sum);
            Console.ReadKey();
        }

        static void Print(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + @" ");
            Console.WriteLine();
        }
        public static void BubbleSort(double[] a)
        // Сортировка пузырьком
        {
            for (int i = 1; i <= a.Length - 1; ++i)
                for (int j = 0; j < a.Length - i; ++j)
                    if (a[j] < a[j + 1])
                        Swap(ref a[j], ref a[j + 1]);
        }



        public static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }
    }
}
