using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            string name = "Azhar";
            int age = 23;
            Console.WriteLine($"My name is {name} and I am {age} years old");

            //task2
            Console.WriteLine("enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
                Console.WriteLine($"{x} is even number");
            else
                Console.WriteLine($"{x} is odd number");

            //task3
            Console.WriteLine("enter a text: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            //task4
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
                Console.WriteLine("the number is zero");
            else if (num > 0)
                Console.WriteLine("it's a positive number");
            else if (num < 0)
                Console.WriteLine("its a negative number");

            //task5
            Console.WriteLine("enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                Console.WriteLine(" leap year");
            else
                Console.WriteLine(" not a leap year");

            //task6
            Console.WriteLine("enter your grade:");
            int grade1 = Convert.ToInt32(Console.ReadLine());

            if (grade1 > 50)
                Console.WriteLine("pass");
            else
                Console.WriteLine("fail");

            //task7
            Console.WriteLine("enter  first number");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number ");
            int sNum = Convert.ToInt32(Console.ReadLine());
            if (fNum > sNum)
                Console.WriteLine("{fNum} is  the bigger number ");
            else if (fNum < sNum)
                Console.WriteLine("{sNum} is the bigger number");
            else
                Console.WriteLine("The numbers are equal");

            //task8
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 5 == 0 && num1 % 3 == 0)
                Console.WriteLine("The number is divisible by 5 and 3");
            else
                Console.WriteLine("The number is NOT divisible by 5 and 3");

            //task9
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadLine()[0]);

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");

            //task10
            Console.WriteLine("enter your age ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            if (age1 <= 10)
                Console.WriteLine("you are a child!");
            else if (age1 > 11 && age1 <= 18)
                Console.WriteLine("you are a teenager!");
            else if (age1 > 19)
                Console.WriteLine("you are an adult !");

            //task11
            Console.Write("Enter a number (1-7): ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }

            //task12
            Console.Write("Enter a number (1-12): ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }

            //task13
            Console.Write("Enter first number: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double z = double.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (y + z));
                    break;

                case '-':
                    Console.WriteLine("Result: " + (y - z));
                    break;

                case '*':
                    Console.WriteLine("Result: " + (y * z));
                    break;

                case '/':
                    if (z != 0)
                        Console.WriteLine("Result: " + (num1 / z));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            //task14
            Console.WriteLine("enter  your grade ");
            string grade = Console.ReadLine();

            switch (grade.ToUpper())
            {
                case "A": Console.WriteLine("Excellent"); break;
                case "B": Console.WriteLine("Very Good"); break;
                case "C": Console.WriteLine("Good"); break;
                case "D": Console.WriteLine("Pass"); break;
                case "E": Console.WriteLine("Fail"); break;
            }

            //task15
            Console.Write("Enter a number (1-3): ");
            int options = int.Parse(Console.ReadLine());

            switch (options)
            {
                case 1:
                    Console.WriteLine(" option 1");
                    break;

                case 2:
                    Console.WriteLine(" option 2");
                    break;

                case 3:
                    Console.WriteLine("option 3");
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            //task16
            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (num2 % 2)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;

                case 1:
                    Console.WriteLine("Odd");
                    break;
            }

            //task17
            Console.Write("Enter your role : ");
            string role = Console.ReadLine();
            switch (role)
            {
                case "Admin":
                    Console.WriteLine("Logged in by Admin");
                    break;

                case "User":
                    Console.WriteLine("Logged in by User");
                    break;

                case "Guest":
                    Console.WriteLine("Logged in by Guest");
                    break;

                default:
                    Console.WriteLine("Invalid role");
                    break;
            }

            //task18
            Console.WriteLine("THE IT COURSES: ");
            Console.WriteLine("JAVA");
            Console.WriteLine("FLUTTER");
            Console.WriteLine("C++");
            string course = Console.ReadLine();

            switch (course)
            {
                case "JAVA":
                    Console.WriteLine("THE COARSE JAVA IS ADDED");
                    break;

                case "FLUTTER":
                    Console.WriteLine("THE COARSE FLUTTER IS ADDED");
                    break;
                case "C++":
                    Console.WriteLine("THE COARSE C++ IS ADDED");
                    break;
                default:
                    Console.WriteLine("Invalid course");
                    break;
            }
            //🟦 If Statements – Advanced  Questions
            //task1
            Console.WriteLine("enter  your performance rating: ");
            int rate = Convert.ToInt32(Console.ReadLine());

            if (rate >= 90 && rate <= 100)
                Console.WriteLine("Excellent + 20% bonus");
            else if (rate >= 75 && rate < 90)
                Console.WriteLine("Very Good + 15% bonus");
            else if (rate >= 60 && rate < 75)
                Console.WriteLine("Good + 10% bonus");
            else if (rate < 60)
                Console.WriteLine("No bonus");
            else
                Console.WriteLine("Invalid rate number. Please enter a number between 1 and 5.");

            //task2
            Console.WriteLine("Enter Your GPA");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Did you pass your English course? (yes/no)");
            string passedEnglishTest = Console.ReadLine().ToLower();
            Console.WriteLine("Do you have a special Recommendation? (yes/no)");
            string hasRecommendation = Console.ReadLine().ToLower();

            if ((gpa >= 85 && passedEnglishTest == "yes") || hasRecommendation == "yes")
                Console.WriteLine("You are eligible for the University admission");
            else
                Console.WriteLine("You are not eligible for the University addmission");

            //task3
            Console.WriteLine("Enter the weight of the package in kg");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight <= 1)
                Console.WriteLine("The shipping cost is $5");
            else if (weight > 1 && weight <= 5)
                Console.WriteLine("The shipping cost is $10");
            else if (weight > 5 && weight <= 10)
                Console.WriteLine("The shipping cost is $20");
            else
            {
                Console.WriteLine("Warning: The package is HEAVY!! and ");
                Console.WriteLine("The shipping cost is $50");
            }

            //task4
            string correctUsername = "admin";
            string correctPassword = "1234";
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Invalid credentials");
                }
            }
            Console.WriteLine("Account locked");

            //🟨 Switch Statements – Advanced Questions
            //task1
            Console.Write("Enter menu choice (1-4): ");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1: Console.WriteLine("Burger - $5"); break;
                case 2: Console.WriteLine("Pizza - $8"); break;
                case 3: Console.WriteLine("Pasta - $7"); break;
                case 4: Console.WriteLine("Salad - $4"); break;

            }

            //task2
            Console.Write("Enter grade (A-F): ");
            char grade2 = Console.ReadLine()[0];

            switch (grade2)
            {
                case 'A': Console.WriteLine("Excellent"); 
                    break;
                case 'B': Console.WriteLine("Very Good");
                    break;
                case 'C': Console.WriteLine("Good"); 
                    break;
                case 'D': Console.WriteLine("Pass"); 
                    break;
                case 'F': Console.WriteLine("Fail"); 
                    break;
            }

            //task3
            Console.WriteLine("enter option number (1-4):");
            int optionNum= Convert.ToInt32(Console.ReadLine());
            int balance = 5000;

            switch (optionNum) {
                case 1:
                    Console.WriteLine("Your Balance is : {balance}");
                    break;

                case 2:
                    Console.Write("Enter amount to deposit: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine("New balance: " + balance);
                    break;

                    case 3:
                    Console.Write("Enter amount to withdraw: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw <= balance)

                    {
                        balance -= withdraw;
                        Console.WriteLine("New balance: " + balance);
                    }
                    else
                        Console.WriteLine("Insufficient balance");
                    break;
            }

            //task4
            Console.Write("Enter first number: ");
            double First = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char operator1 = char.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());
            switch (operator1)
            {
                case '+':
                    Console.WriteLine("Result: " + (First + second));
                    break;

                case '-':
                    Console.WriteLine("Result: " + (First - second));
                    break;

                case '*':
                    Console.WriteLine("Result: " + (First * second));
                    break;

                case '/':
                    if (second != 0)
                        Console.WriteLine("Result: " + (First / second));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    }
}
