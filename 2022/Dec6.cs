using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2022
{
    internal class Dec6
    {
        public static void dec6()
        {
            findMarker(4);
            findMarker(14);
        }
        public static void findMarker(int x)
        {
            List<string> signals = Files.ReadSimpleInput("dec6.txt");
            foreach (string signal in signals)
            {
                for (int i = x - 1; i < signal.Length; i++)
                {
                    string signalpart = signal.Substring(i - (x - 1), x);
                    if (signalpart.Distinct().Count() == x)
                    {
                        Console.WriteLine("First marker detected at " + (i + 1));
                        break;
                    }
                }
            }
        }
    }
}

