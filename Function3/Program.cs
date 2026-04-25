using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Function3
{
    internal class Program
    {
        //1) Given a number, n, return a function which adds n to the number passed to it.
        static int Add(int n, int x)
        {
            return x + n;
        }

        //2) Create a function that takes in a number as a string n and returns the number without trailing and leading zeros.
        static string RemoveLeadingTrailing(string num)
        {
             string result= num.Trim('0');
            return result;
        }

        //3)Create a function that takes an array of numbers and returns the second largest number.
        static int SecondLargest(int[] numbers)
        {
            int Largest = numbers[0];
            int secLargest=int.MinValue;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > Largest)
                {
                    secLargest = Largest;
                    Largest = numbers[i];
                }
                else if(numbers[i] > secLargest && numbers[i] != Largest) { 
                    secLargest=numbers[i];
                }
            }
            return secLargest;
        }

        //4) A repdigit is a positive number composed out of the same digit. Create a function that takes an integer and returns whether it's a repdigit or not.
        static bool isRepdigit(int num)
        {
            if (num >= 0)
            {
                string result = num.ToString();
                if (result == "0" || result[0] == result[1])
                    return true;
            }
            return false;
        }

        //5) Given an input string, reverse the string word by word, the first word will be the last, and so on.
        static string ReverseWords(string str)
        {
            string[] arr=str.Split(' ');
            List<string> arr2=new List<string>();
            for(int i=arr.Length-1; i >= 0; i--)
            {
                arr2.Add(arr[i]);
            }
            return string.Join(" ",arr2);
        }

        //6) Create a function that takes an array of numbers and return "Boom!" if the digit 7 appears in the array. Otherwise, return "there is no 7 in the array".
        
        static string CheckSeven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 7)
                {
                    return "Boom!";
                } 
            }
            return "there is no 7 in the array";
        }

        //7) Write a function that inserts a white space between every instance of a lower character followed immediately by an upper character.
        static string insertWhitespace(string str)
        {
            string result="";
            for(int i=0; i<str.Length; i++)
            {
                result += str[i];
                if (i < str.Length - 1 &&  char.IsLower(str[i]) &&  char.IsUpper(str[i + 1]) )
                {
                    result += " ";
                }
            }
            return result;
        }


        //8) Create a function which returns the number of true values there are in an array.
        static int countTrue(bool[] arr)
        {
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)//if(arr[i])
                    counter++;
            }
            return counter;
        }


        //9) Create a function that moves all capital letters to the front of a word.
        static string capToFront(string str)
        {
            string capital = "";
            string small = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i])){
                    capital += str[i];
                }
                else
                {
                    small += str[i];
                }
            }
            return capital + small;
        }


        //10) Create a function that takes an array of items and checks if the last item matches the rest of the array concatenated together.
        static bool matchLastItem(string[] arr)
        {
            string concated = "";
            for(int i = 0; i < arr.Length - 1; i++)
            {
                concated += arr[i];
            }
            return arr[arr.Length - 1] == concated;
        }


        //11) Create a function to find NaN in an array of numbers. The return value should be the index where NaN is found. If NaN is not found in the array, then return -1.
        static int findNaN(double[] arr)//NaN in  double or float type
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (double.IsNaN(arr[i]))
                    return i;
            }
            return -1;
        }


        //12) Create a function that takes an array of items, removes all duplicate items and returns a new array in the same sequential order as the old array(minus duplicates).
        static T[] removeDups<T>(T[] arr)
        {
            List <T> uniqueArr = new List<T>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (!uniqueArr.Contains(arr[i]))
                    uniqueArr.Add(arr[i]);
            }
            return uniqueArr.ToArray();
        }


        //13) Write a function that receives the time in 12-hour AM/PM format and returns a string representation of the time in military (24-hour) format.
        static string convertTime(DateTime time)
        {
            return time.ToString("HH:MM:SS tt");
        }


        //14) Write a function that removes the last vowel in each word in a sentence.
        static string removeLastVowel(string sentence)
        {
            string vowels = "aeiouAEIOU";
            string[] words = sentence.Split(' ');
            for(int i = 0;i < words.Length;i++) {
                for(int j = words[i].Length - 1; j >= 0; j--)
                {
                    if (vowels.Contains(words[i][j]))
                    {
                        words[i] = words[i].Remove(j, 1);
                        break;
                    }
                }
            }
            return string.Join(" ",words);
        }

        //15) Create a function that takes in an array of numbers and returns the sum of its cubes.
        static double sumOfCubes(int[] arr)
        {
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += Math.Pow(arr[i],3);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //1
            Console.WriteLine(Add(1, 2));
            
            //2
            Console.WriteLine(RemoveLeadingTrailing("03.1400"));
            
            //3
            Console.WriteLine(SecondLargest(new int[]{ 1,2,2,3,4}));
            
            //4
            Console.WriteLine(isRepdigit(0));
            
            //5
            Console.WriteLine(ReverseWords("azhar altaweel"));
            
            //6
            Console.WriteLine(CheckSeven(new int[] { 7,1, 2, 2, 3, 4 }));
            
            //7
            Console.WriteLine(insertWhitespace("azharAltaweel"));
            
            //8
            Console.WriteLine(countTrue(new bool[] { true, false, false, false }));
            
            //9
            Console.WriteLine(capToFront("azhaR ALTAweel"));
            
            //10
            Console.WriteLine(matchLastItem(new string[] {"azhar","altaweel"} ));
            
            //11
            Console.WriteLine(findNaN(new double[] { double.NaN, 1, 2, 3, 4 }));      // 0
            
            //12
            var result = removeDups(new int[] { 1, 2, 2, 3, 4 });
                foreach (var item in result)
            {
                Console.Write(item+" ");
            }
                Console.WriteLine();
            //13
            Console.WriteLine(convertTime(DateTime.Now));
            
            //14
            Console.WriteLine(removeLastVowel("azahr altaweel"));
            
            //15
            Console.WriteLine(sumOfCubes(new int[] { 1, 2 }));


        }
    }
}
