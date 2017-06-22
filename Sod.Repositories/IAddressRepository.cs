using System.Collections.Generic;
using Sod.Dba;
using Sod.Domain.QueryModel;

namespace Sod.Repositories
{
    public interface IAddressRepository
    {
        IPagedList<AddressWithPersonName> FindAllAddressWithPersonNames(int pageIndex = 0, int pageSize = 20);
        IEnumerable<AddressWithPersonName> FindAddressWithPersonNamesByPersonId(int personId);
    }
}
