using System;
using ServiceStack.DataAnnotations;

namespace Sod.Domain.QueryModel
{
    public class AddressWithPersonName
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
