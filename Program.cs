using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dprinter_gcode
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //x/y unit = 10 um
                //z unit = 50 um
                Console.WriteLine("Your X Value:");
                decimal x = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Your Y Value:");
                decimal y = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Your Z Value:");
                decimal z = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Your G Value:");
                int g = int.Parse(Console.ReadLine());
                decimal e = 850 / 100;
                decimal k = 0;
                if (g == 1)
                {

                    for (decimal i = 0; i < z; i += 0.005m)
                    {
                        for (decimal j = 0; j < y; j += 0.001m)
                        {
                            while (k < x)
                            {
                                k += 0.001m;
                                //e go!
                            }

                        }
                    }
                }

            }
        }
}
