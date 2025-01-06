﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreManager.Infrastructure.Data.Context;

#nullable disable

namespace StoreManager.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    [Migration("20250106131748_Add CategoryClient Table")]
    partial class AddCategoryClientTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("StoreManager.Models.CategoryClient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Consignação")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Credaiário")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereço")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Histórico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CategoryClient");
                });
#pragma warning restore 612, 618
        }
    }
}
