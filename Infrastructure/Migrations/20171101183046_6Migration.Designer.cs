﻿// <auto-generated />
using Core.Models;
using Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(WalletContext))]
    [Migration("20171101183046_6Migration")]
    partial class _6Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EventTime");

                    b.Property<decimal>("HowMuch");

                    b.Property<string>("Name");

                    b.Property<int>("OperationType");

                    b.Property<decimal>("WalletAfterEvent");

                    b.Property<decimal>("WalletBeforeEvent");

                    b.Property<Guid?>("WalletId");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Core.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Password");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Models.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Content");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Core.Models.Event", b =>
                {
                    b.HasOne("Core.Models.Wallet")
                        .WithMany("Events")
                        .HasForeignKey("WalletId");
                });

            modelBuilder.Entity("Core.Models.Wallet", b =>
                {
                    b.HasOne("Core.Models.User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
