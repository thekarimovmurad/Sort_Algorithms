using Sort_Algorithms;
using System.Collections;
using System.Diagnostics;

int[] intArray = { 5, 3, 8,12, 12,54, 4, 2, 7, 1 };
string[] stringArray = { "adas", "dsad","abhgf","hfgbn" };

////Quick Sort
//QuickSort.Sort(intArray);
//QuickSort.Sort(stringArray);
////Merge Sort
//MergeSort.Sort(intArray);
//MergeSort.Sort(stringArray);
////Heap Sort
//HeapSort.Sort(intArray);
//HeapSort.Sort(stringArray);
////Buble Sort
//BubleSort.Sort(intArray);
//BubleSort.Sort(stringArray);
////Insertion Sort
//InsertionSort.Sort(intArray);
//InsertionSort.Sort(stringArray);
////Selection Sort
//SelectionSort.Sort(intArray);
//SelectionSort.Sort(stringArray);

//foreach (int num in intArray)
//    Console.Write(num + " ");
//Console.WriteLine("");
//foreach (string fruit in stringArray)
//    Console.Write(fruit + " ");



////Comapre RunTime
int[] array = GenerateRandomArray(1000);


int[] QuickSortArr = array;
int[] MergeSortArr = array;
int[] HeapSortArr = array;
int[] BubleSortArr = array;
int[] InsertionSortArr = array;
int[] SelectionSortArr = array;

Stopwatch qsStopTime = Stopwatch.StartNew();
QuickSort.Sort(QuickSortArr);
qsStopTime.Stop();
TimeSpan qsTime=qsStopTime.Elapsed;

Stopwatch msStopTime = Stopwatch.StartNew();
MergeSort.Sort(MergeSortArr);
msStopTime.Stop();
TimeSpan msTime = msStopTime.Elapsed;

Stopwatch hsStopTime = Stopwatch.StartNew();
HeapSort.Sort(HeapSortArr);
hsStopTime.Stop();
TimeSpan hsTime = hsStopTime.Elapsed;

Stopwatch bsStopTime = Stopwatch.StartNew();
BubleSort.Sort(BubleSortArr);
bsStopTime.Stop();
TimeSpan bsTime = bsStopTime.Elapsed;

Stopwatch isStopTime = Stopwatch.StartNew();
InsertionSort.Sort(InsertionSortArr);
bsStopTime.Stop();
TimeSpan isTime = isStopTime.Elapsed;

Stopwatch ssStopTime = Stopwatch.StartNew();
SelectionSort.Sort(SelectionSortArr);
ssStopTime.Stop();
TimeSpan ssTime = ssStopTime.Elapsed;

Console.WriteLine("Sorting Algorithm \t| Execution Time");
Console.WriteLine("---------------------------------------");
Console.WriteLine($"QuickSort \t\t| {qsTime.TotalMilliseconds} milliseconds");
Console.WriteLine($"MergeSort \t\t| {msTime.TotalMilliseconds} milliseconds");
Console.WriteLine($"HeapSort \t\t| {hsTime.TotalMilliseconds} milliseconds");
Console.WriteLine($"BubleSort \t\t| {bsTime.TotalMilliseconds} milliseconds");
Console.WriteLine($"InsertionSort \t\t| {isTime.TotalMilliseconds} milliseconds");
Console.WriteLine($"SelectionSort \t\t| {ssTime.TotalMilliseconds} milliseconds");

static int[] GenerateRandomArray(int count)
{
    Random random = new Random();
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
        array[i] = random.Next();
    return array;
}