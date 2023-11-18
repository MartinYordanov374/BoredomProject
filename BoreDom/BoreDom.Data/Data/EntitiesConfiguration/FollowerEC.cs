using BoreDom.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoreDom.Data.Data.EntitiesConfiguration
{
    public class FollowerEC : IEntityTypeConfiguration<Follower>
    {
        public void Configure(EntityTypeBuilder<Follower> builder)
        {
            builder.HasKey(f => new { f.FollowerID, f.FollowedID });

            builder
                .HasOne(f => f.FollowerUser)
                .WithMany(u => u.Followers)
                .HasForeignKey(f => f.FollowerID)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(f => f.FollowedUser)
               .WithMany(u => u.Followed)
               .HasForeignKey(f => f.FollowedID)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
