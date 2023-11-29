using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2022
{
    internal class Files
    {
        public static List<string> ReadSimpleInput(String FileName)
        {
            List<string> result = new List<string>(); // A list of strings 
            FileName = string.Concat("C:\\Users\\Michael Glomnes\\Documents\\AOC\\2021\\", FileName);
            // Create a stream reader object to read a text file.
            using (StreamReader reader = new StreamReader(FileName))
            {
                string line = string.Empty; // Contains a single line returned by the stream reader object.

                // While there are lines in the file, read a line into the line variable.
                while ((line = reader.ReadLine()) != null)
                {
                    // If the line is not empty, add it to the list.
                    if (line != string.Empty)
                    {
                        result.Add(line);
                    }
                    else
                    {
                        result.Add("");
                    }
                }
            }

            return result;
        }
    }
}
