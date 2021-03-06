// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220127011941_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Sci-Fi",
                            Director = "Denis Villaneuve",
                            Edited = false,
                            LentTo = "",
                            Notes = "Does the book justice",
                            Rating = "PG-13",
                            Title = "Dune",
                            Year = (ushort)2021
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Sports",
                            Director = "Bennett Miller",
                            Edited = false,
                            LentTo = "",
                            Notes = "Jonah Hill's best work",
                            Rating = "PG-13",
                            Title = "Moneyball",
                            Year = (ushort)2011
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Comedy",
                            Director = "Adam McKay",
                            Edited = false,
                            LentTo = "",
                            Notes = "Funny movie",
                            Rating = "PG-13",
                            Title = "The Other Guys",
                            Year = (ushort)2010
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
