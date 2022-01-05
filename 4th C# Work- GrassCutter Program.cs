using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrassCuttingSkills
{
    class CutThemGrass
    {
        static void Main(string[] args)
        {
            //program to find out how to cut some grass.
            int blength, bwidth, hlength, hwidth, area1, area2, area3, time2cut;

            Console.WriteLine("Enter block length and width");
            Console.WriteLine("Enter house length and width");

            //read the measurements
            blength = int.Parse(Console.ReadLine());
            bwidth = int.Parse(Console.ReadLine());
            hlength = int.Parse(Console.ReadLine());
            hwidth = int.Parse(Console.ReadLine());

            area1 = blength + bwidth;
            area2 = hlength + hwidth;
            area3 = area1 - area2;

            time2cut = area3 / 2;

            Console.WriteLine("The time it takes to cut the grass is {0} ", time2cut);

            Console.ReadKey();
        }
    }
}
