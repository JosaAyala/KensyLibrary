﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(KensyLibraryDbContext))]
    [Migration("20230401220933_ChangedUserToLector")]
    partial class ChangedUserToLector
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Data.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DisableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors", "data");
                });

            modelBuilder.Entity("Domain.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("Available")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DisableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditionYear")
                        .HasColumnType("int");

                    b.Property<int>("EditorialId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EnableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("InternationalStandardBookNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("EditorialId");

                    b.HasIndex("GenreId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Books", "data");
                });

            modelBuilder.Entity("Domain.Data.Editorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DisableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editorials", "data");
                });

            modelBuilder.Entity("Domain.Data.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DisableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres", "data");
                });

            modelBuilder.Entity("Domain.Data.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DisableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages", "data");
                });

            modelBuilder.Entity("Domain.Data.Lector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DisableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lectors", "data");
                });

            modelBuilder.Entity("Domain.Operation.BookRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateRequestClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRequestOpen")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DisableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LectorId")
                        .HasColumnType("int");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BookRequests", "operation");
                });

            modelBuilder.Entity("Domain.Operation.BookRequestDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("BookRequestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DisableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EnableDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnableUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("BookRequestId");

                    b.ToTable("BookRequestDetails", "operation");
                });

            modelBuilder.Entity("Domain.Data.Book", b =>
                {
                    b.HasOne("Domain.Data.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Data.Editorial", "Editorial")
                        .WithMany()
                        .HasForeignKey("EditorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Data.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Data.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Editorial");

                    b.Navigation("Genre");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Domain.Operation.BookRequest", b =>
                {
                    b.HasOne("Domain.Data.Book", null)
                        .WithMany("BookRequests")
                        .HasForeignKey("BookId");

                    b.HasOne("Domain.Data.Lector", "Lector")
                        .WithMany("BookRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lector");
                });

            modelBuilder.Entity("Domain.Operation.BookRequestDetail", b =>
                {
                    b.HasOne("Domain.Data.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Operation.BookRequest", "BookRequest")
                        .WithMany("BookRequestDetails")
                        .HasForeignKey("BookRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("BookRequest");
                });

            modelBuilder.Entity("Domain.Data.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Domain.Data.Book", b =>
                {
                    b.Navigation("BookRequests");
                });

            modelBuilder.Entity("Domain.Data.Lector", b =>
                {
                    b.Navigation("BookRequests");
                });

            modelBuilder.Entity("Domain.Operation.BookRequest", b =>
                {
                    b.Navigation("BookRequestDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
