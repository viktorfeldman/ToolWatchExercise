using System;

namespace CacheLibrary
{
    public class Person
    {

        public Person(int personId, string lastName, string firstName)
        {
            PersonId = personId;
            LastName = lastName;
            FirstName = firstName;
        }
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string toString()
        {
            return PersonId.ToString() + " " + FirstName + " " + LastName;
        }
    }
}
