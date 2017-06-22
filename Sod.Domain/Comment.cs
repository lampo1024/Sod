using System;

namespace Sod.Domain
{
    /// <summary>
    /// 文章评论
    /// </summary>
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string AuthorUrl { get; set; }
        public string AuthorIp { get; set; }
        public string UserAgent { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Content { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int ParentId { get; set; }
        public bool EmailNotify { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
