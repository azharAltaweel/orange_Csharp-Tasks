using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_C__Tasks1
{
    //-------------------------------Task1-------------------------------
    class Person
    {
        public string Name { get; set; }
        private int Age;
        public void setAge(int age) {  this.Age = age; }
        public int getAge() { return Age; }

        public void PrintPersonInfo()
        {
            Console.WriteLine("Person name: "+ Name +" "+" Age: "+ Age);
        }
    }
    class Student: Person
    {
        private int Id;

        public void setId(int id) { this.Id = id; }
        public int getId() { return Id; }
        public void PrintStdId()
        {
            Console.WriteLine("student id: "+Id+"\n");
        }
    }



    //-------------------------------Task2-------------------------------
    class Car
    {
        public string Make {  get; set; }
        public int Year {  get; set; }
        public string Type { get; set; }
        public double   Price { get; set; }
        public string Model { get; set; }
        public string PalletNo { get; set; }
        public string Color { get; set; }

        private bool isEnginOn = false;
        public Car(string m, int y, string t, double p, string mod, string pal, string c)
        {
            Make = m;
            Year = y;
            Type = t;
            Price = p;
            Model = mod;
            PalletNo = pal;
            Color = c;  
        }
         public void setEnginOn()
        {
            if (!isEnginOn)
            {
                isEnginOn = true;
                Console.WriteLine("Engine started.\n");
            }
            else
                Console.WriteLine("Engine is already running.\n");
        }
        public void setEnginOff()
        {
            if (isEnginOn)
            {
                isEnginOn = false;
                Console.WriteLine("Engine stoped.\n");
            }
            else
                Console.WriteLine("Engine is already off.\n");
        }

        public string GetCarInfo() {
        return $"Make: {Make} | Model: {Model} | Year: {Year}\n" +
           $"Type: {Type} | Price: ${Price}\n" +
           $"Pallet No: {PalletNo} | Color: {Color}\n" +
           $"Engine Status: {(isEnginOn ? "Running" : "Stopped")}\n";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------Task1-------------------------------
            Person p = new Person();
            p.Name = "Azhar";
            p.setAge(23);
            p.PrintPersonInfo();

            Student s1= new Student();
            s1.setId(1);
            s1.Name = "sara";
            s1.setAge(25);
            s1.PrintPersonInfo();
            s1.PrintStdId();



            //-------------------------------Task2-------------------------------
            Car car1 = new Car("Toyota",2022,"Sedan",20000,"coralla","p12345","white");
            Console.WriteLine(car1.GetCarInfo());
            car1.setEnginOn();
            Console.WriteLine(car1.GetCarInfo());


        }
    }
}
