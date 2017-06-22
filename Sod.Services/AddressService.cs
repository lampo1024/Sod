using System.Collections.Generic;
using Sod.Dba;
using Sod.Domain.QueryModel;
using Sod.IoC;
using Sod.Repositories;

namespace Sod.Services
{
    public class AddressService : IAddressService, IDependency
    {
        private readonly IAddressRepository _repository;

        public AddressService(IAddressRepository repository)
        {
            _repository = repository;
        }

        public IPagedList<AddressWithPersonName> FindAllAddressWithPersonNames(int pageIndex = 0, int pageSize = 20)
        {
            return _repository.FindAllAddressWithPersonNames(pageIndex, pageSize);
        }

        public IEnumerable<AddressWithPersonName> FindAddressWithPersonNamesByPersonId(int personId)
        {
            return _repository.FindAddressWithPersonNamesByPersonId(personId);
        }
    }
}
