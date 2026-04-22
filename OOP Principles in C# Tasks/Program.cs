using OOP_Principles_in_C__Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C__Tasks
{
    //-----------------------------------Task1: Static Class-----------------------------------
    public static class MathUtilities
    {
        public static int Sqr(int num)
        {
            return num * num;
        }
        public static double Sqrt(int num)
        {
            return Math.Sqrt(num);
        }
        public static int MaximumNum(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
    }

    //-----------------------------------Task2: Static Method-----------------------------------
    public class Conventer
    {
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        public static double KilometersToMiles(double km)
        {
            return km * 0.621371;
        }
    }

    //-----------------------------------Task3: Static Field-----------------------------------
    public class VisitorCounter
    {
        public static int visitorsNum;

        public VisitorCounter() { visitorsNum++; }

    }

    //-----------------------------------Task3: Static Property-----------------------------------
    public class Company
    {
        public static string CompanyName { set; get; }
        public string EmpName { set; get; }
        public Company(string e) { EmpName = e; }
        public void PrintInfo()
        {
            Console.WriteLine("company Name: " + CompanyName + "-Employee Nmae: " + EmpName);
        }

    }


    //-----------------------------------✅ Task – OOP Principles-----------------------------------
    //---------------------------------------------Task1------------------------------------------
    public class Principles
    {
        public double add(int a, int b)
        {
            return a + b;
        }
        public double add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class Animal
    {
        public virtual void Speak() { Console.WriteLine("Animal Method"); }
    }
    public class Cat : Animal {
        public override void Speak() { Console.WriteLine("Cat Method"); }
    }

    public class Person {
        private int id;
        public string name;
    }
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Rectangle : Shape
    {
        public int w, h;
        public override double GetArea()
        {
            return w * h;
        }
    }

    //---------------------------------------------Task2: Polymorphism (Method Overloading)------------------------------------------
    class Calculator
    {
        public double Add(int x, int y) { return x + y; }
        public double Add(int x, int y, int z) { return x + y + z; }
        public double Add(double x, double y) { return x + y; }
    }

    //---------------------------------------------Task3: Polymorphism (Method Overriding)------------------------------------------
    class Animal1
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Make Sound Method");
        }
    }

    class Dog1 : Animal1
    {
        public override void MakeSound()
        {
            Console.WriteLine("Make Dog Sound Method");
        }
    }
    class Cat1 : Animal1
    {
        public override void MakeSound()
        {
            Console.WriteLine("Make Cat Sound Method");
        }
    }

    //---------------------------------------------Task4: Abstraction------------------------------------------
    abstract class Appliance
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public string Brand { get; set; }
    }
    class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($"WashingMachine brand is {Brand}:start a WashMachine cycle");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"WashingMachine brand is {Brand}:stop a WashMachine cycle");
        }
    }

    class AirConditioner : Appliance
    {

        public override void TurnOn()
        {
            Console.WriteLine($"AirConditioner brand is {Brand}:activate a cool mode");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"AirConditioner brand is {Brand}:shutdown a cool mode");
        }
    }


    //---------------------------------------------Tasks: Encapsulation------------------------------------------
    class BankAccount
    {
        private double Balance = 5000;
        public void Deposit(double cash)
        {
            Balance += cash;
            Console.WriteLine($"Deposited: {cash}");
        }
        public void Withdraw(double cash)
        {
            if (cash > Balance)
            {
                Console.WriteLine("Insufficient balance! ");
            }
            else
            {
                Balance -= cash;
                Console.WriteLine($"Withdrawn: {cash}");
            }
        }
        public double ReadBalance { get { return Balance; } }
    }


    //---------------------------------------------Task6: Abstract Class------------------------------------------
    abstract class Employee
    {
        public string Name { get; set; }
        public abstract double CalculateSalary();
    }
    class FullTimeEmployee : Employee
    {
        public double Salary;
        public override double CalculateSalary()
        {
            return 500 + Salary;
        }

    }

    class PartTimeEmployee : Employee
    {
        public double HoursWorked { get; set; }
        public double HourRate { get; set; }

        public PartTimeEmployee(double hours, double rate)
        {
            HoursWorked = hours;
            HourRate = rate;
        }
        public override double CalculateSalary()
        {
            return HoursWorked * HourRate;
        }
    } 
    







    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------Task1: Static Class-----------------------------------
            Console.WriteLine("square of number 10: "+ MathUtilities.Sqr(10));
            Console.WriteLine("square root of number 4: " + MathUtilities.Sqrt(4));
            Console.WriteLine("max number : " + MathUtilities.MaximumNum(10,70));

            //-----------------------------------Task2: Static Method-----------------------------------
            Console.WriteLine("Temperature in Fahrenheit:"+ Conventer.CelsiusToFahrenheit(11));
            Console.WriteLine("Distance in Miles:" + Conventer.KilometersToMiles(50));

            //-----------------------------------Task3: Static Field-----------------------------------
            VisitorCounter v1= new VisitorCounter();
            VisitorCounter v2 = new VisitorCounter();
            VisitorCounter v3 = new VisitorCounter();

            Console.WriteLine("Number of visitors: " + VisitorCounter.visitorsNum);


            //-----------------------------------Task4: Static Property-----------------------------------
            Company.CompanyName = "Orange";
            Company emp1 = new Company("Azhar");
            Company emp2 = new Company("Sara");
            Company emp3 = new Company("Khaled");
            emp1.PrintInfo();
            emp2.PrintInfo();
            emp3.PrintInfo();


            //-----------------------------------✅ Task – OOP Principles-----------------------------------
            //---------------------------------------------Task1------------------------------------------
            Rectangle r= new Rectangle();
            r.h = 3;
            r.w = 7;
            Console.WriteLine(r.GetArea());

            //---------------------------------------------Task2: Polymorphism (Method Overloading)------------------------------------------
            Calculator c= new Calculator();
            Console.WriteLine(c.Add(1, 2));
            Console.WriteLine(c.Add(1, 2,3));
            Console.WriteLine(c.Add(5.1, 1));

            //---------------------------------------------Task3: Polymorphism (Method Overriding)------------------------------------------
           Dog1 d= new Dog1();
            d.MakeSound();

            Cat1 c1 = new Cat1();
            c1.MakeSound();

            //---------------------------------------------Task4: Abstraction------------------------------------------
            WashingMachine wash1 = new WashingMachine();
            wash1.Brand = "Candy";
            wash1.TurnOn();
            wash1.TurnOff();

            AirConditioner airCond = new AirConditioner();
            airCond.Brand = "LG";
            airCond.TurnOn();
            airCond.TurnOff();

            //---------------------------------------------Task5: Encapsulation------------------------------------------
            BankAccount acc=new BankAccount();
            acc.Withdraw(1000);
            Console.WriteLine("New balance: "+ acc.ReadBalance);

            //---------------------------------------------Task6: Abstract Class------------------------------------------

            FullTimeEmployee fullEmp1=new FullTimeEmployee();
            fullEmp1.Name = "khaled";
            fullEmp1.Salary = 1000;
            Console.WriteLine("the salary for  " + fullEmp1.Name + " is : " + fullEmp1.CalculateSalary());

            Employee partEmp1 = new PartTimeEmployee(20, 15);
            partEmp1.Name = "sara";
            Console.WriteLine("the salary for  " + partEmp1.Name + " is : " + partEmp1.CalculateSalary());



















    }
}
}
