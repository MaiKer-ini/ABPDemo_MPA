using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Demo.Authorization.Roles;
using Demo.Authorization.Users;
using Demo.MultiTenancy;
using Demo.PhoneBook.Person;
using Demo.PhoneBook.PhoneNumbers;

namespace Demo.EntityFrameworkCore
{
    public class DemoDbContext : AbpZeroDbContext<Tenant, Role, User, DemoDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }

        public DbSet<PersonEntity> Person { get; set; }

        public DbSet<PhoneNumbersEntity> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonEntity>().ToTable("Person", "dbo.Pb");
            modelBuilder.Entity<PhoneNumbersEntity>().ToTable("PhoneNumber", "dbo.Pb");
            base.OnModelCreating(modelBuilder);
        }
    }
}
