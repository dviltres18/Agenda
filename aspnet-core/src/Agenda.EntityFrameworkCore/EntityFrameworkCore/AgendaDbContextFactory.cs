using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Agenda.Configuration;
using Agenda.Web;

namespace Agenda.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AgendaDbContextFactory : IDesignTimeDbContextFactory<AgendaDbContext>
    {
        public AgendaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AgendaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AgendaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AgendaConsts.ConnectionStringName));

            return new AgendaDbContext(builder.Options);
        }
    }
}
