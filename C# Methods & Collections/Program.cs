using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Methods___Collections
{
    internal class Program
    {

        //✅ Task 1 – Method
        static double CalculateAverage(int x, int y, int z) {
        double avg = (double)(x + y + z) / 3;
            return avg;
        }

        //✅ Task 5 – Methods
         //1
        static void mth1()
        {
            Console.WriteLine("Welcome! ");
        }
        //2
        static void mth2(string name ) {
            Console.WriteLine("hello" + name);
        }
        //3
        static void mth3(int age = 23)
        {
            Console.WriteLine("age:"+age);
        }
        //4
        static int sum(int x,int y)
        {
            return x + y;
        }
        //5
        static void mth4(int[] arr)
        {
            foreach(int x in arr)   
                Console.WriteLine(x); 
        }
        
        static void Main(string[] args)
        {
            ////✅ Task 2 – List
            //List<string> stdNames = new List<string>();
            //stdNames.Add("azhar");
            //stdNames.Add("dana");
            //stdNames.Add("yasmeen");
            //stdNames.Add("leen");
            //stdNames.Add("khaled");

            //foreach (string name in stdNames)
            //{
            //    Console.WriteLine(name);
            //}
            //stdNames.Remove(stdNames[4]);//REMOVE KHALED


            ////✅ Task 3 – Dictionary
            //Dictionary<int, string> usersDic = new Dictionary<int, string>();
            //usersDic.Add(1, "azhar");
            //usersDic.Add(2, "bana");
            //usersDic.Add(3, "sara");
            //foreach (var user in usersDic)
            //{
            //    Console.WriteLine(user.Key + "- " + user.Value);
            //}

            ////✅ Task 4 – LINQ
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };
            ////1️ Filter Numbers
            //var result=numbers.Where(n => n > 15);
            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            ////2️ Even Numbers
            //var result2 = numbers.Where(n => n % 2 == 0);
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            ////3 Sorting
            //var result3 = numbers.OrderBy(n => n);
            //var result4 = numbers.OrderByDescending(n => n);


            ////4️ Names Filtering
            //var result5 = names.Where(name => name.StartsWith("A"));
            //foreach (string name in result5)
            //{
            //    Console.WriteLine(name);
            //}

            ////5 First Value
            //var result6= numbers.FirstOrDefault(n => n>10);

            //🚀 Bonus Challenge (Optional)
            var result7 = numbers.Select(n => n * 2);
            foreach (var num in result7)
            {
                Console.WriteLine(num);
            }


            //✅ Task 5 – Methods Calling
            mth1();
            mth2("Azhar");
            mth3();
            mth3(100);
            sum(100,2);
            int[] arr = { 1, 4, 7, 8, 99 };
            mth4(arr);

        }
    }
}
