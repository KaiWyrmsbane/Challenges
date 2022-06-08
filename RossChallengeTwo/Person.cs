using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossChallengeTwo
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public int age { get; set; }

        public Person(string firstName, string lastName)
        {
            firstName = firstName;
            lastName = lastName;
            fullName = $"{firstName}, {lastName}";

        }

        public void DisplayFullNameOfEmployee()
        {
            Console.WriteLine(this.fullName);
        }
    }
}
