using DependencyInjection.Managers;
using DependencyInjection.Models;
using System;
using System.Configuration;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FirstName = "alex", LastName = "bg"};

            PersonManager personManager = new PersonManager(person);
            personManager.PersonDataManager = new PersonDataManagerTextFile();
            personManager.Save();

            personManager.PersonDataManager = new PersonDataManagerXmlFile();
            personManager.Save();

            personManager.PersonDataManager = new PersonDataManagerSqlDb();
            personManager.Save();

            // Retrieve IPersonDataManager from App.config
            string personDataManagerTypeSetting = ConfigurationManager.AppSettings["PersonDataManagerType"];
            Type personDataManagerType = Type.GetType($"DependencyInjection.Managers.{personDataManagerTypeSetting}");
            personManager.PersonDataManager = Activator.CreateInstance(personDataManagerType) as IPersonDataManager;
            personManager.Save();

            System.Console.ReadLine();
        }
    }
}
