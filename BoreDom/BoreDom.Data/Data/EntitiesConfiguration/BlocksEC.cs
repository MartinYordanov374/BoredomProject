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
    public class BlocksEC : IEntityTypeConfiguration<Blocks>
    {
        public void Configure(EntityTypeBuilder<Blocks> builder)
        {
            builder.HasKey(b => new { b.BlockerID, b.BlockedID });

            builder
                .HasOne(b => b.BlockerUser)
                .WithMany(u => u.Blocked)
                .HasForeignKey(b => b.BlockerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
