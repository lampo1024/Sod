using System.Collections.Generic;
using Sod.Domain;

namespace Sod.Services
{
    public interface IPersonService
    {
        Person FindById(int id);
        IEnumerable<Person> FindAll();
    }
}
