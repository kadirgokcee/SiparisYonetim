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
    public sealed class UrunConfiguration : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.ToTable(TableNames.Urun);
            builder.HasKey(p => p.Id);
            builder
                .HasOne(p => p.Firma)
                .WithMany(p => p.Urun)
                .HasForeignKey(p => p.FirmaId);
            builder.Property(p => p.Fiyat).HasColumnType("money");
            builder.Property(p => p.Stok).HasColumnType("decimal(18,2)");
        }
    }
}
