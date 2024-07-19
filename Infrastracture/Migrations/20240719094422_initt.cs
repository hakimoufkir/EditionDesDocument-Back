using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class initt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTrainee = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameTrainee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentStatus = table.Column<int>(type: "int", nullable: false),
                    ReasonRejection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "ReasonRejection", "Role" },
                values: new object[,]
                {
                    { new Guid("1b7c7584-94c9-41ca-b490-72a7217061ae"), null, new DateTime(2024, 7, 19, 10, 44, 22, 46, DateTimeKind.Local).AddTicks(826), 2, "Convention de stage", new Guid("cbc6bc00-9744-40c3-9ca2-6f1ee87db953"), null, new DateTime(2024, 7, 19, 10, 44, 22, 46, DateTimeKind.Local).AddTicks(827), new Guid("bed75ebc-9a1b-4b1b-b53f-2816d88704dc"), null, "ya pas de justification", "director" },
                    { new Guid("4ddb60f8-a698-4414-9816-f07131ddfad3"), null, new DateTime(2024, 7, 19, 10, 44, 22, 46, DateTimeKind.Local).AddTicks(749), 1, "Demande de stage", new Guid("b209fe2b-793b-4353-ab6a-4b0b43ba4a98"), null, new DateTime(2024, 7, 19, 10, 44, 22, 46, DateTimeKind.Local).AddTicks(795), new Guid("ab8aef93-95c8-4220-91cb-394db1e73d00"), null, "", "assistant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
