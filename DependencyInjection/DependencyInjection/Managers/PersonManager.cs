using DependencyInjection.Models;

namespace DependencyInjection.Managers
{
    public class PersonManager
    {
        private Person _person;
        private IPersonDataManager _personDataManager;

        public IPersonDataManager PersonDataManager
        {
            get { return _personDataManager; }
            set { _personDataManager = value; }
        }

        public PersonManager(Person person)
        {
            _person = person;
        }

        public void Save()
        {
            _personDataManager.Save(_person);
        }
    }
}
