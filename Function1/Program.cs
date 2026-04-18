using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Function1
{
    internal class Program
    {
        //1) Write a function that takes an integer minutes and converts it to seconds.
        static int MinToSec(int min)
        {
            int sec = min * 60;
            return sec;
        }

        //2)Create a function that takes a number as an argument, increments the number by +1 and returns the result.
        static int IncrmentByOne(int num) {
            return num + 1;
        }

        //3)Create a function that takes an array containing only numbers and return the first element.
        static int FirstInArray(int[] arr)
        {
            return arr[0];
        }

        //4) Write a function that takes the base and height of a triangle and return its area
        static double TriangleArea(double b,double h)
        {
            double area = 0.5 * b * h;
            return area ;
        }

        //5)Create a function called evenNumberEvenIndex that accept an array of nums and return a new array that have the even number in even index
        static int[] evenNumberEvenIndex(int[]nums)
        {
            List<int> arr2= new List<int>();
           for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] %2==0 && i%2==0)
                    arr2.Add(nums[i]);
            }
            return arr2.ToArray();
        }

        //6) Create a function called evenIndexOddLength that accept an array of strings and return a new array that have the string with odd length in even index
        static string[] evenIndexOddLength(string[] strings)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length % 2 != 0 && i % 2 == 0)
                    result.Add(strings[i]);
            }
            return result.ToArray();
        }

        //7) Create a function called powerElementIndex that accept an array of number and return a new array that have the element power by the index of it self
         static int[] powerElementIndex(int [] nums)
        {
            List<int> power = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                power.Add((int)Math.Pow(nums[i],i));
            return power.ToArray();
        }

        //8) Write a function called multiplication2 that takes two parameters and return the multiplication of them you need to use only sum
        static int multiplication2(int num1, int num2)
        {
            int multi = 0;
            for(int i = 0; i < num2; i++)
            {
                multi += num1;
            }
            return multi;
        }

        //9) Create a function called muti2 that take two parameter and will return the multiplication from the first number to the second number
        static int muti2(int num1, int num2)
        {
            int multi = 1;
            for(int i = num1; i <= num2; i++)
            {
                multi *= i;
            }
            return multi;
        }

        //10) Create a function called aveArray that accept an array and return the average of the numbers inside this array
        static double aveArray(int[] nums)
        {
            int sum = 0;
            for(int i=0; i<nums.Length; i++)
            {
                sum += nums[i];
            }
            double avg = (double)sum/nums.Length;
            return avg;
        }








        static void Main(string[] args)
        {


        }
    }
}
