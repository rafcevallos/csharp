using System;
using System.Collections.Generic;

namespace numberLists
{
    class randomNumbers
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i = 0; i < numbers.Count; i++)
            {
                /* Determine if the current loop index is contained inside of the `numbers` list.
                Print a message to the console indicating whether the index is in the list. */
                if (numbers.Contains(i))
                {
                    Console.WriteLine("numbers contains {0}", i.ToString());
                }
                else
                {
                    Console.WriteLine("numbers list does not contain {0}", i.ToString());
                }
            }
            // Console.WriteLine(string.Join(", ", numbers));
        }
    }
}