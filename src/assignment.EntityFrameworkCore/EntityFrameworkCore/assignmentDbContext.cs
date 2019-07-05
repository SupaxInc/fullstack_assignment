using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using assignment.Authorization.Roles;
using assignment.Authorization.Users;
using assignment.MultiTenancy;

namespace assignment.EntityFrameworkCore
{
    public class assignmentDbContext : AbpZeroDbContext<Tenant, Role, User, assignmentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public assignmentDbContext(DbContextOptions<assignmentDbContext> options)
            : base(options)
        {
        }
    }
}
