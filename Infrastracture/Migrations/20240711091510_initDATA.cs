using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class initDATA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("4360ee73-de08-40c4-a5aa-984654eb3954"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("93f3219b-d007-4e75-b409-68d889456973"));

            migrationBuilder.AddColumn<string>(
                name: "NameTrainee",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "role" },
                values: new object[,]
                {
                    { new Guid("a17245a2-f2b8-4ad3-ba08-4263b02ace8f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "document_trainee", new Guid("2de2ac63-717d-45c4-b580-07bbc0f4f302"), null, null, new Guid("10fc07c7-a6dc-4c4b-ba02-f8feb4d614d1"), null, "Admin" },
                    { new Guid("efde2807-e4c4-4d2c-8ed0-05063fd888d0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "document_traineeList", new Guid("dcbb7758-9323-4feb-92e6-81f98f24e538"), null, null, new Guid("9649602c-db25-45e3-b9f2-5de750ea8f60"), null, "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("a17245a2-f2b8-4ad3-ba08-4263b02ace8f"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("efde2807-e4c4-4d2c-8ed0-05063fd888d0"));

            migrationBuilder.DropColumn(
                name: "NameTrainee",
                table: "Requests");

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "role" },
                values: new object[,]
                {
                    { new Guid("4360ee73-de08-40c4-a5aa-984654eb3954"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "document_trainee", new Guid("fd09d8fe-3fdb-49e4-832c-4a9c48f3ef89"), null, null, new Guid("c6f28bd5-637f-495c-aa9a-725f461760f3"), "Admin" },
                    { new Guid("93f3219b-d007-4e75-b409-68d889456973"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "document_traineeList", new Guid("2eb90f44-ede6-4b9a-bdbb-d88094b94d29"), null, null, new Guid("648e2e0e-a7c1-4620-b685-a19704b7c44e"), "User" }
                });
        }
    }
}
