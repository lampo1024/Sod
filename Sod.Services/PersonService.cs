using System.Collections.Generic;
using Sod.Domain;
using Sod.IoC;
using Sod.Repositories;

namespace Sod.Services
{
    public class PersonService:IPersonService, IDependency
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }
        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<Person> FindAll()
        {
            return _repository.FindAll();
        }
    }
}
