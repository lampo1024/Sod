using System;

namespace Sod.Domain.QueryModel
{
    public class MyCollectionQueryModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string PostTitle { get; set; }

        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public string PermanentUrl { get; set; }
    }
}
