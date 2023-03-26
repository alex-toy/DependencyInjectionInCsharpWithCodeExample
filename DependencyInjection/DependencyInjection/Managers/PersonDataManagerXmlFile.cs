using DependencyInjection.Models;
using System;

namespace DependencyInjection.Managers
{
    public class PersonDataManagerXmlFile : IPersonDataManager
    {
        public void Save(Person person)
        {
            Console.WriteLine($"Person {person.FirstName} {person.LastName} is saved to a xml file.");
        }
    }
}
