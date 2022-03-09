﻿// <auto-generated />
using System;
using Aguacongas.IdentityServer.EntityFramework.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Aguacongas.TheIdServer.PostgreSQL.Migrations.OperationalDb
{
    [DbContext(typeof(OperationalDbContext))]
    partial class OperationalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Aguacongas.IdentityServer.KeysRotation.EntityFrameworkCore.KeyRotationKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FriendlyName")
                        .HasColumnType("text");

                    b.Property<string>("Xml")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KeyRotationKeys");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.AuthorizationCode", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SessionId")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("AuthorizationCodes");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.BackChannelAuthenticationRequest", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("BackChannelAuthenticationRequests");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.DeviceCode", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.OneTimeToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SessionId")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("OneTimeTokens");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.ReferenceToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SessionId")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("ReferenceTokens");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.RefreshToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SessionId")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Aguacongas.IdentityServer.Store.Entity.UserConsent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SessionId")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("UserConstents");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FriendlyName")
                        .HasColumnType("text");

                    b.Property<string>("Xml")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });
#pragma warning restore 612, 618
        }
    }
}
