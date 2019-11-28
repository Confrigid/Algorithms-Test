using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MergeSortAlgorithm
    {
        public void MergeSort(List<int> input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        public void MergeSort(List<int> input)
        {
            MergeSort(input, 0, input.Count - 1);
        }

        private static void Merge(List<int> input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            List<int> tmp = new List<int>();

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp.Add(input[left]);
                    left = left + 1;
                }
                else
                {
                    tmp.Add(input[right]);
                    right = right + 1;
                }
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp.Add(input[left]);
                    left = left + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp.Add(input[right]);
                    right = right + 1;
                }
            }

            for (int i = 0; i < tmp.Count; i++)
            {
                input[low + i] = tmp[i];
            }
        }
    }
}
