using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Random zmienna = new Random();
            Console.WriteLine("Wprowadz rozmiar tablicy: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[,] tab = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    tab[i, j] = zmienna.Next(1, 100);
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
            }
            Console.WriteLine("");

            int[] min = new int[size];
            int[] max = new int[size];

            for (int i = 0; i < size; i++)
            {
                min[i] = tab[0, i];
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (tab[i, j] > max[j])
                    {
                        max[j] = tab[i, j];
                    }

                    if (tab[i, j] < min[j])
                    {
                        min[j] = tab[i, j];
                    }
                }
            }
            Console.WriteLine();

            Console.Write("Minimum: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(min[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Maximum: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(max[i] + " ");
            }
            Console.ReadLine();
        }
    }
}