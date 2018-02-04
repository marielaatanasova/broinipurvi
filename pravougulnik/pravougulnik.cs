using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravougulnik
{
    class pravougulnik
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            decimal d =(decimal)( Math.Sqrt(a * a + b * b));
            Console.WriteLine(a*2 + b*2);
            Console.WriteLine(a*b);
            Console.WriteLine(d);
        }
    }
}
