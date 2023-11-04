﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class _005_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Humidities",
                keyColumn: "HumidityId",
                keyValue: new Guid("ccef2a9f-fe68-49c8-b949-12ef9943de6b"));

            migrationBuilder.DeleteData(
                table: "Temperatures",
                keyColumn: "TemperatureId",
                keyValue: new Guid("4270424e-1b48-4207-9c03-db4cfcb6a981"));

            migrationBuilder.InsertData(
                table: "Humidities",
                columns: new[] { "HumidityId", "HumidityTime", "HumidityValue" },
                values: new object[] { new Guid("93e34313-e86d-4158-be64-c82f5b10ff97"), new DateTime(2023, 10, 18, 21, 59, 43, 600, DateTimeKind.Local).AddTicks(8236), 93.25 });

            migrationBuilder.InsertData(
                table: "Temperatures",
                columns: new[] { "TemperatureId", "TemperatureTime", "TemperatureValue" },
                values: new object[] { new Guid("175c3ccc-ebf3-4d49-9fba-886f60f701a3"), new DateTime(2023, 10, 18, 21, 59, 43, 600, DateTimeKind.Local).AddTicks(8223), 26.550000000000001 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Humidities",
                keyColumn: "HumidityId",
                keyValue: new Guid("93e34313-e86d-4158-be64-c82f5b10ff97"));

            migrationBuilder.DeleteData(
                table: "Temperatures",
                keyColumn: "TemperatureId",
                keyValue: new Guid("175c3ccc-ebf3-4d49-9fba-886f60f701a3"));

            migrationBuilder.InsertData(
                table: "Humidities",
                columns: new[] { "HumidityId", "HumidityTime", "HumidityValue" },
                values: new object[] { new Guid("ccef2a9f-fe68-49c8-b949-12ef9943de6b"), new DateTime(2023, 9, 1, 8, 4, 5, 69, DateTimeKind.Local).AddTicks(8301), 93.25 });

            migrationBuilder.InsertData(
                table: "Temperatures",
                columns: new[] { "TemperatureId", "TemperatureTime", "TemperatureValue" },
                values: new object[] { new Guid("4270424e-1b48-4207-9c03-db4cfcb6a981"), new DateTime(2023, 9, 1, 8, 4, 5, 69, DateTimeKind.Local).AddTicks(8289), 26.550000000000001 });
        }
    }
}
