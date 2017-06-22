using System.Collections.Generic;
using ServiceStack.OrmLite;
using Sod.Dba;
using Sod.Domain;
using Sod.Domain.QueryModel;

namespace Sod.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public IPagedList<AddressWithPersonName> FindAllAddressWithPersonNames(int pageIndex=0,int pageSize=20)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                var entities = db.Select<AddressWithPersonName>("SELECT * FROM Address AS A LEFT JOIN Person AS P ON A.PersonId=P.Id");
                var totalCount = db.Scalar<long>("SELECT COUNT(*) FROM Address AS A LEFT JOIN Person AS P ON A.PersonId=P.Id");
                var list = new PagedList<AddressWithPersonName>(entities, pageIndex, pageSize, (int)totalCount);
                return list;
            }
        }

        public IEnumerable<AddressWithPersonName> FindAddressWithPersonNamesByPersonId(int personId)
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                var list = db.Select<AddressWithPersonName>("SELECT * FROM Address AS A LEFT JOIN Person AS P ON A.PersonId=P.Id WHERE A.PersonId=@PersonId", new { PersonId = personId });
                return list;
            }
        }
    }
}
