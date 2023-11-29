using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2022
{
    internal class Dec2
    {
        public static void dec2()
        {
            List<string> outcomes = Files.ReadSimpleInput("dec2.txt");
            int A = 1;
            int B = 2;
            int C = 3;

            int points = 0;
            foreach (string outcome in outcomes)
            { 
                switch (outcome.Substring(2))
                {
                    case "X":
                        switch (outcome.Substring(0, 1)){
                            case "A": points += (A + 3); break;
                            case "B": points += (A + 0); break;
                            case "C": points += (A + 6); break;
                            
                        }
                        break;
                    case "Y": 
                        switch (outcome.Substring(0, 1)){
                            case "A": points += (B + 6); break;
                            case "B": points += (B + 3); break;
                            case "C": points += (B + 0); break;
                        }
                        break;
                    case "Z":
                        switch (outcome.Substring(0, 1)){
                            case "A": points += (C + 0); break;
                            case "B": points += (C + 6); break;
                            case "C": points += (C + 3); break;
                        }
                        break;    
                }
            }
            Console.WriteLine("Using the strategy the total number of points i get is " + points);

            points = 0;
            foreach (string outcome in outcomes)
            {
                int X = 0;
                int Y = 3;
                int Z = 6;
                switch (outcome.Substring(2))
                {
                    case "X":
                        switch (outcome.Substring(0, 1))
                        {
                            case "A": points += (C + X); break;
                            case "B": points += (A + X); break;
                            case "C": points += (B + X); break;
                        }
                        break;
                    case "Y":
                        switch (outcome.Substring(0, 1))
                        {
                            case "A": points += (A + Y); break;
                            case "B": points += (B + Y); break;
                            case "C": points += (C + Y); break;
                        }
                        break;
                    case "Z":
                        switch (outcome.Substring(0, 1))
                        {
                            case "A": points += (B + Z); break;
                            case "B": points += (C + Z); break;
                            case "C": points += (A + Z); break;
                        }
                        break;
                }
            }
            Console.WriteLine("Using the new strategy the total number of points i get is " + points);
        }
    }
}
