using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = args[0];

            Queue<string> queue = new Queue<string>();
            string line;

            while (true)
            {
                line = Console.ReadLine();

                if (line == "")
                {
                    break;
                }
                queue.Enqueue(line);
            }

            if ( File.Exists(file) )
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    foreach (string item in queue)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }
    }
}