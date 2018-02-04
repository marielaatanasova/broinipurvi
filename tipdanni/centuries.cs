using System;


namespace tipdanni
{
    class centuries
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            long hours = 24 * days;
            ulong minutes = (ulong)hours * 60;

            Console.WriteLine($"centuries = {centuries} years = {years} days = {days} hours= {hours} minutes= {minutes}");
            byte counter = 0;
            for (int i = 0; i < 260; i++)
            {
                counter++;
                Console.WriteLine(i);
            }
        }
    }
}
