using System;
using System.Linq;

namespace ExistingDBPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize our database interaction (the context):
            using(PersonContext context = new PersonContext())
            {
                string firstName;
                Console.WriteLine("Please enter the first name ");
                firstName = Console.ReadLine().Trim().ToLower();

                Console.WriteLine("The person's full name is: ");
                Console.WriteLine(context.Persons.Where(x => x.FirstName.ToLower() == firstName).SingleOrDefault().FirstName.ToString());
            }
        }
    }
}
