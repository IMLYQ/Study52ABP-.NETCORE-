using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Study52ABP.Configuration;
using Study52ABP.Web;

namespace Study52ABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Study52ABPDbContextFactory : IDesignTimeDbContextFactory<Study52ABPDbContext>
    {
        public Study52ABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Study52ABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Study52ABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Study52ABPConsts.ConnectionStringName));

            return new Study52ABPDbContext(builder.Options);
        }
    }
}
