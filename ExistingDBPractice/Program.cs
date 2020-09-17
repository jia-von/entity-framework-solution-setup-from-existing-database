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
                //string firstName;
                //Console.WriteLine("Please enter a model to remove: ");
                //firstName = Console.ReadLine().Trim().ToLower();

                Console.WriteLine(context.Persons.Where(x => x.FirstName == "Tommy").SingleOrDefault());
            }
        }
    }
}
