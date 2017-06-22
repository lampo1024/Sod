using System;

namespace Sod.Domain
{
    /// <summary>
    /// 文章浏览历史表
    /// </summary>
    public class TsPostViewHistory
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string IpAddress { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}