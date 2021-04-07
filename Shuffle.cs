using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomOrderNumbers
{
    class Shuffle
    {
        // The function uses the Fisher-Yates shuffle and can take in whatever type of lists
        public static void Run<T>(List<T> list)
        {
            Random rand = new Random();
            // The shuffle works by first starting at the end of the list
            // Once a random number has been found in between the current index and 0
            // Swap the current index's value with the random index's value
            // This is to prevent bias with the same number being constantly swapped and making the same permutations again and again
            // When it reaches the start of the list, the loop stops as the only element at the start of the list that can swap with it is itself
            for (int i = list.Count-1; i > 0; i--)
            {
                int randomIndex = rand.Next(i);
                T temp = list[randomIndex];
                list[randomIndex] = list[i];
                list[i] = temp;
            }
        }
    }
}
