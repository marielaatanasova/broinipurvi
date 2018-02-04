    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preobrazuvanenaskorost
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var hours = byte.Parse(Console.ReadLine());
            var minutes = byte.Parse(Console.ReadLine());
            var seconds = byte.Parse(Console.ReadLine());
            int time = hours * 3600 + minutes * 60 + seconds;
            float speedms = (float)distance / time;
            Console.WriteLine($"{speedms}");
            float speedKHM = (float)(speedms * 3.6);
            Console.WriteLine($"{speedKHM}");
            float speedmiles = speedms * 3600f / 1609;
            Console.WriteLine($"{speedmiles}");
            




        }
    }
}
