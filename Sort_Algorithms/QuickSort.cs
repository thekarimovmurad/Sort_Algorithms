using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class QuickSort<T> where T : IComparable
    {
        public static void Sort(T[] array)
        {
            if (array == null || array.Length == 0)
                return;

            QuickSortAlgorithm(array, 0, array.Length - 1);
        }

        private static void QuickSortAlgorithm(T[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSortAlgorithm(array, left, pivotIndex - 1);
                QuickSortAlgorithm(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(T[] array, int left, int right)
        {
            T pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j].CompareTo(pivot) < 0)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        private static void Swap(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

}
