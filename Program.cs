using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список из 10 случайных чисел от -50 до 50");
            Console.WriteLine();
            const int N = 10;
            int[] number = new int[N];
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {

                number[i] = random.Next(-50, 50);
                Console.Write("{0,2} ", number[i]);

            }
            Console.WriteLine();

            //максимальное и минимальное значение 

            int max = number[0];
            foreach (int a in number)
            {
                if (a > max)
                    max = a;
            }
            int min = number[0];
            foreach (int b in number)
            {
                if (b < min)
                    min = b;
            }

            
            Console.WriteLine();
            Console.WriteLine("Наибольшее значение {0,2}", max);
            Console.WriteLine();
            Console.WriteLine("Наименьшее значение {0,2}", min);
            Console.WriteLine();

            //Числа в порядке возрастания

            for (int i = 0; i < N-1; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    if (number[i] > number[j]) // i > больше чем j
                    {
                        int v = number[i];
                        number[i] = number[j];
                        number[j] = v;
                    }
                }
            }
            
            Console.WriteLine("Первые 5 чисел в порядке возрастания");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,2} ", number[i]);
            }

            Console.WriteLine();

            //Числа в порядке убывания

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (number[i] < number[j]) // i < меньше чем j
                    {
                        int v = number[i];
                        number[i] = number[j];
                        number[j] = v;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Вторые 5 чисел в порядке убывания");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,2} ", number[i]);
            }


            Console.ReadKey();
        }
    }
}
