using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Array_String_Loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //✅ Task 1 :  Analyze an Array with Loops
            /* int[] arr = { 10, 15, 22, 7, 8, 13, 30 };
             int even = 0;
             int odd = 0;
             int sum = 0;
             foreach (int num in arr)
             {

                 if (num % 2 == 0)
                     even++;
                 else
                     odd++;
                 sum += num;
             }

             double arrAvg =(double) sum / (arr.Length);
             int[] arr2=new int [arr.Length] ;
             int index=0;
             foreach(int num in arr)
             {
                 if (num > arrAvg)
                 {
                     arr2[index]=num;
                     index++;
                 }
             }

             Console.WriteLine($"Count Of Even Numbers:{even}");
             Console.WriteLine($"Count Of Odd Numbers:{odd}");
             Console.WriteLine($"Sum of Numbers:{sum}");
             Console.WriteLine($"Average of Numbers:{arrAvg}");
             Console.Write("The filtered Array:[");
             for(int i=0; i< index; i++)
             {
                 Console.Write(arr2[i]+" ");
             }
             Console.WriteLine("]");*/



            //✅ Task 2 :  Find the Largest Number in an Array
            /* int[] arr = { 12, 45, 7, 23, 56, 19 };
             int largest=arr[0];
             for (int i= 1; i < arr.Length; i++){
                 if (arr[i] > arr[i - 1])
                     largest = arr[i];
             }
             Console.WriteLine(largest);*/


            //✅ Task 3
            /* for (int i = 1; i <= 10; i++)
             {
                 Console.Write(i + " ");
             }
             for (int i = 1; i <= 10; i+=2)
             {
                     Console.Write(i + " ");
             }*/


            //✅ Task 4: Data Conversion Using Conver
            /*try
            {
                Console.Write("Enter your full name: ");
                string fullName = Console.ReadLine();
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your height (in meters): ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Are you employed? (true/false): ");
                bool isEmployed = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("\n--- User Profile ---");
                Console.WriteLine($"Name: {fullName}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Height: {height} ");
                Console.WriteLine($"Employed: {isEmployed}");
            }
            catch (FormatException)
            {
                Console.WriteLine("⚠️ Invalid input format! Please enter correct data types.");
            }
            catch (Exception)
            {
                Console.WriteLine("⚠️ Something went wrong. Please try again.");
            }*/


            //✅ Task 5 – Strings
            /*Console.Write("Enter your  name: ");
            string name =Console.ReadLine();
            string nameUpper=name.ToUpper();
            string nameLower=name.ToLower();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upper: " + nameUpper);
            Console.WriteLine("Lower: " + nameLower);
            Console.WriteLine($"Hello {name}, you are {age} years old.");

            Console.WriteLine("First letter: " + name[0]);
            Console.WriteLine("Last letter: " + name[name.Length-1]);

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Name:\t" + name);
            Console.WriteLine("Age: " + age);*/
            
             
             
             


            //✅ Task – Break & Continue
            /*for (int i = 1; i <= 10; i++)
                       {
                           if (i % 3 == 0) continue;
                           if (i == 8) break;
                           Console.WriteLine(i);
                       }*/
        }
    }
}
