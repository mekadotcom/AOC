using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2023
{
    internal class ReadFile
    {
        public static List<string> FileToList(String FileName)
        {
            List<string> result = new List<string>(); // A list of strings 
            FileName = string.Concat(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\InputFiles\\", FileName);
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
