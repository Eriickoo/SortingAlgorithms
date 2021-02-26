using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class Utilities
    {
        public static int[] CreateRandomArrayOfNumbers(int size)
        {
            int[] arrayOfNumbers = new int[size];
            Random r = new Random();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = r.Next();
            }
            return arrayOfNumbers;
        }

        public static void PrintArray<T>(IEnumerable<T> array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
            
        }

        public static int[] OrderIntArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}
