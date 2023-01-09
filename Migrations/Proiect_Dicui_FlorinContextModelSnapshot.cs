﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Dicui_Florin.Data;

#nullable disable

namespace Proiect_Dicui_Florin.Migrations
{
    [DbContext(typeof(Proiect_Dicui_FlorinContext))]
    partial class Proiect_Dicui_FlorinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect_Dicui_Florin.Models.Network", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("NetworkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Network");
                });

            modelBuilder.Entity("Proiect_Dicui_Florin.Models.Shop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NetworkID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Sales")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("NetworkID");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("Proiect_Dicui_Florin.Models.Shop", b =>
                {
                    b.HasOne("Proiect_Dicui_Florin.Models.Network", "Network")
                        .WithMany("Shops")
                        .HasForeignKey("NetworkID");

                    b.Navigation("Network");
                });

            modelBuilder.Entity("Proiect_Dicui_Florin.Models.Network", b =>
                {
                    b.Navigation("Shops");
                });
#pragma warning restore 612, 618
        }
    }
}
