using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delenenacelichisla
{
    class delenenacelichisla
    {
        static void Main(string[] args)
        {
            byte count = byte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                int delimo = int.Parse(Console.ReadLine());
                int delitel = int.Parse(Console.ReadLine());
                sum = sum + delimo % delitel;
            }
            Console.WriteLine(sum);

        }
    }
}
