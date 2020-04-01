using NUnit.Framework;
using CacheLibrary;
namespace PersonTests
{
    public class PersonTest
    {
      

        [Test]
        public void CreateUpdatePerson_AddPerson_Checkreturnperon()
        {
       
            var count = PersonCache.PersonCount();
            Person person = new Person(10000001, "Test", "Test");
            var person2 = PersonCache.CreateUpdatePerson(person);
            person2 = PersonCache.GetPerson(10000001);
            Assert.AreEqual(person2, person);
            Assert.AreEqual(PersonCache.PersonCount(), count+1);
        }

        [Test]
        public void CreateUpdatePerson_UpdatePerson_Checkreturnperon()
        {
            PersonCache.RemovePerson(10000001);
            Person person = new Person(10000001, "Test", "Test");
            var person2 = PersonCache.CreateUpdatePerson(person);
            person.FirstName = "Test2";
            person2 = PersonCache.CreateUpdatePerson(person);
            person2 = PersonCache.GetPerson(10000001);
            Assert.AreEqual(person2.FirstName, "Test2");
        }

        [Test]
        public void RemovePerson_CountShoudbe0()
        {

            var count = PersonCache.PersonCount();
            Person person = new Person(10000001, "Test", "Test");
            var person2 = PersonCache.CreateUpdatePerson(person);
            person2 = PersonCache.GetPerson(10000001);
            PersonCache.RemovePerson(10000001);
            Assert.AreEqual(PersonCache.PersonCount(), 0);
        }



    }
}