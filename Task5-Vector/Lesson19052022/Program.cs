using Lesson19052022;
using System.Diagnostics;
using System.Text;

Vector vector = new Vector(10);
vector.InitRand(0, 10);
Console.WriteLine(vector.ToString());

//task2
vector.InitKeyboard();
vector.InitRand(0,10);
vector.ShuffeInit();
Console.WriteLine(vector.ToString());
int[] sub = vector.MaxSubVector();
Console.WriteLine(vector.IsPalindrom());
vector.Reverse();
Console.WriteLine(vector.ToString());

//task4 quicksort
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
vector.QuickSort1(0, 19999);
stopwatch.Stop();
Console.WriteLine(vector.ToString());
Console.WriteLine(stopwatch.ElapsedMilliseconds);

//task5
vector.HeapSort(10);
Console.WriteLine(vector.ToString());
vector.ReadFromFileAsync(@"note.txt");
Console.WriteLine(vector.ToString());
Vector vector1 = new Vector(@"note.txt");
vector.SplitMergeSortFromFile(@"SortedNote.txt");

