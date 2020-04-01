using CacheLibrary;
using System;

namespace CacheConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            var person = PersonCache.CreateUpdatePerson(new Person(10000001, lastName, firstName));
            Console.WriteLine("Create Person:" + person.toString());

            Console.WriteLine("Presss enter to close");
            Console.ReadLine();
        }
    }
}
