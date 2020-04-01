using System;
using System.Collections.Generic;
using System.Runtime.Caching;


namespace CacheLibrary
{
    public static class PersonCache
    {
        private static MemoryCache cache = new MemoryCache("Person");
        private static CacheItemPolicy policy = new CacheItemPolicy();
        
        public static Person CreateUpdatePerson(Person person)
        {
            policy.AbsoluteExpiration =
                    DateTimeOffset.Now.AddSeconds(600.0);

            if (cache[person.PersonId.ToString()] == null)
            {
                cache.Add(person.PersonId.ToString(), person, policy);
            }
            {
                cache[person.PersonId.ToString()] = person;
            }
            return person;
        }

        public static void RemovePerson(int personId)
        {
            if (cache[personId.ToString()] != null)
            {
                cache.Remove(personId.ToString());
            }
        }

        public static Person GetPerson(int personId)
        {
            if (cache[personId.ToString()] != null)
            {
                return cache[personId.ToString()] as Person;
            }
            else return null;
        }

        public static long PersonCount()
        {
            return cache.GetCount();
        }

        public static void ClearPersons()
        {
            cache.Dispose();
        }

    }
}
