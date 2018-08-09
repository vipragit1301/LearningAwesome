using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithm
{
    public class InsertionSort
    {
        public int[] CallInsertionSort()
        {
            int[] arr = new int[]
                              {
                                 2, 3 ,10,17 ,12, 15, 22,73
                              };

            Console.WriteLine("Sort below array using insertion sort");
            Print.PrintIntArray(arr);
            Console.WriteLine();

            RunInsertionSort(arr);
            Console.WriteLine("Array is sorted....->");
            Print.PrintIntArray(arr);
            return arr;
        }
        private void RunInsertionSort(int[] arr)
        {            
            for(int i = 1;i<arr.Length;i++)
            {
                int temp;
                int k = i;

                while(k>0 && arr[k - 1] > arr[k])
                {                                          
                    temp = arr[k-1];
                    arr[k - 1] = arr[k];
                    arr[k] = temp;
                    
                    k = k - 1;
                }
            }

        }

        //problem statement 1 - https://www.hackerearth.com/practice/algorithms/sorting/insertion-sort/practice-problems/algorithm/the-rise-of-the-weird-things-1/description/
        public void ZombiesVampires()
        {
            int[] arr = CallInsertionSort();
            int total = 0;
            Console.WriteLine("Result--->");
            Console.WriteLine("Print Zombies n Vampires");

            for(int i =0;i<arr.Length;i++)
            {
                if (arr[i] % 2 == 0)
                {
                    total = total + arr[i];
                    Console.Write(" {0}", arr[i]);
                }
            }

            Console.Write(" {0}",total);
            total = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 2 > 0)
                {
                    total = total + arr[i];
                    Console.Write(" {0}", arr[i]);
                }
            }
            Console.Write(" {0}", total);

        }

        //problem statement 2 - https://www.hackerearth.com/practice/algorithms/sorting/insertion-sort/practice-problems/algorithm/monk-and-nice-strings-3/
        public void SelectString()
        {
            char[] arr = new  char[]{
                               'a', 'c','d','b'
            };
            int[] value = new Int32[arr.Length];

            for (int i =0;i<arr.Length;i++)
            {
                int k = 0;                

                while(k < i && arr[k] < arr[i])
                {
                    value[i] = value[i] + 1;
                    k = k +1;
                }
            }
            Print.PrintIntArray(value);
        }
        
    }
}
