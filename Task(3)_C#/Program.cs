using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3__C_
{
    internal class Program
    {//----------------------Loops---------------------
        static void Main(string[] args)
        {
            //  1- Correct the syntax error:
            //•	string[] ARR = [1, 7  9  45,]
            string[] ARR = { "1", "7", "9", "45", };

            //•	int arr2 = ["Str" "alex","moh"
            string[] arr2 = { "Str", "alex", "moh" };

            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] arr3 = { "the", "fox" ,"over" , "lazy", "dog", };

            // 2-
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Tomato")
                    Console.WriteLine(i);
            }
            //3-
            string[] foods = { "pizza", "potato", "chocolate", "cheezecake", "chips" };
            string[] sports = { "horseriding", "swimming", "running" };
            string[] movies = { "homealone", "titanic", "interstellar", "avatar" };
            foreach (string f in foods)
            {
                Console.WriteLine(f);
            }
            foreach(string s in sports)
            {
                Console.WriteLine(s);
            }
            foreach(string m in movies)
            {
                Console.WriteLine(m);
            }

            //4- 
            //int sum = 0;
            //string input=Console.ReadLine();
            //string[] numbers = input.Split(',');
            //for (int i = 0;i < numbers.Length;i++) 
            //   sum+= Convert.ToInt32 (numbers[i]);

            //Console.WriteLine (sum);

            //5
            //int n = 100;
            //double sum = 0;
            //Console.WriteLine("odd numbers between 1-100 are : ");
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //        sum += i;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(sum);


            //6
            //int n = 3;
            //for (int i = 1; i <= n; i++)
            //{
            //    int space = n - i;
            //    for (int j = 1; j <= space; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //7
            int n = 5;
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                int space = n - i;
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(x + " ");
                    x++;
                }
                Console.WriteLine();

            }















        }
    }
}
