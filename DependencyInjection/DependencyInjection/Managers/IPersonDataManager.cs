using DependencyInjection.Models;

namespace DependencyInjection.Managers
{
    public interface IPersonDataManager
    {
        void Save(Person person);
    }
}
