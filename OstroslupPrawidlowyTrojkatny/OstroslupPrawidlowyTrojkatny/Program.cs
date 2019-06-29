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

                if (PoleBoczne(podstawa, H) > 0)
                {
                    Console.WriteLine("Pole podstawy wynosi: " + Math.Round(PolePodstawy(podstawa)));
                    Console.WriteLine("Pole boczne wynosi: " + Math.Round(PoleBoczne(podstawa, H)));
                    Console.WriteLine("Pole całkowite wynosi: " + Math.Round(PoleCalkowite));
                    Console.WriteLine("Objetość wynosi: " + Math.Round(Objetosc(PolePodstawy(podstawa), H)));
                }
            }
            else
            {
                Console.WriteLine("Wartości muszą być dodatnie!");
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
            double b = a / 3;
            double c = Math.Pow(b,2) + Math.Pow(wysokosc, 2);
            double ScianaBocznaWysokosc = Math.Sqrt(c);
            double wynik;
            if (Math.Pow(ScianaBocznaWysokosc, 2) == c)
            {
                double Pb = (a * ScianaBocznaWysokosc) / 2;
                return wynik = Pb * 3;
            }
            else
            {
                return -1;
            }            
        }

        public static double Objetosc(double PP, double H)
        {
            double V;

            V = (PP * H)/3;
            return V;
        }
    }
}
