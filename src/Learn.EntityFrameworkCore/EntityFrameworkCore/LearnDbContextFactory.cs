using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Learn.Configuration;
using Learn.Web;

namespace Learn.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LearnDbContextFactory : IDesignTimeDbContextFactory<LearnDbContext>
    {
        public LearnDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LearnDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LearnDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LearnConsts.ConnectionStringName));

            return new LearnDbContext(builder.Options);
        }
    }
}
