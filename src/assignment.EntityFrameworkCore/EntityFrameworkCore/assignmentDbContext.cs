using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using assignment.Authorization.Roles;
using assignment.Authorization.Users;
using assignment.MultiTenancy;
using assignment.Contents;

namespace assignment.EntityFrameworkCore
{
    public class assignmentDbContext : AbpZeroDbContext<Tenant, Role, User, assignmentDbContext>
    {
        // Creates the Database set for the Content entity
        public DbSet<Content> Contents { get; set; }

        public assignmentDbContext(DbContextOptions<assignmentDbContext> options)
            : base(options)
        {
        }
    }
}
