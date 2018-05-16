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
                //decimal eDiag = 1202.0815m / 100;
                decimal k = 0;
                if (g == 0 || g == 1)
                {

                    //formula to determine after how many horizontal steps we get a vertical step or vice versa

                    //if statement to determine the amount of extrution needed based on step direction
                    //horizonatl and vertical steps receive different amount of extrution than diagonal


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
