using System;

namespace Sod.Domain.QueryModel
{
    public class MyFavoriteQueryModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string PostTitle { get; set; }

        public DateTime CreatedOn { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public string PermanentUrl { get; set; }
    }
}
