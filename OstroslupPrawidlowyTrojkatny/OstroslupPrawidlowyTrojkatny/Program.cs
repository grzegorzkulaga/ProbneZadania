using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstroslupPrawidlowyTrojkatny
{
    class Program
    {
        static void Main(string[] args)
        {
            double podstawa, H;

            Console.Write("Wprowadz długość podstawy: ");
            podstawa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wprowadź wysokość: ");
            H = Convert.ToDouble(Console.ReadLine());

            if(podstawa>0 && H>0)
            {
                double PoleCalkowite;
                PoleCalkowite = PolePodstawy(podstawa) + PoleBoczne(podstawa, H);

                Console.WriteLine("Pole podstawy wynosi: " + Math.Round(PolePodstawy(podstawa)));
                Console.WriteLine("Pole boczne wynosi: " + Math.Round(PoleBoczne(podstawa, H)));
                Console.WriteLine("Pole całkowite wynosi: " + Math.Round(PoleCalkowite));
            }
        }

        public static double PolePodstawy(double a)
        {
            double Pp;
            Pp = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;

            return Pp;
        }

        public static double PoleBoczne(double a, double wysokosc)
        {
            //dzielimy trojkat podstawy na 1/3 i 2/3
            double b = (1 / 3) * a;
            double c = Math.Pow(a,2) + Math.Pow(b, 2);
            double ScianaBocznaWysokosc = Math.Sqrt(c);

            double Pb = (a * ScianaBocznaWysokosc) / 2;
            double wynik = Pb / 3;

            return wynik;
        }
    }
}
