using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2022
{
    internal class Dec5
    {
        public static void dec5()
        {
            List<string> moves = Files.ReadSimpleInput("dec5.txt");
            CrateMover9000(moves);
            CrateMover9001(moves);
        }

        public static void CrateMover9000(List<string> moves)
        {
            List<string> stacks = new List<string>();
            stacks.Add("FRW");
            stacks.Add("PWVDCMHT");
            stacks.Add("LNZMP");
            stacks.Add("RHCJ");
            stacks.Add("BTQHGPC");
            stacks.Add("ZFLWCG");
            stacks.Add("CGJZQLVW");
            stacks.Add("CVTWFRNP");
            stacks.Add("VSRGHWJ");

            foreach (string move in moves)
            {
                if (move.StartsWith("move"))
                {
                    string[] command = move.Split(' ');
                    int num = Convert.ToInt16(command[1]);
                    int from = (Convert.ToInt16(command[3]) - 1);
                    int to = (Convert.ToInt16(command[5]) - 1);
                    for (int i = 0; i < num; i++)
                    {
                        string sack = stacks[from].Substring(0, 1);
                        stacks[to] = sack + stacks[to];
                        stacks[from] = stacks[from].Substring(1);
                    }
                }
            }
            string topboxes = "";
            foreach (string stack in stacks)
            {
                topboxes += stack.Substring(0, 1);
            }
            Console.WriteLine("Box on top of each stack using CrateStacker9000 " +  topboxes);
        }
        public static void CrateMover9001(List<string> moves)
        {
            List<string> stacks = new List<string>();
               stacks.Add("FRW");
               stacks.Add("PWVDCMHT");
               stacks.Add("LNZMP");
               stacks.Add("RHCJ");
               stacks.Add("BTQHGPC");
               stacks.Add("ZFLWCG");
               stacks.Add("CGJZQLVW");
               stacks.Add("CVTWFRNP");
               stacks.Add("VSRGHWJ");

            foreach (string move in moves)
            {
                if (move.StartsWith("move"))
                {
                    string[] command = move.Split(' ');
                    int num = Convert.ToInt16(command[1]);
                    int from = (Convert.ToInt16(command[3]) - 1);
                    int to = (Convert.ToInt16(command[5]) - 1);
                    
                        string sack = stacks[from].Substring(0, num);
                        stacks[to] = sack + stacks[to];
                        stacks[from] = stacks[from].Substring(num);

                }
            }
            string topboxes = "";
            foreach (string stack in stacks)
            {
                topboxes += stack.Substring(0, 1);
            }
            Console.WriteLine("Box on top of each stack using CrateStacker9001 " + topboxes);
        }
    }
}
