using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    public class HeapSort
    {
        int[] heap;
        int[] ArraySort { get; set; }

        int size;

        List<int> list = new List<int>();
        public HeapSort()
        {
            BinaryHeap binaryHeap = new BinaryHeap();
            int[] d = new int[] { 4, 8, 10, 20, 5, 6, 13, 12, 25, 15, 14, 0, 26, 9, 3, 1, 19, 2, 24, 28, 17, 23, 27, 7, 11, 29, 21, 30, 22, 18, 16 };

            foreach (int i in d)
            {
                binaryHeap.Insert(i);
            }

            var index = binaryHeap.heap[0];
            for (int i = 0; i < binaryHeap.heap.Length;)
            {
                list.Add(index);

                if (binaryHeap.size == 0)
                {
                    break;
                }
                else
                {
                    binaryHeap.Delete();
                }
            }
            List<int> sorted_arr = new List<int>();
            foreach (int i in d)
            {
                binaryHeap.Insert(i);
            }
            for (int i = 0; i < d.Length; i++)
            {
                sorted_arr.Add(binaryHeap.getElement(0));
                if (binaryHeap.size == 0)
                {
                    break;
                }
                else
                {
                    binaryHeap.Delete();
                }
            }
            foreach (int i in sorted_arr)
            {
                Console.WriteLine(sorted_arr[i]);

            }
            heap = new int[31];
            size = 0;
        }

    }
}