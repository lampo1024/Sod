using System;

namespace Sod.Domain
{
    /// <summary>
    /// 文章-标签关系映射类
    /// </summary>
    public class TagPostMapping
    {
        public int TagId { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
