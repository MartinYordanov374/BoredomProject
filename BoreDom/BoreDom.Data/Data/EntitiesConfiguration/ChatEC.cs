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
    public class ChatEC : IEntityTypeConfiguration<Chats>
    {
        public void Configure(EntityTypeBuilder<Chats> builder)
        {
           builder
                .HasOne(c=>c.SenderUser)
                .WithMany(u=>u.Chats)
                .HasForeignKey(c=>c.SenderID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
