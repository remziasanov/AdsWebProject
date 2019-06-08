using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AdsDataContext
{
    public class DataContext : IdentityDbContext<User, IdentityRole<Guid>, Guid, IdentityUserClaim<Guid>, IdentityUserRole<Guid>, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<CategoryItem> Categories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentLiker> CommentLikers { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "Users");
                entity.Ignore(user => user.TwoFactorEnabled);
                entity.Ignore(user => user.ConcurrencyStamp);
                entity.Ignore(user => user.LockoutEnabled);
                entity.Ignore(user => user.LockoutEnd);

            });

            builder.Entity<IdentityRole<Guid>>(entity =>
            {
                entity.ToTable(name: "AspNetRoles");
            });
        }




    }
}
