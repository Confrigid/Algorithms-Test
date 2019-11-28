using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class QuickSortAlgorithm
    {
        public static void QuickSort(List<int> list, int left, int right)
        {
            int pivot, leftend, rightend;

            leftend = left;
            rightend = right;
            pivot = list[left];

            while (left < right)
            {
                while ((list[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    list[left] = list[right];
                    left++;
                }

                while ((list[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    list[right] = list[left];
                    right--;
                }
            }

            list[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot)
            {
                QuickSort(list, left, pivot - 1);
            }

            if (right > pivot)
            {
                QuickSort(list, pivot + 1, right);
            }
        }
    }
}
