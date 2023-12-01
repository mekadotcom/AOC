using AoC2023;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AOC2023
{
    internal class Dec1
    {
        public static void run()
        {
            List<string> codes = ReadFile.FileToList("dec1.txt");
            int sum = 0;
            int sum2 = 0;
            foreach (string code in codes)
            {
                string subsum = "", first = "", last = "";

                foreach (char x in code)
                {
                    if (first == "" & int.TryParse(Convert.ToString(x), out int n))
                    {
                        first = n.ToString();
                    }
                    if (int.TryParse(Convert.ToString(x), out int m))
                    {
                        last = m.ToString();
                    }
                    subsum = first + last;
                }
              sum += Convert.ToInt32(subsum);
            }
            Console.WriteLine("d1p1: " + sum);

            foreach (string code in codes)
            {              
                List<string> firstindexes = new List<string>();
                firstindexes.Add(code.IndexOf("1").ToString() + ":1");
                firstindexes.Add(code.IndexOf("2").ToString() + ":2");
                firstindexes.Add(code.IndexOf("3").ToString() + ":3");
                firstindexes.Add(code.IndexOf("4").ToString() + ":4");
                firstindexes.Add(code.IndexOf("5").ToString() + ":5");
                firstindexes.Add(code.IndexOf("6").ToString() + ":6");
                firstindexes.Add(code.IndexOf("7").ToString() + ":7");
                firstindexes.Add(code.IndexOf("8").ToString() + ":8");
                firstindexes.Add(code.IndexOf("9").ToString() + ":9");
                firstindexes.Add(code.IndexOf("one").ToString() + ":1");
                firstindexes.Add(code.IndexOf("two").ToString() + ":2");
                firstindexes.Add(code.IndexOf("three").ToString() + ":3");
                firstindexes.Add(code.IndexOf("four").ToString() + ":4");
                firstindexes.Add(code.IndexOf("five").ToString() + ":5");
                firstindexes.Add(code.IndexOf("six").ToString() + ":6");
                firstindexes.Add(code.IndexOf("seven").ToString() + ":7");
                firstindexes.Add(code.IndexOf("eight").ToString() + ":8");
                firstindexes.Add(code.IndexOf("nine").ToString() + ":9");

                List<string> lastindexes = new List<string>();
                lastindexes.Add(code.LastIndexOf("1").ToString() + ":1");
                lastindexes.Add(code.LastIndexOf("2").ToString() + ":2");
                lastindexes.Add(code.LastIndexOf("3").ToString() + ":3");
                lastindexes.Add(code.LastIndexOf("4").ToString() + ":4");
                lastindexes.Add(code.LastIndexOf("5").ToString() + ":5");
                lastindexes.Add(code.LastIndexOf("6").ToString() + ":6");
                lastindexes.Add(code.LastIndexOf("7").ToString() + ":7");
                lastindexes.Add(code.LastIndexOf("8").ToString() + ":8");
                lastindexes.Add(code.LastIndexOf("9").ToString() + ":9");
                lastindexes.Add(code.LastIndexOf("one").ToString() + ":1");
                lastindexes.Add(code.LastIndexOf("two").ToString() + ":2");
                lastindexes.Add(code.LastIndexOf("three").ToString() + ":3");
                lastindexes.Add(code.LastIndexOf("four").ToString() + ":4");
                lastindexes.Add(code.LastIndexOf("five").ToString() + ":5");
                lastindexes.Add(code.LastIndexOf("six").ToString() + ":6");
                lastindexes.Add(code.LastIndexOf("seven").ToString() + ":7");
                lastindexes.Add(code.LastIndexOf("eight").ToString() + ":8");
                lastindexes.Add(code.LastIndexOf("nine").ToString() + ":9");

                foreach (string index in firstindexes.ToList())
                { if (index.StartsWith("-1"))
                    {
                        firstindexes.Remove(index); 
                    }
                }
                foreach (string index in lastindexes.ToList())
                {
                    if (index.StartsWith("-1"))
                    {
                        lastindexes.Remove(index);
                    }
                }

                string first = "100:0";
                string last = "0:0";
                string subsum = "";
                foreach (string index in firstindexes)
                {
                    if (Convert.ToInt32(index.Substring(0, index.Length - 2)) <= Convert.ToInt32(first.Substring(0, first.IndexOf(":"))))
                    {
                        first = index;
                    }
                }
                foreach (string index in lastindexes)
                    if(Convert.ToInt32(index.Substring(0,index.Length - 2)) >= Convert.ToInt32(last.Substring(0, last.IndexOf(":"))))
                    {
                        last = index;
                    }
                
                subsum = first.Substring(first.IndexOf(":")+1) + last.Substring(last.IndexOf(":") + 1);
               sum2 += Convert.ToInt32(subsum);
            }
            Console.WriteLine("d1p2: " + sum2);
        }
    }
}
