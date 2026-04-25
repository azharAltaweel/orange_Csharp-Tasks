using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__C_
{
    internal class Program
    {
        //-------------Task(2)_C#----------------
        //-------------C#_Task/Conditional statment---------------

        static void Main(string[] args)
        {
            //1. Write a C# program that accept two integers and display the smaller.
            //int num1=Convert.ToInt32(  Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 > num2 ? num2 : num1);

            //2. Write a C# conditional statement to find the sign  of input  number. Display sign. 
            //int num = -6;
            //if (num == 0)
            //    Console.WriteLine("number is zeroo");
            //else if (num < 0)
            //     Console.WriteLine("The sign is -");
            //else
            //     Console.WriteLine("The sign is +");

            //3. Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            int x = -1, y = 4, z = 0;
            int temp ;
            if (x > y) { 
            temp = x;
            x = y;
            y = temp;
            }
            if (x > z)
            {
                temp = x;
                x = z;
                z = temp;
            }
            if (y > z)
            {
                temp = y;
                y = z;
                z = temp;
            }
            Console.WriteLine(x+ " "+y+" "+z);


            //4. Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            int[] arr = { -5, -2, -6, 0, -1 };
            int max = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i] > max)
                    max= arr[i];
            }
            Console.WriteLine(max);


            //5. Write a C# program that converts kilometers per hour to miles per hour.  
            double km = 100;
            double m = km * 0.621371;
            Console.WriteLine(m);


            //6. Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
            //int houres=Convert.ToInt32(Console.ReadLine());
            //int minutes = Convert.ToInt32(Console.ReadLine());
            //double total = 0;
            //if(houres > 0) 
            //    minutes += houres * 60;
            //    total += minutes;
            //Console.WriteLine(total+" minutes.");


            //7. Write a program in C# that takes minutes as input and display the total number of hours and minutes. 
            int minutes = Convert.ToInt32(Console.ReadLine());
            int hours = minutes / 60;
            int min = minutes % 60;
            Console.WriteLine(hours + " hours and " + min + " minutes");


            //8. Create string of array that contains 5 element of different sentence with different length.Print all elements with fixed length for each sentence.
            string[] strings = { "aya", "and", "azhar", "are", "a fullstack developers" };
            for(int i=0; i<strings.Length; i++)
            {
                Console.WriteLine(strings[i].PadRight(25));
            }


            //9. Given a string, reverse all the words which have odd length. The even length words are not changed. 

            string str = "One two three four";
            string[] strings2 = str.Split(' ');
            for(int i=0;i<strings2.Length; i++)
            {
                if (strings2[i].Length % 2 != 0)
                {
                    for (int j = strings2[i].Length - 1; j >= 0; j--)
                        Console.Write(strings2[i][j]);
                    Console.Write(" ");
                }else
                    Console.Write(strings2[i]);
            }







































        }
    }
}
