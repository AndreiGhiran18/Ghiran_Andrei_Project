﻿// <auto-generated />
using System;
using Ghiran_Andrei_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ghiran_Andrei_Project.Migrations
{
    [DbContext(typeof(Ghiran_Andrei_ProjectContext))]
    partial class Ghiran_Andrei_ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ghiran_Andrei_Project.Models.Developer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DeveloperName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Developer");
                });

            modelBuilder.Entity("Ghiran_Andrei_Project.Models.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("DeveloperID")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlatformID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DeveloperID");

                    b.HasIndex("PlatformID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Ghiran_Andrei_Project.Models.Platform", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("PlatformName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Platform");
                });

            modelBuilder.Entity("Ghiran_Andrei_Project.Models.Game", b =>
                {
                    b.HasOne("Ghiran_Andrei_Project.Models.Developer", "Developer")
                        .WithMany("Games")
                        .HasForeignKey("DeveloperID");

                    b.HasOne("Ghiran_Andrei_Project.Models.Platform", "Platform")
                        .WithMany("Games")
                        .HasForeignKey("PlatformID");

                    b.Navigation("Developer");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("Ghiran_Andrei_Project.Models.Developer", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("Ghiran_Andrei_Project.Models.Platform", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
