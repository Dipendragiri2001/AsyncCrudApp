using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Learn.EntityFrameworkCore
{
    public static class LearnDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LearnDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LearnDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
