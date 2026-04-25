using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4__C_
{
    internal class Program
    {//--------------c# Task-------------------
       //1
        static void sumAndAvg(int[] nums)
        {
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            avg = sum / nums.Length;
            Console.WriteLine("sum of numbers: " + sum);
            Console.WriteLine("avg of numbers: " + avg);
        }

        //2
        static void CubeOfNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("cube of number " + i + " is: " + Math.Pow(i, 3));
            }
        }

        //3
        static int[] getYears(int[] years)
        {
            List<int> yearsList = new List<int>();
            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] > 1950)
                    yearsList.Add(years[i]);
            }
            return yearsList.ToArray();
        }

        //4
        static int ageInDays(int age)
        {
            return age * 12 * 30; 
        }

        //5
        static int animals(int chickens, int cows, int pigs)
        {
            if (chickens < 0 || cows < 0 || pigs < 0)
            {
                Console.WriteLine("invalid input ");
                return 0;
            }
            return (chickens * 2) + (cows * 4) + (pigs * 4);
        }

        //6
        static void login(string username, string password)
        {
            string[] users = { "azhar", "leen", "sajeda" };
            string[] passwords = { "a123","l123","s123"};

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] == username && passwords[i] == password)
                    Console.WriteLine("pass");
                else
                    Console.WriteLine("fail");
            }
        }

        //7
        static int power(int num,int pow) {
            int multi = 1;
            for(int i = 1; i <= pow; i++)
                multi *= num;
            return multi;
        }


        //8
        static string leap(int x)
        {
            if (x > 1900 && x <= 2024)
            {
                if (x % 4 == 0)
                    return "it's a leap year";
                else
                    return "it's not a leap year";
            }
            else
            {
                return "invalid year";
            }
        }

        //9
        static bool isPrime(int num)
        {
            if (num <= 1)
                return false;
            for(int i = 2; i < num; i++)
            {
                if(num%i==0) return false;
            }
            return true;
        }
        //10
        static int numOfWords(string str)
        {
            int counter = 0;
            for(int i = 0;i < str.Length; i++)
            {
                if (str[i] == ' ')
                    counter++;
            }
            return  counter+1;
        }



        static void Main(string[] args)
        {
            sumAndAvg(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            CubeOfNumber(5);
            int[] y = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            Console.WriteLine(string.Join(",", getYears(y))); 
            Console.WriteLine(ageInDays(23)+" days");
            Console.WriteLine(animals(1, 2, 4));
            Console.WriteLine(power(6,2));
            Console.WriteLine(numOfWords("azhar altaweel"));



        }
    }
}
