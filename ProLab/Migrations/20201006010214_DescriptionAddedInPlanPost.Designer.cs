﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProLab.Data;

namespace ProLab.Migrations
{
    [DbContext(typeof(ProLabContext))]
    [Migration("20201006010214_DescriptionAddedInPlanPost")]
    partial class DescriptionAddedInPlanPost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.Aktivitet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AktivitetsBeskrivning")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aktivitet");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.Arena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArenaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArenaNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Arena");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClubName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClubNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.GameCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameCategory");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.GameStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameStatus");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.GameType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameType");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.HockeyGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArenaId")
                        .HasColumnType("int");

                    b.Property<int?>("AwayTeamScore")
                        .HasColumnType("int");

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<int?>("ClubId1")
                        .HasColumnType("int");

                    b.Property<int?>("GameCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GameDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("GameNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("GameTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("HomeTeamScore")
                        .HasColumnType("int");

                    b.Property<int?>("RefereeId")
                        .HasColumnType("int");

                    b.Property<int?>("RefereeId1")
                        .HasColumnType("int");

                    b.Property<int?>("RefereeId2")
                        .HasColumnType("int");

                    b.Property<int?>("RefereeId3")
                        .HasColumnType("int");

                    b.Property<int?>("SeriesId")
                        .HasColumnType("int");

                    b.Property<string>("TSMNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArenaId");

                    b.HasIndex("ClubId");

                    b.HasIndex("ClubId1");

                    b.HasIndex("GameCategoryId");

                    b.HasIndex("GameStatusId");

                    b.HasIndex("GameTypeId");

                    b.HasIndex("RefereeId");

                    b.HasIndex("RefereeId1");

                    b.HasIndex("RefereeId2");

                    b.HasIndex("RefereeId3");

                    b.HasIndex("SeriesId");

                    b.ToTable("HockeyGame");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.MDProtocol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyTemp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cough")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diarrhea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilySymtoms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Headache")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MuscleAches")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NasalCongestion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nausea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherSymptoms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherSymptomsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RefereeId")
                        .HasColumnType("int");

                    b.Property<string>("SoreThroat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RefereeId");

                    b.ToTable("MDProtocol");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.PlanPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AktivitetId")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AktivitetId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("PlanPost");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.RefFees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UDZ")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("RefFees");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.RefRecStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RefRecStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RefRecStatus");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.RefReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AllowanceHD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AllowanceHD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AllowanceLD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AllowanceLD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DescriptionOthersHD1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionOthersHD2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionOthersLD1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionOthersLD2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GameFeeHD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GameFeeHD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GameFeeLD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GameFeeLD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("HockeyGameId")
                        .HasColumnType("int");

                    b.Property<decimal>("KmHD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KmHD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KmLD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KmLD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LostErningsHD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LostErningsHD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LostErningsLD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LostErningsLD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtherHD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtherHD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtherLD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtherLD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RefRecStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCostHD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCostHD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCostHalfHockeyGame")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCostHockeyGame")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCostLD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCostLD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TravelExpensesHD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TravelExpensesHD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TravelExpensesLD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TravelExpensesLD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TravelSalarySupplementHD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TravelSalarySupplementHD2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TravelSalarySupplementLD1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TravelSalarySupplementLD2")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("HockeyGameId");

                    b.HasIndex("RefRecStatusId");

                    b.ToTable("RefReceipt");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrivateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SwishNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Referee");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SeriesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriesNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeriesPlayTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("ProLab.Models.DataModels.TSMHocekyGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AwayTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateChanged")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GameDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("GameNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameStatusId")
                        .HasColumnType("int");

                    b.Property<string>("HD1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HD2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Round")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Series")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supervisor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameStatusId");

                    b.ToTable("TSMHocekyGame");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProLab.Models.DataModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ProLab.Models.DataModels.HockeyGame", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.Arena", "Arena")
                        .WithMany()
                        .HasForeignKey("ArenaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.Club", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.Club", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("ClubId1")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.GameCategory", "GameCategory")
                        .WithMany()
                        .HasForeignKey("GameCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.GameStatus", "GameStatus")
                        .WithMany()
                        .HasForeignKey("GameStatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.GameType", "GameType")
                        .WithMany()
                        .HasForeignKey("GameTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.Referee", "HD1")
                        .WithMany()
                        .HasForeignKey("RefereeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.Referee", "HD2")
                        .WithMany()
                        .HasForeignKey("RefereeId1")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.Referee", "LD1")
                        .WithMany()
                        .HasForeignKey("RefereeId2")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.Referee", "LD2")
                        .WithMany()
                        .HasForeignKey("RefereeId3")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.Series", "Series")
                        .WithMany()
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProLab.Models.DataModels.MDProtocol", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.Referee", "Referee")
                        .WithMany()
                        .HasForeignKey("RefereeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProLab.Models.DataModels.PlanPost", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.Aktivitet", "Aktivitet")
                        .WithMany()
                        .HasForeignKey("AktivitetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProLab.Models.DataModels.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProLab.Models.DataModels.RefReceipt", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.HockeyGame", "HockeyGame")
                        .WithMany()
                        .HasForeignKey("HockeyGameId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProLab.Models.DataModels.RefRecStatus", "RefRecStatus")
                        .WithMany()
                        .HasForeignKey("RefRecStatusId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProLab.Models.DataModels.Referee", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProLab.Models.DataModels.TSMHocekyGame", b =>
                {
                    b.HasOne("ProLab.Models.DataModels.GameStatus", "GameStatus")
                        .WithMany()
                        .HasForeignKey("GameStatusId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}