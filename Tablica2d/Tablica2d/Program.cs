using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica2d
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Random losowa = new Random();

            Console.Write("Wprowadź rozmiar tablicy: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[,] tablica = new int[size, size];

            for(int i=0; i < size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    tablica[i, j] = losowa.Next(1, 10);
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\n");
                for(int j=0; j<size; j++)
                {
                    Console.Write(" " + tablica[i, j]);
                }
            }
            Console.WriteLine();

            int srednia = 0;
            int[] suma = new int[size];

            for(int i=0; i < size; i++)
            {

                for (int j=0; j<size; j++)
                {
                    suma[j] = suma[j] + tablica[i, j];
                }
            }

            Console.Write("\nSuma: ");
            for(int j=0; j<size; j++)
            {
                Console.Write(suma[j] + " ");
            }
            Console.WriteLine();

            Console.Write("Średnia: ");
            for (int j=0; j<size; j++)
            {
                suma[j] = suma[j] / size;
                Console.Write(suma[j] + " ");
            }
            Console.WriteLine();

            srednia = suma[0];
            for (int j=0; j<size; j++)
            {
                if(suma[j]<srednia)
                {
                    srednia = suma[j];
                }
            }
            Console.WriteLine("Najmniejsza średnia: " + srednia);
        }
    }
}
