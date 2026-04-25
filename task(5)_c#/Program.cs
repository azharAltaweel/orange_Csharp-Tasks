using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5__c_
{
    //1
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass class has initialixzation");
        }
        //2
        public MyClass(string name)
        {
            Console.WriteLine("Hello all,i am "+name);
        }
    }

    //3
    class Factorial
    {
        public int fact(int num)
        {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    //4
    class Order
    {
        public int[] order(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }



    internal class Program
    {
        //5
        static void dateDiff(DateTime d1, DateTime d2)
        {
            if (d1 > d2)
            {
                var temp = d1;
                d1 = d2;
                d2 = temp;
            }

            int years = d2.Year - d1.Year;
            int months = d2.Month - d1.Month;
            int days = d2.Day - d1.Day;

            if (days < 0)
            {
                months--;
                DateTime prevMonth = d2.AddMonths(-1);
                days += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"{years} years, {months} months, {days} days");
        }

        //6
        static DateTime StringToDateTime(string date)
        {
            return DateTime.Parse(date);
        }

        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1981, 11, 03);
            DateTime d2 = new DateTime(2013, 09, 04);
            dateDiff(d1, d2);
            Console.WriteLine(StringToDateTime("2000-10-12"));

        }
    }
}
