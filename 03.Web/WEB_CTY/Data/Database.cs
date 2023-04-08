using Dto_gioithieu;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
//using _01.DTO; 
namespace WEB_CTY.Data
{
    public   class Database :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Build an SQL connection string
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = AppGvar.sql_servername,
                InitialCatalog = AppGvar.sql_databasename,
                UserID = AppGvar.sql_username,
                Password = AppGvar.sql_passsword,
                ConnectTimeout = 300,
                MaxPoolSize = 32767,
                Pooling = true,
                //Tiến thêm vào .Net 7
                TrustServerCertificate = true,

            };

            optionsBuilder.UseSqlServer(sqlString.ConnectionString);

            //optionsBuilder.UseSqlServer(@"Server=" + AppGvar.sql_servername
            //+ "; database=" + AppGvar.sql_databasename
            //+ "; User ID=" + AppGvar.sql_username
            //+ "; Password=" + AppGvar.sql_passsword + ";TrustServerCertificate=True");
        }

        public DbSet<dto_gioithieu_ht_dm_chucnang> gioithieu_ht_dm_chucnangs { get; set; }

    }
}
