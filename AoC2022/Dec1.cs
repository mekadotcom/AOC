using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2022
{
    internal class Dec1
    {
        public static void run()
        {
            //READ FILE 
            List<string> Calories = ReadFile.FileToList("dec1.txt");
            List<int> elves = new List<int>();
            int calorieSum = 0;

            foreach (string calorie in Calories)
            {

                if (calorie != "")
                {
                    calorieSum += int.Parse(calorie);
                }
                else
                {
                    elves.Add(calorieSum);
                    calorieSum = 0;
                }
            }
            //TASK 1: FIND OUT HOW MANY CALORIES THE TOP ELF HAS IN HIS BAG
            Console.WriteLine("d1p1 : " + elves.Max());

            //TASK 2: FIND OUT HOW MANY CALORIES THE 3 TOP ELVES HAS IN THEIR BAGS
            Console.WriteLine("d1p2 : " + elves.OrderByDescending(x => x).Take(3).Sum());

        }
    }
}