using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2022
{
    internal class Dec4
    {
        public static void run()
        {
            List<string> sections = ReadFile.FileToList("dec4.txt");
            int numberOfRedundancies = 0, numberOfOverlaps = 0;
            foreach (string section in sections)
            {
                var currentSections = section.Split(',');
                var elf1 = currentSections[0].Split("-");
                var elf2 = currentSections[1].Split("-");

                if (    Convert.ToInt32(elf1[0]) <= Convert.ToInt32(elf2[0]) & Convert.ToInt32(elf1[1]) >= Convert.ToInt32(elf2[1])
                    ||  Convert.ToInt32(elf2[0]) <= Convert.ToInt32(elf1[0]) & Convert.ToInt32(elf2[1]) >= Convert.ToInt32(elf1[1]))
                {
                    numberOfRedundancies++;
                }
                if (    Convert.ToInt32(elf1[0]) <= Convert.ToInt32(elf2[0]) && Convert.ToInt32(elf2[0]) <= Convert.ToInt32(elf1[1])    
                    ||  Convert.ToInt32(elf1[0]) <= Convert.ToInt32(elf2[1]) && Convert.ToInt32(elf2[1]) <= Convert.ToInt32(elf1[1])    
                    ||  Convert.ToInt32(elf2[0]) <= Convert.ToInt32(elf1[0]) && Convert.ToInt32(elf1[0]) <= Convert.ToInt32(elf2[1])    
                    ||  Convert.ToInt32(elf2[0]) <= Convert.ToInt32(elf1[1]) && Convert.ToInt32(elf1[1]) <= Convert.ToInt32(elf2[1])
                    )
                {
                    numberOfOverlaps++;
                }


            }
            Console.WriteLine("d4p1 : " + numberOfRedundancies);
            Console.WriteLine("d4p2 : " + numberOfOverlaps);

        }
    }
}
