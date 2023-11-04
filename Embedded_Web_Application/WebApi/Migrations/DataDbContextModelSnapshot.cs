﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Infrastructure_Layer.DbContext_Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataDbContext))]
    partial class DataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Core_Layer.Domain.Entity_Classes.HumiditySensor", b =>
                {
                    b.Property<Guid>("HumidityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("HumidityTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("HumidityValue")
                        .HasColumnType("float");

                    b.HasKey("HumidityId");

                    b.ToTable("Humidities", (string)null);

                    b.HasData(
                        new
                        {
                            HumidityId = new Guid("93e34313-e86d-4158-be64-c82f5b10ff97"),
                            HumidityTime = new DateTime(2023, 10, 18, 21, 59, 43, 600, DateTimeKind.Local).AddTicks(8236),
                            HumidityValue = 93.25
                        });
                });

            modelBuilder.Entity("WebApi.Core_Layer.Domain.Entity_Classes.TemperatureSensor", b =>
                {
                    b.Property<Guid>("TemperatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TemperatureTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("TemperatureValue")
                        .HasColumnType("float");

                    b.HasKey("TemperatureId");

                    b.ToTable("Temperatures", (string)null);

                    b.HasData(
                        new
                        {
                            TemperatureId = new Guid("175c3ccc-ebf3-4d49-9fba-886f60f701a3"),
                            TemperatureTime = new DateTime(2023, 10, 18, 21, 59, 43, 600, DateTimeKind.Local).AddTicks(8223),
                            TemperatureValue = 26.550000000000001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
