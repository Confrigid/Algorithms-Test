using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SelectionSortAlgorithm
    {
        public List<int> SelectionSort(List<int> list)
        {
            int pos_min, temp;

            for (int i = 0; i < list.Count - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[pos_min])
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = list[i];
                    list[i] = list[pos_min];
                    list[pos_min] = temp;
                }
            }
            return list;
        }
    }
}
