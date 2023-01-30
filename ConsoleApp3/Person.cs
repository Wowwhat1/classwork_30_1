using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Person
    {
        private string _name;
        private int _age;
        private double _salary;
        public string Name { get => _name; 
            set {
                if (value.Length > 3)
                {
                    _name = value;
                } else
                {
                    Console.WriteLine("Name must be contains more than 3 characters! Please try again!");
                    Name = Console.ReadLine();
                }
            } }
        public int Age { get => _age; 
            set {
                if (value < 0 || value == 0)
                {
                    Console.WriteLine("Age cannot be zero or negative! Please try again!");
                    Age = int.Parse(Console.ReadLine());
                } else
                {
                    _age = value;
                }
            } }

        public double Salary { get => _salary;
            set
            {
                if (value < 460)
                {
                    Console.WriteLine("Salary cannot be less than 460! Please try again!");
                    Salary = double.Parse(Console.ReadLine());
                }
                else
                {
                    _salary = value;
                }
            } }

        public Person() { }

        public Person(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            if (this.Age > 30)
                this.Salary += this.Salary * percentage / 100;
            else
                this.Salary += this.Salary * percentage / 200;
        }

        public override string ToString()
        {
            return $"{Name} is {Age} years old {Salary}$/month.";
        }
    }
}
