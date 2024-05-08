using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = args[0];

            using (StreamWriter sw = new StreamWriter(file))
            {
                string line;

                while (true)
                {
                    line = Console.ReadLine();
                    if (line == "")
                    {
                        break;
                    }
                    sw.WriteLine(line);
                }
            }
        }
    }
}