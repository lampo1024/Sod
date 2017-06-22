using System;

namespace Sod.Domain
{
    /// <summary>
    /// 日志表
    /// </summary>
    public class TsLog
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Location { get; set; }
        public string Summary { get; set; }
        public string Message { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public string IpAddress { get; set; }
    }
}