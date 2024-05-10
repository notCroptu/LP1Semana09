using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace resultsets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = false;
            HashSet<HashSet<char>> results = new HashSet<HashSet<char>>();

            foreach (string file in args)
            {
                HashSet<char> chars = new HashSet<char>();

                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Length == 1)
                        {
                            chars.Add(line[0]);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error.");
                            error = true;
                            return;
                        }
                    }

                    results.Add(chars);
                }
            }

            if (!error)
            {
                HashSet<char> newHashSet = new HashSet<char>();
                foreach (HashSet<char> characters in results)
                {
                    newHashSet = characters;
                    break;
                }

                foreach (HashSet<char> characters in results)
                {
                    newHashSet.IntersectWith(characters);
                }
                
                foreach (char character in newHashSet)
                {
                    Console.WriteLine(character);
                }
            }
            
        }
    }
}
