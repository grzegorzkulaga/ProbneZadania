using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica2dMinMaxWiersz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab3 = new int[3][];
            tab3[0] = new int[2] { 2, 1 };
            tab3[1] = new int[5] { 3, 6, 2, 4, 3 };
            tab3[2] = new int[4] { 1, 4, 6, 2 };


            test2(tab3);
        }

        static void test2(int[][] tab)
        {
            wyswietlTablice(tab);
            Console.WriteLine("MINIMUM:");
            Console.WriteLine(min(tab, 2));
            Console.WriteLine("MAXIMUM:");
            Console.WriteLine(max(tab, 2));

        }
        static void wyswietlTablice(int[][] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write(tab[i][j]);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int min(int[][] tab, int numerKolumny)
        {
            if (numerKolumny > tab.Length && numerKolumny < 0)
            {
                return 0;
            }
            return min(tab[numerKolumny]);
        }
        static int max(int[][] tab, int numerKolumny)
        {
            if (numerKolumny > tab.Length && numerKolumny < 0)
            {
                return 0;
            }
            return max(tab[numerKolumny]);
        }

        static int min(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }
            int minimum = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < minimum)
                {
                    minimum = tab[i];
                }
            }
            return minimum;
        }
        static int max(int[] tab)
        {
            if (tab.Length == 0)
            {
                return 0;
            }
            int maximum = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > maximum)
                {
                    maximum = tab[i];
                }
            }
            return maximum;
        }
    }
}
