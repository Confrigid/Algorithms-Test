using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InsertionSortAlgorithm
    {
        public List<int> InSort(List<int> inputList)
        {
            for (int i = 0; i < inputList.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputList[j - 1] > inputList[j])
                    {
                        int temp = inputList[j - 1];
                        inputList[j - 1] = inputList[j];
                        inputList[j] = temp;
                    }
                }
            }
            return inputList;
        }
    }
}
