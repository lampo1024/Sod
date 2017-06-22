using System;

namespace Sod.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
