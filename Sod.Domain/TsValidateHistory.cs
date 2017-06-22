using System;

namespace Sod.Domain
{
    public class TsValidateHistory
    {
        public int Id { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// 操作类型:forgot,active
        /// </summary>
        public string Type { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? ExpiredDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
        /// <summary>
        /// 使用时间
        /// </summary>
        public DateTime? ValidateDate { get; set; }
    }
}
