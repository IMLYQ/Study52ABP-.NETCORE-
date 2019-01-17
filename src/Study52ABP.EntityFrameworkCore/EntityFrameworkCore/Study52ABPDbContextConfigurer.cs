using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Study52ABP.EntityFrameworkCore
{
    public static class Study52ABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Study52ABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Study52ABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
