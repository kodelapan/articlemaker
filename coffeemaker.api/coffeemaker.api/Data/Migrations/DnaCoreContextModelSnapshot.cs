﻿// <auto-generated />
using dna.core.auth.Infrastructure;
using dna.core.data;
using dna.core.data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace coffeemaker.api.Data.Migrations
{
    [DbContext(typeof(DnaCoreContext))]
    partial class DnaCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-203");

            modelBuilder.Entity("dna.core.auth.Entity.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("dna.core.auth.Entity.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("dna.core.data.Entities.Advertising", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ButtonActionUrl");

                    b.Property<string>("ButtonName")
                        .HasMaxLength(100);

                    b.Property<string>("ButtonSecondaryAction");

                    b.Property<string>("ButtonSecondaryName")
                        .HasMaxLength(100);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<int?>("ImageId");

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.Property<int>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ImageId")
                        .IsUnique();

                    b.HasIndex("UpdatedById");

                    b.ToTable("Advertising");
                });

            modelBuilder.Entity("dna.core.data.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AcceptedById");

                    b.Property<DateTime?>("AcceptedDate");

                    b.Property<int>("CategoryId");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool?>("IsFeatured");

                    b.Property<string>("Metadata")
                        .HasMaxLength(255);

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(255);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("AcceptedById");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("dna.core.data.Entities.ArticleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsVisible");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ParentId");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ArticleCategory");
                });

            modelBuilder.Entity("dna.core.data.Entities.ArticleImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<int>("ImageId");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ImageId");

                    b.ToTable("ArticleImage");
                });

            modelBuilder.Entity("dna.core.data.Entities.ArticleTagMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("TagId");

                    b.ToTable("ArticleTag");
                });

            modelBuilder.Entity("dna.core.data.Entities.FirebaseUserMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceId");

                    b.Property<string>("DeviceToken");

                    b.Property<int>("OperatingSystem");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FirebaseUserMap");
                });

            modelBuilder.Entity("dna.core.data.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<bool>("IsPrimary");

                    b.Property<int>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("dna.core.data.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("dna.core.data.Entities.TreeMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayIcon")
                        .HasMaxLength(100);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Link")
                        .HasMaxLength(100);

                    b.Property<int>("Order");

                    b.Property<int>("ParentId");

                    b.Property<string>("Roles")
                        .HasMaxLength(100);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("TreeMenu");
                });

            modelBuilder.Entity("dna.core.data.Entities.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("dna.core.data.Entities.Advertising", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("dna.core.data.Entities.Image", "Image")
                        .WithOne()
                        .HasForeignKey("dna.core.data.Entities.Advertising", "ImageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("dna.core.data.Entities.Article", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "AcceptedByUser")
                        .WithMany()
                        .HasForeignKey("AcceptedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("dna.core.data.Entities.ArticleCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("dna.core.data.Entities.ArticleImage", b =>
                {
                    b.HasOne("dna.core.data.Entities.Article", "Article")
                        .WithMany("ImageMaps")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dna.core.data.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dna.core.data.Entities.ArticleTagMap", b =>
                {
                    b.HasOne("dna.core.data.Entities.Article", "Article")
                        .WithMany("TagMaps")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dna.core.data.Entities.Tag", "Tag")
                        .WithMany("TagMaps")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dna.core.data.Entities.FirebaseUserMap", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("dna.core.data.Entities.Image", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("dna.core.data.Entities.UserDetail", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("dna.core.auth.Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("dna.core.auth.Entity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
