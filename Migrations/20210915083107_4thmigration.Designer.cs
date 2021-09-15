﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gotcha_web.database;

namespace gotcha_web.Migrations
{
    [DbContext(typeof(GotchaDBContext))]
    [Migration("20210915083107_4thmigration")]
    partial class _4thmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GamePlayer", b =>
                {
                    b.Property<int>("GamesGameId")
                        .HasColumnType("int");

                    b.Property<int>("PlayersId")
                        .HasColumnType("int");

                    b.HasKey("GamesGameId", "PlayersId");

                    b.HasIndex("PlayersId");

                    b.ToTable("GamePlayer");
                });

            modelBuilder.Entity("gotcha_web.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssassinId")
                        .HasColumnType("int");

                    b.Property<int?>("EliminationId")
                        .HasColumnType("int");

                    b.Property<int?>("TargetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssassinId");

                    b.HasIndex("EliminationId");

                    b.HasIndex("TargetId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("gotcha_web.Models.Elimination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EliminatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GameLeaderId")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameLeaderId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Eliminations");
                });

            modelBuilder.Entity("gotcha_web.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameLeaderId")
                        .HasColumnType("int");

                    b.Property<bool>("Public")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("GameLeaderId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("gotcha_web.Models.Gametype", b =>
                {
                    b.Property<int>("GameTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameTypeId");

                    b.ToTable("Gametypes");
                });

            modelBuilder.Entity("gotcha_web.Models.GametypeRequest", b =>
                {
                    b.Property<int>("GameTypeRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameLeaderId")
                        .HasColumnType("int");

                    b.HasKey("GameTypeRequestId");

                    b.HasIndex("GameLeaderId");

                    b.ToTable("GametypeRequests");
                });

            modelBuilder.Entity("gotcha_web.Models.Rule", b =>
                {
                    b.Property<int>("RuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.HasKey("RuleId");

                    b.HasIndex("GameId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("gotcha_web.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("gotcha_web.Models.GameLeader", b =>
                {
                    b.HasBaseType("gotcha_web.Models.User");

                    b.Property<int?>("PlayerAccountId")
                        .HasColumnType("int");

                    b.HasIndex("PlayerAccountId");

                    b.HasDiscriminator().HasValue("GameLeader");
                });

            modelBuilder.Entity("gotcha_web.Models.Player", b =>
                {
                    b.HasBaseType("gotcha_web.Models.User");

                    b.HasDiscriminator().HasValue("Player");
                });

            modelBuilder.Entity("gotcha_web.Models.Admin", b =>
                {
                    b.HasBaseType("gotcha_web.Models.GameLeader");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("GamePlayer", b =>
                {
                    b.HasOne("gotcha_web.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gotcha_web.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gotcha_web.Models.Contract", b =>
                {
                    b.HasOne("gotcha_web.Models.Player", "Assassin")
                        .WithMany()
                        .HasForeignKey("AssassinId");

                    b.HasOne("gotcha_web.Models.Elimination", "Elimination")
                        .WithMany()
                        .HasForeignKey("EliminationId");

                    b.HasOne("gotcha_web.Models.Player", "Target")
                        .WithMany()
                        .HasForeignKey("TargetId");

                    b.Navigation("Assassin");

                    b.Navigation("Elimination");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("gotcha_web.Models.Elimination", b =>
                {
                    b.HasOne("gotcha_web.Models.GameLeader", null)
                        .WithMany("Eliminations")
                        .HasForeignKey("GameLeaderId");

                    b.HasOne("gotcha_web.Models.Player", null)
                        .WithMany("Eliminations")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("gotcha_web.Models.Game", b =>
                {
                    b.HasOne("gotcha_web.Models.GameLeader", "GameLeader")
                        .WithMany()
                        .HasForeignKey("GameLeaderId");

                    b.Navigation("GameLeader");
                });

            modelBuilder.Entity("gotcha_web.Models.GametypeRequest", b =>
                {
                    b.HasOne("gotcha_web.Models.GameLeader", "GameLeader")
                        .WithMany()
                        .HasForeignKey("GameLeaderId");

                    b.Navigation("GameLeader");
                });

            modelBuilder.Entity("gotcha_web.Models.Rule", b =>
                {
                    b.HasOne("gotcha_web.Models.Game", null)
                        .WithMany("Rules")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("gotcha_web.Models.GameLeader", b =>
                {
                    b.HasOne("gotcha_web.Models.Player", "PlayerAccount")
                        .WithMany()
                        .HasForeignKey("PlayerAccountId");

                    b.Navigation("PlayerAccount");
                });

            modelBuilder.Entity("gotcha_web.Models.Game", b =>
                {
                    b.Navigation("Rules");
                });

            modelBuilder.Entity("gotcha_web.Models.GameLeader", b =>
                {
                    b.Navigation("Eliminations");
                });

            modelBuilder.Entity("gotcha_web.Models.Player", b =>
                {
                    b.Navigation("Eliminations");
                });
#pragma warning restore 612, 618
        }
    }
}
