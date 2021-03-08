using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Learn.Authorization.Roles;
using Learn.Authorization.Users;
using Learn.MultiTenancy;
using Learn.Data.Models;

namespace Learn.EntityFrameworkCore
{
    public class LearnDbContext : AbpZeroDbContext<Tenant, Role, User, LearnDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public LearnDbContext(DbContextOptions<LearnDbContext> options)
            : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }

    }
}
