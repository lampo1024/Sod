using System.Configuration;
using System.Data;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.MySql;

namespace Sod.Repositories
{
   public class DbConnectionFactory
    {
        protected static string ConnectionString { get; set; }

        static DbConnectionFactory()
        {
            OrmLiteConfig.DialectProvider = MySqlDialectProvider.Instance;
            ConnectionString = ConfigurationManager.ConnectionStrings["testDb"].ConnectionString;
        }
        public static IDbConnection GetDbConnection(string connString = null)
        {
            connString = connString ?? ConnectionString;
            return connString.OpenDbConnection();
        }
    }
}
