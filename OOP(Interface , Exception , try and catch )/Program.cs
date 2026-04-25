using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface___Exception___try_and_catch__
{
    internal class Program
    {
        //----------------✅ Task – Interface & Exception----------------
        interface ICalculator
        {
            double Add(int a, int b);
        }

        class Calculator : ICalculator
        {
             public double Add(int a, int b)
            {
                return a + b;
            }
        }







        static void Main(string[] args)
        {
            //----------------✅ Task – Interface & Exception----------------
            Calculator cal = new Calculator();
            try
            {
                Console.WriteLine("enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sum of the numbers= "+cal.Add(num1,num2));

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            //----------------✅ Task – File Handling & Library----------------
            try
            {
                string[] Lines = File.ReadAllLines("data.txt");
                foreach (string line in Lines)
                {
                    Console.WriteLine(line);
                }
                File.AppendAllText("data.txt", "\nFullStack developer");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("⚠ File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error: " + ex.Message);
            }










            }
        }
}
