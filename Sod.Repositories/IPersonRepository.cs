using System.Collections.Generic;
using Sod.Domain;

namespace Sod.Repositories
{
    public interface IPersonRepository
    {
        Person FindById(int id);
        IEnumerable<Person> FindAll();
    }
}
