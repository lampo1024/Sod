using System;

namespace Sod.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string AuthorName { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// 0:锁定,1:正常
        /// </summary>
        public int Status { get; set; }
        public bool IsOpenComment { get; set; }
        public string ReadPassword { get; set; }
        public int ReadMinPoints { get; set; }
        public string FriendlyUrl { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string PermanentUrl { get; set; }
        public int ViewCount { get; set; }
        public DateTime? LatestViewDate { get; set; }
        public int CommentCount { get; set; }
        public DateTime? LatestCommentDate { get; set; }
        public int LikeCount { get; set; }
        public DateTime? LatestLikeDate { get; set; }
        public int UnlikeCount { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        /// <summary>
        /// 已选择的标签名称字符串
        /// </summary>
        public string SelectedTagNames { get; set; }
        /// <summary>
        /// 已选择的标签ID字符串
        /// </summary>
        public string SelectedTagIds { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsStick { get; set; }
    }
}
