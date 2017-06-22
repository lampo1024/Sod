/* 
 *   Author:    Liubo
 *   Created:   2017
 *   Description:    
 */

using System.Collections;
using System.Collections.Generic;
using ServiceStack.OrmLite;
using Sod.Domain;

namespace Sod.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public IEnumerable<Person> FindPerson()
        {
            using (var db = DbConnectionFactory.GetDbConnection())
            {
                var list = db.Select<Person>("");
                return list;
            }
        }
    }
}
