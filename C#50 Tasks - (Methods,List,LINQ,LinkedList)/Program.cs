using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.WebRequestMethods;

namespace C_50_Tasks____Methods_List_LINQ_LinkedList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //🟢 Section 1: List 
            //✅ Task 1: Even Numbers Filter
            //List<int>numbers=new List<int> { 4,7,9,10,11,100,33};
            //List<int> result = new List<int>(numbers.Where(n => n % 2 == 0));
            //foreach (int n in result)
            //{
            //    Console.Write(n +" ");
            //}


            //✅ Task 2: Remove Duplicates
            //List<int> numbers = new List<int> { 3,6,6,5,1,6,5,10,7,1 };
            //List<int> result = new List<int>(numbers.Distinct());
            //foreach (int n in result)
            //{
            //     Console.Write(n +" ");
            //}


            //✅ Task 3: Find Maximum Number
            //List<int>numbers=new List<int> { 4,7,9,10,11,100,33};
            //int largest=numbers.Max();
            //Console.Write(largest);


            //✅ Task 4: Reverse List
            //List<int>numbers=new List<int> { 4,7,9,10,11,100,33};
            //List<int>result=new List<int>();
            //for(int i=numbers.Count-1; i>=0; i--)
            //{
            //    result.Add(numbers[i]);
            //}
            //foreach (int i in result)
            //{
            //    Console.Write(i + " ");
            //}


            //✅ Task 5: Count Numbers Greater Than X
            //List<int> numbers = new List<int> { 4,1, 33,5,0 };
            //int counter=numbers.Count(n => n > 3);
            //Console.WriteLine(counter);



            //🔵 Section 2: Dictionary
            //✅ Task 6: Student Scores
            //Dictionary<String,int> stdScores=new Dictionary<String,int>();
            //stdScores.Add("azhar", 97);
            //stdScores.Add("leena", 80);
            //stdScores.Add("khaled", 63);
            //stdScores.Add("sara", 77);
            //var result = stdScores.Where(s=>s.Value > 80);
            //foreach (var std in result)
            //{
            //    Console.WriteLine(std.Key + ": " + std.Value);
            //}

            //✅ Task 7: Search by Key
            //Dictionary<String, int> stdScores = new Dictionary<String, int>();
            //stdScores.Add("azhar", 97);
            //stdScores.Add("leena", 80);
            //stdScores.Add("khaled", 63);
            //stdScores.Add("sara", 77);

            //Console.WriteLine("input the name of student to know his score: ");
            //string name=Console.ReadLine();
            //if (stdScores.ContainsKey(name))
            //{
            //    Console.WriteLine("Student Score: " + stdScores[name]);
            //}
            //else {
            //    Console.WriteLine(" Student Not Found!");
            //}

            //✅ Task 8: Sum of Values
            //Dictionary<String, int> stdScores = new Dictionary<String, int>();
            //stdScores.Add("azhar", 97);
            //stdScores.Add("leena", 80);
            //stdScores.Add("khaled", 63);
            //stdScores.Add("sara", 77);

            //int sum = stdScores.Sum(s=>s.Value);
            //Console.WriteLine(sum);


            //✅ Task 9: Remove Low Scores
            //Dictionary<String, int> stdScores = new Dictionary<String, int>();
            //stdScores.Add("azhar", 97);
            //stdScores.Add("leena", 80);
            //stdScores.Add("khaled", 43);
            //stdScores.Add("sara", 77);

            //var result = stdScores.Where(s => s.Value >= 50);
            //foreach (var s in result)
            //{
            //    Console.WriteLine(s.Key + ": " + s.Value);
            //}
            //or using remove(s.key)


            //✅ Task 10: Highest Score
            //Dictionary<String, int> stdScores = new Dictionary<String, int>();
            //stdScores.Add("azhar", 97);
            //stdScores.Add("leena", 80);
            //stdScores.Add("khaled", 63);
            //stdScores.Add("sara", 77);

            //int maxScore = stdScores.Max(s=>s.Value);//or stdScores.Values.Max();
            //string highestStd = stdScores.Where(s => s.Value == maxScore).Select(s => s.Key).First();
            //Console.WriteLine("The student with the largest score is: "+ highestStd);


            //🟣 Section 3: LinkedList
            //✅ Task 11: Add Elements
            //LinkedList<string> navigation= new LinkedList<string>();
            //navigation.AddFirst("First");
            //navigation.AddLast("Last");
            //foreach (string s in navigation)
            //{
            //    Console.WriteLine(s);
            //}


            //✅ Task 12: Remove Middle Element
            //LinkedList<string> navigation = new LinkedList<string>();
            //navigation.AddFirst("First");
            //navigation.AddLast("Middle");
            //navigation.AddLast("Last");
            //int mid = navigation.Count / 2;
            //var current=navigation.First;
            //for (int i = 0; i < mid; i++)
            //{
            //    current = current.Next;
            //}
            //navigation.Remove(current);
            //foreach (var nav in navigation)
            //{
            //    Console.WriteLine(nav);
            //}


            //✅ Task 13: Add Before/ After
            //LinkedList<int> numbers = new LinkedList<int>();
            //numbers.AddFirst(1);
            //numbers.AddLast(3);
            //var node = numbers.Find(3);
            //numbers.AddBefore(node, 2);
            //numbers.AddAfter(node, 4);

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //✅ Task 14: Traverse LinkedList
            //LinkedList<int> numbers = new LinkedList<int>();
            //numbers.AddLast(2);
            //numbers.AddLast(4);
            //numbers.AddLast(6);
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //✅ Task 15: First and Last
            //LinkedList<int> numbers = new LinkedList<int>();
            //numbers.AddLast(2);
            //numbers.AddLast(4);
            //numbers.AddLast(6);
            //Console.WriteLine("first element: " + numbers.First.Value);
            //Console.WriteLine("last element: " + numbers.Last.Value);



            //🔴 Section 4: LINQ
            //✅ Task 16: Odd Numbers
            //List<int> numbers=new List<int> { 1,22,45,67,8,99};
            //var result = numbers.Where(n => n % 2 != 0);
            //foreach (int n in result)
            //{
            //    Console.Write(n+ " ");
            //}

            //✅ Task 17: Multiply All Numbers
            //List<int> numbers = new List<int> { 1, 2, 9, 5, 8, 50 };
            //var result = numbers.Select(n => n*2);
            //foreach (int n in result)
            //{
            //    Console.Write(n + " ");
            //}

            //✅ Task 18: Sort Descending
            //List<int> numbers = new List<int> { 1, 15, 9, 5, 8, 50 };
            //var result = numbers.OrderByDescending(n => n);
            //foreach (int n in result)
            //{
            //    Console.Write(n + " ");
            //}

            //✅ Task 19: First Number Greater Than 100
            //List<int> numbers = new List<int> { 1, 15, 900, 5, 8, 500 };
            //var result = numbers.FirstOrDefault(n => n>100);
            //Console.Write(result);

            //✅ Task 20: Average Calculation
            //List<int> numbers = new List<int> { 1, 15, 900, 5, 8, 500 };
            //Console.Write(numbers.Average());


            //🔥 Section 5: Mixed
            //✅ Task 21: Compare Two Lists
            //List<int> L1= new List<int> {1,2,3,4,5 };
            //List<int> L2 = new List<int> {1,6,7,3,8 };
            //var common=L1.Intersect(L2);
            //foreach (int num in common)
            //{
            //    Console.Write(num+ " ");
            //}

            //✅ Task 22: Merge Two Lists
            //List<int> L1 = new List<int> { 1, 2, 3, 4, 5 };
            //List<int> L2 = new List<int> { 1, 6, 7, 3, 8 };
            //var merged=L1.Concat(L2);
            //foreach (int num in merged)
            //{
            //    Console.Write(num + " ");
            //}

            //✅ Task 23: Unique Values Only
            //List<int> numbers = new List<int> { 1, 2, 2, 4, 5,4 };
            //var unique=numbers.Distinct();
            //foreach (int num in unique)
            //{
            //    Console.Write(num + " ");
            //}

            //✅ Task 24: Dictionary to List
            //    Dictionary<string, int> stdScores = new Dictionary<string, int>
            //{
            //    { "azhar", 97 },
            //    { "leena", 80 },
            //    { "khaled", 63 }
            //};
            //    List<int> scores = stdScores.Values.ToList();
            //    foreach (int score in scores)
            //    {
            //        Console.WriteLine(score);
            //    }

            //✅ Task 25: Filter Dictionary
            //    Dictionary<string, int> stdScores = new Dictionary<string, int>
            //{
            //    { "azhar", 120 },
            //    { "leena", 80 },
            //    { "khaled", 63 }
            //};
            //    var result = stdScores.Where(n => n.Value > 100);
            //    foreach (var std in result)
            //    {
            //        Console.WriteLine(std.Key + " " + std.Value);
            //    }


            //🔥🔥 Section 6: Thinking Tasks
            //✅ Task 26: Manual Search
            //List<int> numbers = new List<int> { 3, 4, 5, 1 };
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == 3)
            //    {
            //        Console.WriteLine("3 is found");
            //        break;
            //    }
            //    else
            //        Console.WriteLine("3 is not found in the list");
            //}

            //✅ Task 27: Count Even Without LINQ
            //List<int> numbers = new List<int> { 3, 4, 5, 1,10};
            //int evenCounter=0;
            //for(int i=0; i<numbers.Count; i++)
            //{
            //    if(numbers[i] %2== 0)
            //        evenCounter++;
            //}
            //    Console.WriteLine(evenCounter);


            //✅ Task 28: Remove While Looping
            //List<int> numbers = new List<int> { 33, 4, 5, 1, 10, 20, };
            //var result = numbers.Where(x => x < 10);
            //foreach (var num in result)
            //{
            //    Console.Write(num+" ");
            //}
            ////or 
            //List<int> numbers = new List<int> { 33, 4, 5, 1, 10, 20, };
            //for (int i=0; i<numbers.Count; i++)
            //{
            //    if (numbers[i] > 10)
            //        numbers.RemoveAt(i);
            //}


            //✅ Task 29: Find Second Largest Number
            //List<int> numbers = new List<int> { 33, 4, 5, 1, 10, 20, };
            //var Largest = numbers.Max();
            //numbers.Remove(Largest);
            //var secLargest=numbers.Max() ;
            //Console.WriteLine("second largest number is: " + secLargest);

            //-----------------------------------------------------------------------------------------------------------

            //Advanced Logic Tasks(List & Array)
            //✅ Task 1: Hidden Pattern Finder
            //int[] arr = {1,1,2,3,3,3,3,4,5,5};
            //int maxcounter = 0;
            //int mostRepeat = arr[0];
            //for (int i = 0; i < arr.Length; i++)//for arr numbers
            //{
            //    int counter = 0;
            //    for (int j = 0; j < arr.Length; j++)//for array numbers to compare num in first for loop  with others numbers in array
            //    {
            //        if (arr[i] == arr[j])
            //            counter++;
            //    }
            //    if (counter > maxcounter)
            //    {
            //        maxcounter = counter;
            //        mostRepeat = arr[i];
            //    }
            //}
            //Console.WriteLine("The most frequent number in the array is: " + mostRepeat);

            //✅ Task 2: Rotation Puzzle
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int steps = 2;

            //for (int i = 0; i < steps; i++)
            //{
            //   int last = arr[arr.Length - 1];
            //    for (int j = arr.Length - 1; j > 0; j--)
            //    {
            //        arr[j] = arr[j - 1];//shifting array elements to right
            //    }
            //    arr[0]=last;
            //}
            //foreach (int num in arr)
            //{
            //    Console.Write(num+" ");
            //}

            //✅ Task 3: Mirror Check
            //List <int>l1=new List<int> { 1, 2, 3, 2, 1 };
            //int mid = (int)Math.Ceiling( l1.Count/2.0);
            //bool isPalindrome =true;
            //for (int i = 0; i < mid; i++)
            //{
            //    if (l1[i] != l1[l1.Count - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(isPalindrome);


            //✅ Task 4: Missing Number Detective
            //int[] arr = { 1, 2, 4, 5 };
            //int last=arr[arr.Length-1];
            //int missNum=1 ;

            //for (int i = 1; i <= last; i++)
            //{
            //    if (arr[i - 1] == i)
            //        continue;
            //    else
            //    {
            //        missNum = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(missNum);

            //✅ Task 5: Split List into Balanced Parts
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //int minDiff= int.MaxValue; 
            //int bestSplit=-1;

            //for (int i = 1; i < numbers.Count; i++) { 
            //int leftsum=0, rightsum=0;
            //    for(int left=0; left<i; left++)
            //        leftsum+=numbers[left];
            //    for(int right=i; right < numbers.Count; right++)
            //        rightsum+=numbers[right];

            //    int diff=Math.Abs(leftsum-rightsum);
            //    if (diff < minDiff)
            //    {
            //        minDiff = diff;
            //        bestSplit = i;
            //    }
            //}
            //Console.WriteLine("Best split index: " + bestSplit);
            //Console.WriteLine("Minimum difference: " + minDiff);


            //✅ Task 6: Longest Increasing Sequence
            //int[] arr = { 1, 2, 2, 3, 4, 1, 2, 3 };
            //List<int> current = new List<int>();
            //List<int> longest = new List<int>();

            //current.Add(arr[0]);
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > arr[i - 1])
            //        current.Add(arr[i]);
            //    else
            //    {
            //        if (current.Count > longest.Count)
            //            longest = new List<int>(current);

            //        current.Clear();
            //        current.Add(arr[i]);
            //    }
            //}
            //if (current.Count > longest.Count)
            //        longest = current;

            //Console.Write("Longest increasing sequence: ");
            //foreach (var n in longest)
            //{
            //    Console.Write(n + " ");
            //}

            //✅ Task 7: Duplicate Distance
            //int[] numbers = {1,2,3,1,4,2,1 };
            //int minDistance = int.MaxValue;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    for(int j = i+1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            int distance = j - i;
            //            if (distance < minDistance)
            //            {
            //                minDistance = distance;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Shortest distance: " + minDistance);


            //✅ Task 8: Reorder by Rule => All even numbers come first -Then odd numbers-BUT keep their original order
            //int[] numbers = { 1, 2, 3, 4,6,7 };
            //List<int> evenNumbers = new List<int>();
            //List<int> oddNumbers = new List<int>();

            //for (int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //        evenNumbers.Add(numbers[i]);
            //    else 
            //        oddNumbers.Add(numbers[i]);
            //}
            //List<int> result=new List<int>(evenNumbers.Concat(oddNumbers));
            //foreach(int i in result)
            //{
            //    Console.Write(i+" ");
            //}

            //✅ Task 9: Peaks Finder





















        }
    }
}
