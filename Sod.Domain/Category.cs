using System;

namespace Sod.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int Parent { get; set; }
        public string Icon { get; set; }
        public int Sort { get; set; }
        public bool IsShow { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int ChildCount { get; set; }
        public int PostCount { get; set; }
    }
}
