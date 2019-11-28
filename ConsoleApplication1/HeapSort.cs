using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HeapSortAlgorithm
    {
        public void HeapSort(List<int> input)
        {
            int heapSize = input.Count;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(input, heapSize, p);

            for (int i = input.Count - 1; i > 0; i--)
            {
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
        }

        private void MaxHeapify(List<int> input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeapify(input, heapSize, largest);
            }
        }
    }
}
