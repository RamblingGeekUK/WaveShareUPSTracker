﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WaveShareUPS.Migrations
{
    [DbContext(typeof(WSDb))]
    [Migration("20240106230951_datatimefix]")]
    partial class datatimefix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Reading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Current")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<float>("LoadVoltage")
                        .HasColumnType("REAL");

                    b.Property<float>("PercentRemaining")
                        .HasColumnType("REAL");

                    b.Property<float>("Power")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("readings");
                });
#pragma warning restore 612, 618
        }
    }
}
