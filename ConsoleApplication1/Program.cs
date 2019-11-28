using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>();
            lines.AddRange(System.IO.File.ReadAllLines(@"numbers100k.txt"));

            List<int> numbers = lines.ConvertAll(s => Int32.Parse(s));
            
            List<int> quickSortList = new List<int>(numbers);

            //Show last number of the current list
            Console.WriteLine(numbers[numbers.Count-1]);

            #region Custom number amount creator
            /*
            using (StreamWriter sw = new StreamWriter(@"numbers.txt"))
            {
                for (int i = 0; i < 100000; i++)
                {
                    int r = numbers[i];
                    sw.WriteLine(r);
                }
            }
            */
            #endregion

            int key = 0;

            while(key != 6)
            {
                Console.WriteLine("1. Insertion Sort");
                Console.WriteLine("2. Selection Sort");
                Console.WriteLine("3. Quick Sort");
                Console.WriteLine("4. Merge Sort");
                Console.WriteLine("5. Heap Sort");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                key = int.Parse(Console.ReadLine());
                switchCase(key, numbers);

            }

        }

        public static void switchCase(int c, List<int> n)
        {
            Stopwatch stopwatch = new Stopwatch();
            switch (c)
                {
                    case 1:
                        {
                            List<int> insertion = new List<int>();
                            InsertionSortAlgorithm sorter = new InsertionSortAlgorithm();
                            Console.WriteLine("Performing Insertion Sort on 100,000 integers.");
                            stopwatch.Start();
                            insertion.AddRange(sorter.InSort(n));
                            stopwatch.Stop();

                            using (StreamWriter sw2 = new StreamWriter(@"InsertionSort_sorted.txt"))
                            {
                                insertion.ForEach(r => sw2.WriteLine(r));
                                sw2.WriteLine(stopwatch.Elapsed);
                            }
                            Console.WriteLine(stopwatch.Elapsed);
                            Console.WriteLine();
                            stopwatch.Reset();
                            break;
                        }
                    case 2:
                        {
                            List<int> selection = new List<int>();
                            SelectionSortAlgorithm select = new SelectionSortAlgorithm();
                            Console.WriteLine("Performing Selection Sort on 100,000 integers.");
                            stopwatch.Start();
                            selection.AddRange(select.SelectionSort(n));
                            stopwatch.Stop();

                            using (StreamWriter sw2 = new StreamWriter(@"SelectionSort_sorted.txt"))
                            {
                                selection.ForEach(r => sw2.WriteLine(r));
                                sw2.WriteLine(stopwatch.Elapsed);
                            }
                            Console.WriteLine(stopwatch.Elapsed);
                            Console.WriteLine();
                            stopwatch.Reset();
                            break;
                        }
                    case 3:
                        {
                            List<int> quickSortList = new List<int>();
                            Console.WriteLine("Performing Quick Sort on 100,000 integers.");
                            quickSortList.AddRange(n);
                            stopwatch.Start();
                            QuickSortAlgorithm.QuickSort(quickSortList, 0, quickSortList.Count - 1);
                            stopwatch.Stop();

                            using (StreamWriter sw2 = new StreamWriter(@"QuickSort_sorted.txt"))
                            {
                                quickSortList.ForEach(r => sw2.WriteLine(r));
                                sw2.WriteLine(stopwatch.Elapsed);
                            }
                            Console.WriteLine(stopwatch.Elapsed);
                            Console.WriteLine();
                            stopwatch.Reset();
                            break;
                        }
                    case 4:
                        {
                            List<int> mergeSortList = new List<int>();
                            MergeSortAlgorithm mSort = new MergeSortAlgorithm();
                            Console.WriteLine("Performing Merge Sort on 100,000 integers.");
                            mergeSortList.AddRange(n);
                            stopwatch.Start();
                            mSort.MergeSort(mergeSortList);
                            stopwatch.Stop();

                            using (StreamWriter sw2 = new StreamWriter(@"MergeSort_sorted.txt"))
                            {
                                mergeSortList.ForEach(r => sw2.WriteLine(r));
                                sw2.WriteLine(stopwatch.Elapsed);
                            }
                            Console.WriteLine(stopwatch.Elapsed);
                            Console.WriteLine();
                            stopwatch.Reset();
                            break;
                        }
                    case 5:
                        {
                            List<int> heapSortList = new List<int>();
                            HeapSortAlgorithm hSort = new HeapSortAlgorithm();
                            Console.WriteLine("Performing Heap Sort on 100,000 integers.");
                            heapSortList.AddRange(n);
                            stopwatch.Start();
                            hSort.HeapSort(heapSortList);
                            stopwatch.Stop();

                            using (StreamWriter sw2 = new StreamWriter(@"HeapSort_sorted.txt"))
                            {
                                heapSortList.ForEach(r => sw2.WriteLine(r));
                                sw2.WriteLine(stopwatch.Elapsed);
                            }
                            Console.WriteLine(stopwatch.Elapsed);
                            Console.WriteLine();
                            stopwatch.Reset();
                            break;
                        }
                    default:
                        break;
                }   
        }
    }
}
