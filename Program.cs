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
                var listOfInstructions = new List<string>();
                var listOfValues = new List<decimal>();
                listOfInstructions.Add("Your X Value:");
                listOfInstructions.Add("Your Y Value:");
                listOfInstructions.Add("Your Z Value:");
                listOfInstructions.Add("Your G Value:");
                var instructions = listOfInstructions[0].Split(' ').ToList();

                foreach (var command in listOfInstructions)
                {
                    Console.WriteLine(command);
                    listOfValues.Add(decimal.Parse(Console.ReadLine()));
                }

                decimal valueX = listOfValues[0];
                decimal valueY = listOfValues[1];
                decimal valueZ = listOfValues[2];
                decimal valueG = listOfValues[3];


                //decimal extrudeStepsMm = 850 / 100;
                decimal valueToX = 0;

                if (valueG == 1)
                {

                    for (decimal valueToZ = 0; valueToZ < valueZ; valueToZ += 0.005m)
                    {
                        for (decimal valueToY = 0; valueToY < valueY; valueToY += 0.001m)
                        {
                            while (valueToX < valueX)
                            {
                                valueToX += 0.001m;
                                //e go!
                            }

                        }
                    }
                }

            }
        }
    }
}