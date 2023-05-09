using DataModel.Domain;
using DataModel.Domain.Custom;

namespace DataModel.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        PersonQuery GetPersonDetails(Person person);
    }
}
