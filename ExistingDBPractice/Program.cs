﻿using System;
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

                Person outputFirstName = context.Persons.Where(x => x.FirstName.ToLower() == firstName).SingleOrDefault();

                if(outputFirstName != null)
                {
                    Console.WriteLine($"The full name of the person is {outputFirstName.FirstName} {outputFirstName.LastName}.");
                }
                else 
                {
                    Console.WriteLine("There is no such name.");
                }


            }
        }
    }
}
