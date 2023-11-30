using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AoC2022
{
    internal class Dec6
    {
        public static void run()
        {
            findMarker(4,"1");
            findMarker(14,"2");
        }
        public static void findMarker(int x, string y)
        {
            List<string> signals = ReadFile.FileToList("dec6.txt");
            foreach (string signal in signals)
            {
                for (int i = x - 1; i < signal.Length; i++)
                {
                    string signalpart = signal.Substring(i - (x - 1), x);
                    if (signalpart.Distinct().Count() == x)
                    {
                        Console.WriteLine("d6p"+y+" : "+ (i + 1));
                        break;
                    }
                }
            }
        }
    }
}

