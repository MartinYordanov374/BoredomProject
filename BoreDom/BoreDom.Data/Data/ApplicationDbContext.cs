using BoreDom.Data.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace BoreDom.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Follower>().HasKey(f => new { f.FollowerID, f.FollowedID });

            builder.Entity<Follower>()
                .HasOne(f => f.FollowerUser)
                .WithMany(u => u.Followers)
                .HasForeignKey(f => f.FollowerID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Follower>()
               .HasOne(f => f.FollowedUser)
               .WithMany(u => u.Followed)
               .HasForeignKey(f => f.FollowedID)
               .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<ProfilePicture> ProfilePictures { get; set; } = null!;
        public override DbSet<User> Users { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Like> Likes { get; set; } = null!;
        public DbSet<Follower> Followers { get; set; } = null!;
    }
}