using System;
using ServiceStack.DataAnnotations;

namespace Sod.Domain
{
    [Alias("Person")]
    public class Person
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
