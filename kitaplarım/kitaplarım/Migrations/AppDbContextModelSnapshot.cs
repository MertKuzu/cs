﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using db_template.DAL;

#nullable disable

namespace kitaplarım.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("db_template.Entities.Books", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AUTHOR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CATEGORYID")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesID")
                        .HasColumnType("int");

                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoriesID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("db_template.Entities.Categories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CATEGORY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("db_template.Entities.Books", b =>
                {
                    b.HasOne("db_template.Entities.Categories", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
