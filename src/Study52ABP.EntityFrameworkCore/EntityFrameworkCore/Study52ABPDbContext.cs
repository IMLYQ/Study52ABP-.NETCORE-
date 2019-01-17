using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Study52ABP.Authorization.Roles;
using Study52ABP.Authorization.Users;
using Study52ABP.MultiTenancy;

namespace Study52ABP.EntityFrameworkCore
{
    public class Study52ABPDbContext : AbpZeroDbContext<Tenant, Role, User, Study52ABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Study52ABPDbContext(DbContextOptions<Study52ABPDbContext> options)
            : base(options)
        {
        }
    }
}
