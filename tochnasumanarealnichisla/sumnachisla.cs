﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochnasumanarealnichisla
{
    class sumnachisla
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum =+ decimal.Parse(Console.ReadLine());
                Console.WriteLine(sum);
            }
           
            
        }
    }
}
