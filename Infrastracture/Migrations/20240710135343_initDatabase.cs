using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class initDatabase : Migration
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

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "role" },
                values: new object[,]
                {
                    { new Guid("0db17e3f-9a64-4fbf-b07d-af2b24b7d91e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "document_trainee", new Guid("2bf680c1-f6d7-422f-80cd-513f7bc2ddad"), null, null, new Guid("fa239f69-46f8-40d3-98d6-44197bb039c9"), "Admin" },
                    { new Guid("43441e81-62e4-44cf-acd1-6c7c042181ab"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "document_traineeList", new Guid("4d025293-7793-4fac-b5a3-17a466e18315"), null, null, new Guid("ae9e3455-18b0-40f3-8138-3bb635d9eea1"), "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("0db17e3f-9a64-4fbf-b07d-af2b24b7d91e"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("43441e81-62e4-44cf-acd1-6c7c042181ab"));

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
