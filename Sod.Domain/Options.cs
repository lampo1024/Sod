using ServiceStack.DataAnnotations;

namespace Sod.Domain
{
    /// <summary>
    /// 系统选项配置表
    /// </summary>
    [Alias("ts_options")]
    public class Options
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 选项的键
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 选项的值
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 是否自动加载
        /// </summary>
        public bool AutoLoad { get; set; }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string Description { get; set; }
    }
}
