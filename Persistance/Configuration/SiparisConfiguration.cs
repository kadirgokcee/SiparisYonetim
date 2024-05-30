using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configuration
{
    public sealed class SiparisConfiguration : IEntityTypeConfiguration<Siparis>
    {
        public void Configure(EntityTypeBuilder<Siparis> builder)
        {
            builder.ToTable(TableNames.Siparis);
            builder.HasKey(p => p.Id);

            builder
                .HasOne(p => p.Urun)
                .WithMany(p => p.Siparis)
                .HasForeignKey(p => p.UrunId);
        }
    }
}
