using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przelicznikzlnaeuro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj kwotę w złotówkach, a ja ci podam w euro.");
            decimal kurs = 4.3M;
            decimal PLN = decimal.Parse(Console.ReadLine());
            decimal EUR = PLN / kurs;
            Console.WriteLine("ta kwota wynosi w Euro : {0:F}", EUR);
            Console.ReadKey();
        }
    }
}
