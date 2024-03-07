using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class MergeSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
                return;
            MergeSortAlgorithm(array, 0, array.Length - 1);
        }
        private static void MergeSortAlgorithm<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSortAlgorithm(array, left, middle);
                MergeSortAlgorithm(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }
        private static void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable<T>
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;
            T[] leftArray = new T[n1];
            T[] rightArray = new T[n2];
            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, middle + 1, rightArray, 0, n2);
            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}