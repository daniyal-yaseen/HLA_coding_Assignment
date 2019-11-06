using System;
using System.Collections.Generic;

namespace selection_sort
{
    class Program
    {
        private static object random;

        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;
            Console.WriteLine("Selection sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i] + " ");
            }
            sorted = merge_sort(unsorted);
            Console.WriteLine("Sorted array elements: ");
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }

            List<int> merge_sort(List<int> unsorted)
            {
                if (unsorted is null)
                {
                    throw new ArgumentNullException(nameof(unsorted));
                }
                int temp, smallest;
                for (int i = 0; i < unsorted.Count - 1; i++)
                {
                    smallest = i;
                    for (int j = i + 1; j < unsorted.Count; j++)
                    {
                        if (unsorted[j] < unsorted[smallest])
                        {
                            smallest = j;
                        }
                    }
                    temp = unsorted[smallest];
                    unsorted[smallest] = unsorted[i];
                    unsorted[i] = temp;
                }
                Console.WriteLine();
                return unsorted;
            }
        }

    }
            
}
