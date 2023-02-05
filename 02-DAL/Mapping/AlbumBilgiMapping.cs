using _01_Entity.Concrete;
using _01_Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DAL.Mapping
{
    public class AlbumBilgiMapping : IEntityTypeConfiguration<AlbumBilgi>
    {
        public void Configure(EntityTypeBuilder<AlbumBilgi> builder)
        {
            builder.ToTable("AlbümBilgileri");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .HasColumnName("AlbumId")
                   .HasColumnType("int")
                   .HasColumnOrder(1);

            builder.Property(x => x.AlbumAdi)
                   .HasColumnName("AlbümAdı")
                   .HasColumnType("nvarchar(max)")
                   .HasColumnOrder(2)
                   .IsRequired();

            builder.Property(x => x.SanatciveyaGrup)
                   .HasColumnName("SanatçıveyaGrup")
                   .HasColumnType("nvarchar(max)")
                   .HasColumnOrder(3)
                   .IsRequired();

            builder.Property(x => x.CikisTarihi)
                   .HasColumnName("ÇıkışTarihi")
                   .HasColumnType("datetime2")
                   .HasColumnOrder(4)
                   .IsRequired();

            builder.Property(x => x.Fiyat)
                   .HasColumnType("money")
                   .HasColumnOrder(5)
                   .IsRequired();

            builder.Property(x => x.IndirimOrani)
                   .HasColumnName("İndirimOranı")
                   .HasColumnType("float")
                   .HasColumnOrder(6)
                   .IsRequired();

            builder.Property(x => x.SatisiVarMi)
                   .HasColumnName("SatisiVarMi")
                   .HasColumnType("bit")
                   .HasColumnOrder(7)
                   .IsRequired();
        }
    }
}
