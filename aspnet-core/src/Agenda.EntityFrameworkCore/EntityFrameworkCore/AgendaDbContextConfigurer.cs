using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Agenda.EntityFrameworkCore
{
    public static class AgendaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AgendaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AgendaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
