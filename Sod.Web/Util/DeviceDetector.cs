using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.WebPages;

namespace Sod.Web.Util
{
    /// <summary>
    /// Custom device detector
    /// </summary>
    public class CustomMobileDisplayMode : DefaultDisplayMode
    {
        /// <summary>
        /// mobile devices collection
        /// </summary>
        private static readonly List<string> MobileDevices = new List<string> { "Opera Mobi", "Mobile" };
        public CustomMobileDisplayMode() : base("Mobile")
        {
            ContextCondition = context => IsMobile(context.GetOverriddenUserAgent());
        }
        /// <summary>
        /// Checking current device useragent is mobile
        /// </summary>
        /// <param name="userAgent">UserAgent</param>
        /// <returns></returns>
        public static bool IsMobile(string userAgent)
        {
            return MobileDevices.Select(excluded => userAgent.IndexOf(excluded, StringComparison.InvariantCultureIgnoreCase)).Any(index => index >= 0);
        }
    }
}