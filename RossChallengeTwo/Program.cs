using System;
using System.Collections.Generic;

namespace CodeLouvillePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            Employee employee1 = new Employee("Programmer", DateTime.Now, 0, 30,"James", "VanMeter");
            employee1.DisplayFullNameOfEmployee();
            employee1.BonusOrNoBonus(employee1.monthsOnJob);

           
        }
    }
}
