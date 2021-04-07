using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomOrderNumbers
{
    class Program
    {
        static void Main()
        {
            // Create a list of integeres from 1 to 10000
            List<int> list = Enumerable.Range(1, 10000).ToList();
            // Shuffle the list with the Fisher-Yates shuffle
            Shuffle.Run(list);

            // Print out the results
            string output = string.Join(", ", list);
            Console.WriteLine(output);
        }
    }
}
