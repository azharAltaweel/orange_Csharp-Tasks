using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Function2
{
    internal class Program
    {
        //1) Create a function that takes two dates and returns the number of days between the first and second date.
         static int getDays( DateTime d1, DateTime d2)
        {
            TimeSpan diff = d2 - d1;

            return Math.Abs(diff.Days);
        }

        //2) Create a function that takes an array of strings and returns an array with only the strings that have numbers in them.If there are no strings containing numbers, return an empty array.
        static string[] StringsWithNumber(string[] str)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (char.IsDigit(str[i][j]))//check if the character is number
                    {
                        result.Add(str[i]);
                        break;//اول ما يلاقي الرقم بطلع من المكلمة وبروح بشييك عالكلمة اللي بعدها 
                    }
                }
            }
            return result.ToArray();
        }

        //3) Given a string, reverse all the words which have odd length.The even length words are not changed.
        static string ReverseOddString(string str) {
            string[] words = str.Split(' ');
            List<string> result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    result.Add(new string(words[i].Reverse().ToArray()));
                }
                else
                {
                    result.Add(words[i]); // keep even words

                }
            }
            return string.Join(" ", result);
        }


        //4) A pandigital number contains all digits(0-9) at least once.Write a function that takes an integer, returning true if the integer is pandigital, and false otherwise.

         static bool pandigitalNumber(long num)
        {
            string strNum = num.ToString();

            for(char i = '0'; i <='9'; i++)//i is the char which is the digit from 0-9
            {
                if (!strNum.Contains(i))
                {
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ReverseOddString("azhar altaweel"));
            Console.WriteLine(pandigitalNumber(1203987654));//dont start with zero ما بقرؤو ازا كان بالاول 
        }
    }
}
