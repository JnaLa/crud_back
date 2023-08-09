﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crud_back.Data;

#nullable disable

namespace crud_back.Migrations
{
    [DbContext(typeof(DiscDbContext))]
    [Migration("20230809111041_swap Type to Manufacturer")]
    partial class swapTypetoManufacturer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("crud_back.Models.Disc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fade")
                        .HasColumnType("int");

                    b.Property<int>("Glide")
                        .HasColumnType("int");

                    b.Property<bool>("IsInBag")
                        .HasColumnType("bit");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plastic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Turn")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Discs");
                });

            modelBuilder.Entity("crud_back.Models.PuttingPractise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("C1Long")
                        .HasColumnType("int");

                    b.Property<int>("C1Medium")
                        .HasColumnType("int");

                    b.Property<int>("C1Short")
                        .HasColumnType("int");

                    b.Property<int>("C2Long")
                        .HasColumnType("int");

                    b.Property<int>("C2Medium")
                        .HasColumnType("int");

                    b.Property<int>("C2Short")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Practises");
                });
#pragma warning restore 612, 618
        }
    }
}
