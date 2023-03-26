using DependencyInjection.Models;
using System;

namespace DependencyInjection.Managers
{
    public class PersonDataManagerTextFile : IPersonDataManager
    {
        public void Save(Person person)
        {
            Console.WriteLine($"Person {person.FirstName} {person.LastName} is saved to a text file.");
        }
    }
}
