﻿// <auto-generated />
using AppDev.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppDev.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231123183032_AddCategoryToTable")]
    partial class AddCategoryToTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppDev.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "So scary",
                            DisplayOrder = 2,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Hello",
                            DisplayOrder = 3,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A lot of roman stories",
                            DisplayOrder = 1,
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 4,
                            Description = "So difficult",
                            DisplayOrder = 4,
                            Name = "Science"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}