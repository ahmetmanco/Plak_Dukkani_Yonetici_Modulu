// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _02_DAL.Context;

#nullable disable

namespace _02_DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_01_Entity.Concrete.AlbumBilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AlbumId")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AlbumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AlbümAdı")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("CikisTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("ÇıkışTarihi")
                        .HasColumnOrder(4);

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("money")
                        .HasColumnOrder(5);

                    b.Property<double>("IndirimOrani")
                        .HasColumnType("float")
                        .HasColumnName("İndirimOranı")
                        .HasColumnOrder(6);

                    b.Property<string>("SanatciveyaGrup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SanatçıveyaGrup")
                        .HasColumnOrder(3);

                    b.Property<bool>("SatisiVarMi")
                        .HasColumnType("bit")
                        .HasColumnName("SatisiVarMi")
                        .HasColumnOrder(7);

                    b.HasKey("Id");

                    b.ToTable("AlbümBilgileri", (string)null);
                });

            modelBuilder.Entity("_01_Entity.Concrete.Yonetici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("YöneticiId")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("EMail")
                        .HasColumnOrder(5);

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("Şifre")
                        .HasColumnOrder(6);

                    b.Property<string>("YoneticiAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("YöneticiAdı")
                        .HasColumnOrder(2);

                    b.Property<string>("YoneticiSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("YoneticiSoyadi")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("EMail")
                        .IsUnique();

                    b.ToTable("Yönetici", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
