using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace AoC_2022
{
    internal class Dec3
    {
        public static void dec3()
        {
            List<string> rucksack = Files.ReadSimpleInput("dec3.txt");
            string itemNames = "abcdefghijglmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int itemValue = 0;
            foreach (string pockets in rucksack)
            {
                IEnumerable<char> sharedItems = pockets.Substring(0, (pockets.Length / 2)).Intersect(pockets.Substring(pockets.Length / 2));
                foreach (char sharedItem in sharedItems)
                {
                    itemValue += (itemNames.IndexOf(sharedItem) + 1);
                }
            }
            Console.WriteLine("The sum of the priorities of those item types is " + itemValue);

            itemValue = 0;  
            for(int i = 1; i < rucksack.Count; i += 3)
            {
                IEnumerable<char> sackOneAndTwo = rucksack[i].Intersect<char>(rucksack[i - 1]);
                IEnumerable<char> sackTwoAndThree = rucksack[i].Intersect<char>(rucksack[i + 1]);
                IEnumerable<char> sackOneTwoAndThree = sackOneAndTwo.Intersect<char>(sackTwoAndThree); 
                foreach (char item in sackOneTwoAndThree)
                {
                    itemValue += (itemNames.IndexOf(item) + 1);
                }
            }
            Console.WriteLine("The sum of the priorities of those item types is " + itemValue);
        }
    }
}
