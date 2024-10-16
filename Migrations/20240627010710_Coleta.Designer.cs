﻿// <auto-generated />
using System;
using APIRecicheck.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace APIRecicheck.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240627010710_Coleta")]
    partial class Coleta
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIAmbiental.Models.ColetaModel", b =>
                {
                    b.Property<int>("coletaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("coletaId"));

                    b.Property<DateTime>("dataColeta")
                        .HasColumnType("date");

                    b.Property<string>("quantidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)");

                    b.Property<string>("tipoResiduo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)");

                    b.HasKey("coletaId");

                    b.ToTable("COLETA", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
