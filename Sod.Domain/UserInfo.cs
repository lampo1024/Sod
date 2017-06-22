using System;

namespace Sod.Domain
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string RealName { get; set; }
        public string EmailAddress { get; set; }
        public string Avatar { get; set; }
        public string Telephone { get; set; }
        public string Qq { get; set; }
        public string WebsiteUrl { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedIp { get; set; }
        public int LoginCount { get; set; }
        public DateTime? LatestLoginDate { get; set; }
        public string LatestLoginIp { get; set; }
        /// <summary>
        /// 用户的状态,0:禁用,1:正常
        /// </summary>
        public int Status { get; set; }
        public bool IsEmailAddressVerified { get; set; }
        public DateTime? EmailAddressVerifiedDate { get; set; }
        /// <summary>
        /// 用户激活码
        /// </summary>
        public string ActiveCode { get; set; }
        /// <summary>
        /// 用户激活码发送时间
        /// </summary>
        public DateTime? ActiveCodeSendDate { get; set; }
        /// <summary>
        /// 用户发送激活码次数
        /// </summary>
        public int ActiveCodeSendCount { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
