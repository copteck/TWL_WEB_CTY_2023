using _01.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using TWLS.AppGvars;
using System.Linq;
using Microsoft.Identity.Client;

namespace TWLS.Databases
{
    public class DB_Context : DbContext
    {

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //var connectionString = configuration.GetConnectionString("DefaultConnection");
            //optionsBuilder.UseSqlServer(connectionString);

            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = AppGvar.sql_servername,
                InitialCatalog = AppGvar.sql_databasename,
                UserID = AppGvar.sql_username,
                Password = AppGvar.sql_passsword,
                ConnectTimeout = 3000,
                MaxPoolSize = 32767,
                Pooling = true,
                //Tiến thêm vào .Net 7
                TrustServerCertificate = true,

            };

            optionsBuilder.UseSqlServer(sqlString.ConnectionString);



        }

     


        #region  dto table
        public DbSet<Data.dto_demo> ht_dm_chucnangs { get; set; }

        #endregion
    }
}
