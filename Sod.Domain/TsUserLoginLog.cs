using System;

namespace Sod.Domain
{
    /// <summary>
    /// 用户登录日志实体类
    /// </summary>
    public class TsUserLoginLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string OperatingSystem { get; set; }
        public string SystemVersion { get; set; }
        public string Browser { get; set; }
        public string BrowserVersion { get; set; }
        public string IpAddress { get; set; }
        public string ScreenResolution { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Device { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
