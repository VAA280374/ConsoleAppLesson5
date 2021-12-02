using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[7];
            double vSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите элемент {0} массива ", i);
                array[i] = Convert.ToDouble(Console.ReadLine());
                vSum = vSum + array[i];
            }
            Console.WriteLine("Длина массива = {0}", array.Length);
            vSum = vSum / array.Length;
            Console.WriteLine("Среднее арифметическое массива {0}", vSum);
            
            Console.ReadKey();
        }
    }
}
