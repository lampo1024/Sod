using System.Collections.Generic;
using Sod.Domain.QueryModel;
using Sod.Dba;

namespace Sod.Services
{
    public interface IAddressService
    {
        IPagedList<AddressWithPersonName> FindAllAddressWithPersonNames(int pageIndex = 0, int pageSize = 20);
        IEnumerable<AddressWithPersonName> FindAddressWithPersonNamesByPersonId(int personId);
    }
}
