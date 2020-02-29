using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBliczaniePolaTrapezu
{
    class Program
    {
        static void Main(string[] args)
        {
            int wynik;
            Console.WriteLine("Podaj względne h, a, b. A obliczę ci pole trapezu");
            Console.WriteLine("Podaj względną h");
            int wartoscZKlawiatury = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj względną a");
            int wartoscZKlawiatury1 = int.Parse(Console.ReadLine());
            Console.WriteLine("A teraz Względną b");
            int wartoscZKlawiatury2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pole Wynosi:");
            Console.WriteLine(0.5 * wartoscZKlawiatury * (wartoscZKlawiatury1 + wartoscZKlawiatury2));
            Console.ReadKey();
        }
    }
}