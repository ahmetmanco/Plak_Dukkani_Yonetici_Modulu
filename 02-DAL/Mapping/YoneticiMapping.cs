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
    public class YoneticiMapping : IEntityTypeConfiguration<Yonetici>
    {
        public void Configure(EntityTypeBuilder<Yonetici> builder)
        {
            builder.ToTable("Yönetici");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .HasColumnName("YöneticiId")
                   .HasColumnType("int")
                   .HasColumnOrder(1)
                   .IsRequired();

            builder.Property(x => x.YoneticiAdi)
                   .HasColumnName("YöneticiAdı")
                   .HasColumnType("nvarchar(30)")
                   .HasColumnOrder(2)
                   .IsRequired();

            builder.Property(x => x.YoneticiSoyadi)
                   .HasColumnName("YoneticiSoyadi")
                   .HasColumnType("nvarchar(30)")
                   .HasColumnOrder(3)
                   .IsRequired();

            builder.Property(x => x.EMail)
                   .HasColumnName("EMail")
                   .HasColumnType("nvarchar(50)")
                   .HasColumnOrder(5)
                   .IsRequired();

            builder.HasIndex(x => x.EMail)
                    .IsUnique();

            builder.Property(x => x.Sifre)
                   .HasColumnName("Şifre")
                   .HasColumnType("nvarchar(64)")
                   .HasColumnOrder(6)
                   .IsRequired();
        }
    }
}
