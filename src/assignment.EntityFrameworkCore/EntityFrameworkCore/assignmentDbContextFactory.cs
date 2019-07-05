using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using assignment.Configuration;
using assignment.Web;

namespace assignment.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class assignmentDbContextFactory : IDesignTimeDbContextFactory<assignmentDbContext>
    {
        public assignmentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<assignmentDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            assignmentDbContextConfigurer.Configure(builder, configuration.GetConnectionString(assignmentConsts.ConnectionStringName));

            return new assignmentDbContext(builder.Options);
        }
    }
}
