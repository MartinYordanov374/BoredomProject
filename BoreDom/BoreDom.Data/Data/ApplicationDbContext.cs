using BoreDom.Data.Data.EntitiesConfiguration;
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
            builder.ApplyConfiguration(new FollowerEC());
            builder.ApplyConfiguration(new BlocksEC());
            builder.ApplyConfiguration(new ChatEC());
            base.OnModelCreating(builder);
        }
        public DbSet<ProfilePicture> ProfilePictures { get; set; } = null!;
        public override DbSet<User> Users { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Like> Likes { get; set; } = null!;
        public DbSet<Follower> Followers { get; set; } = null!;
        public DbSet<Shares> Shares { get; set; } = null!;
        public DbSet<Blocks> Blocks { get; set; } = null!;
        public DbSet<Chats> Chats { get; set; } = null!;
    }
}