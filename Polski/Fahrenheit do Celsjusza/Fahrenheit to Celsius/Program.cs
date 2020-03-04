using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit_do_Celsjusza
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("Podaj temperaturę w celsjuszach, a zamienie ci ją na fahrenheita");
            int Celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("Ta temperatura wynosi w fahrenheicie :");
            Console.WriteLine((Celsius * 1.8) + 32);
            Console.ReadKey();
        }
    }
}
