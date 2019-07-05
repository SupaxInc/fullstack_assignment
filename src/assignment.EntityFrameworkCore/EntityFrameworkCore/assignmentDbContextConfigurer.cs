using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace assignment.EntityFrameworkCore
{
    public static class assignmentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<assignmentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<assignmentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
