using System;

namespace Sod.Domain
{
    /// <summary>
    /// 我的收藏实体类
    /// </summary>
    public class TsCollection
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
        public string IpAddress { get; set; }
    }
}
