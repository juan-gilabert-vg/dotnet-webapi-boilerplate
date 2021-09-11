﻿// <auto-generated />
using System;
using DN.WebApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Migrators.MSSQL.Migrations.Root
{
    [DbContext(typeof(TenantManagementDbContext))]
    partial class TenantManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DN.WebApi.Domain.Entities.Multitenancy.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConnectionString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });
#pragma warning restore 612, 618
        }
    }
}
