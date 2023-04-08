using Microsoft.Extensions.Configuration;

namespace WEB_CTY
{
    public class AppGvar
    {
        public Data.Database _dbcontext { get; set; } =  new Data.Database();
        private static readonly IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddEnvironmentVariables().Build();


        #region sqlserver connection
        public static string sql_servername = config.GetValue<string>("sql_servername");
        public static string sql_databasename = config.GetValue<string>("sql_databasename");
        public static string sql_username = config.GetValue<string>("sql_username");
        public static string sql_passsword = config.GetValue<string>("sql_passsword");
        #endregion


        #region lấy thông tin doanh nghiệp




        #endregion

    }
}
