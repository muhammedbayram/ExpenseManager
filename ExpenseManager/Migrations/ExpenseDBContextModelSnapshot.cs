﻿// <auto-generated />
using System;
using ExpenseManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpenseManager.Migrations
{
    [DbContext(typeof(ExpenseDBContext))]
    partial class ExpenseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("ExpenseManager.Models.ExpenseReport", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<DateTime>("ExpenseDate");

                    b.Property<string>("ItemName")
                        .IsRequired();

                    b.HasKey("ItemId");

                    b.ToTable("ExpenseReport");
                });
#pragma warning restore 612, 618
        }
    }
}