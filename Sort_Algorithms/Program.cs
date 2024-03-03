using Sort_Algorithms;
using System.Collections;

int[] intArray = { 5, 3, 8,12, 12,54, 4, 2, 7, 1 };
string[] stringArray = { "adas", "dsad","abhgf","hfgbn" };
QuickSort<int>.Sort(intArray);

foreach (int num in intArray)
{
    Console.Write(num + " ");
}
QuickSort<string>.Sort(stringArray);

foreach (string fruit in stringArray)
{
    Console.Write(fruit + " ");
}