using System;

namespace Sod.Domain
{
    /// <summary>
    /// 搜索历史记录表
    /// </summary>
    public class TsSearchHistory
    {
        public int Id { get; set; }
        public string Keyword { get; set; }
        public string IpAddress { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}