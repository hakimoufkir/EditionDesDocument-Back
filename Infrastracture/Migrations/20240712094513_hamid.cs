using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class hamid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("78e69cf9-db54-48a8-b9ff-6a8443602d61"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("d4b16499-d2a2-444c-a7e1-a1e93119aad1"));

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Requests",
                newName: "Role");

            migrationBuilder.AddColumn<string>(
                name: "ReasonRejection",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "ReasonRejection", "Role" },
                values: new object[,]
                {
                    { new Guid("1e643459-c574-4e28-916d-0853ec908e4b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "document_trainee", new Guid("6aa18dff-edfb-4406-82cc-14f8038ad85c"), null, null, new Guid("38ba4b82-ef42-4fe2-91b0-1eb75c778ea5"), null, "", "assistant" },
                    { new Guid("ceff53cb-7ff3-4a76-a616-bce778ff011c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "document_traineeList", new Guid("69d87c56-cf7d-4d68-af3c-914caffc5e31"), null, null, new Guid("fb13e02f-c8aa-4de9-a7fc-a697a2a4a240"), null, "ya pas de justification", "director" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("1e643459-c574-4e28-916d-0853ec908e4b"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("ceff53cb-7ff3-4a76-a616-bce778ff011c"));

            migrationBuilder.DropColumn(
                name: "ReasonRejection",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Requests",
                newName: "role");

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "role" },
                values: new object[,]
                {
                    { new Guid("78e69cf9-db54-48a8-b9ff-6a8443602d61"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "document_trainee", new Guid("f8a82dd9-7100-4891-a786-fa995858f1f6"), null, null, new Guid("19202e5b-4a5d-4116-8801-5682f592e4d9"), null, "Admin" },
                    { new Guid("d4b16499-d2a2-444c-a7e1-a1e93119aad1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "document_traineeList", new Guid("fb9b44d5-12ab-4bd4-b654-a751622fa92f"), null, null, new Guid("06e718f8-57c6-4ffa-b111-aa583d4d9699"), null, "User" }
                });
        }
    }
}
