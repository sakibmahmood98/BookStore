// <auto-generated />
using BookStore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20220214114335_AddBookToDb")]
    partial class AddBookToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Authers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Price");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("publishYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Year");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
