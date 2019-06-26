using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stozek
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, L;

            Console.WriteLine("Wprowadz R i L");
            string[] numbers = Console.ReadLine().Split();

            R = Convert.ToDouble(numbers[0]);
            L = Convert.ToDouble(numbers[1]);

            double H;
            if(R >= -1000000 && R <= 1000000 && L >= -1000000 && L <= 1000000)
            {
                if( R<0 || L<0)
                {
                    Console.WriteLine("ujemny argument");
                }
                else
                {
                    H = TwierdzeniePitagorasa(R, L);

                    if ((Math.Pow(R, 2) + Math.Pow(H, 2)) == Math.Pow(L, 2))
                    {
                        Console.WriteLine(Math.Floor(ObjetoscStozka(R, TwierdzeniePitagorasa(R,L))) + " " + Math.Round(ObjetoscStozka(R, TwierdzeniePitagorasa(R,L)), 0));
                    }
                    else
                    {
                        Console.WriteLine("obiekt nie istnieje");
                    }
                }
            }
            else
            {
                Console.WriteLine("Liczby całkowite spoza zakresu");
            }
        }

        static public double TwierdzeniePitagorasa(double a, double b)
        {
            double r, wynik;
            r = ((Math.Pow(a, 2)) - (Math.Pow(b, 2))) * (-1);
            wynik = Math.Sqrt(r);

            return wynik;
        }

        static public double ObjetoscStozka(double podstawa, double wysokosc)
        {
            double wynik;
            wynik = ((Math.Pow(podstawa, 2)) * 3.14 * wysokosc) / 3;

            return wynik;
        }
    }
}
