using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hex
{
    class hexd
    {
        static void Main(string[] args)
        {
            int hex = 0xFE;
            int dec = 254;

            if (hex == dec)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
