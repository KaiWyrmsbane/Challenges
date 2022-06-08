using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RossChallengeTwo;

namespace CodeLouvillePlayground
{
    public class Employee: Person
    {
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public int salary { get; set; }
        //create a variable for length of time working for the company
        public float monthsOnJob { get; set; }

        //takes care of the cs7036 error
        public Employee(string title, DateTime start, int salary, float monthsOnJob, string firstName, string lastName)
            : base(firstName, lastName)
        {
            Title = title;
            Start = start;
            this.salary = salary;
            this.monthsOnJob = monthsOnJob;
        }

        public void DoWork()
        {
            Console.WriteLine("I am working");
        }

        public void DoWork(string workingTask)
        {
            Console.WriteLine($"I am working on {workingTask}");
        }

        public void ShowTitle()
        {
            Console.WriteLine($"My Title is {this.Title}");
        }

        public void ShowPay()
        {
            Console.WriteLine($"My pay is: {salary}");
        }

        //create a method to handle whether an employee gets a bonus or not working over 6 months
        public void BonusOrNoBonus(float monthsOnJob)
        {
            if (monthsOnJob >= 6.0f)
            {
                Console.WriteLine($"Employee is eligible for bonus, they've been working for {monthsOnJob}");
                PayIncrease(salary);
            }
            else
            {
                Console.WriteLine($"Employee isn't eligible for bonus, they've been working for {monthsOnJob}");
            }
        }

        //create a method to add 25% to the pay if employee is eligable for bonus
        public void PayIncrease(float salary)
        {
            float payRaise = salary * 0.25f;
            salary += payRaise;
            Console.WriteLine($"Emplpoyee new pay is {salary}");
        }

    }
}
