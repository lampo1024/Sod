using System;

namespace Sod.Domain
{
    public class PostLikeHistory
    {
        public int PostId { get; set; }
        public string IpAddress { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
