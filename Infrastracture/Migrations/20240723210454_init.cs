using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PathFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstantJSON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "InstantJSON", "LastModifiedBy", "LastModifiedDate", "PathFile" },
                values: new object[] { new Guid("00aec25c-5055-42f1-b49e-e312b468406b"), null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(3114), "{\r\n                            \"documentId\": \"SGS5RehxYUyGZIpdckC0Nw==\",\r\n                            \"instantJSON\": {\r\n                                \"annotations\": [\r\n                                    {\r\n                                        \"bbox\": [\r\n                                            147.92001342773438,\r\n                                            206.239990234375,\r\n                                            306.55999755859375,\r\n                                            32\r\n                                        ],\r\n                                        \"borderStyle\": \"solid\",\r\n                                        \"borderWidth\": 1,\r\n                                        \"createdAt\": \"2024-07-21T15:04:32Z\",\r\n                                        \"creatorName\": \"{\\\"Document\\\":\\\"Ttire\\\"}\",\r\n                                        \"customData\": {\r\n                                            \"User\": \"FirstName\",\r\n                                            \"value\": \"\"\r\n                                        },\r\n                                        \"font\": \"Helvetica\",\r\n                                        \"fontSize\": 12,\r\n                                        \"formFieldName\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"horizontalAlign\": \"left\",\r\n                                        \"id\": \"01J3AX5BW5V77M2C7YBJRN1WGS\",\r\n                                        \"lineHeightFactor\": 1.186000108718872,\r\n                                        \"name\": \"01J3AX5BW6J3YBJBZF3ABV0ZE4\",\r\n                                        \"opacity\": 1,\r\n                                        \"pageIndex\": 0,\r\n                                        \"rotation\": 0,\r\n                                        \"type\": \"pspdfkit/widget\",\r\n                                        \"updatedAt\": \"2024-07-21T15:04:56Z\",\r\n                                        \"v\": 2,\r\n                                        \"verticalAlign\": \"center\"\r\n                                    }\r\n                                ],\r\n                                \"formFields\": [\r\n                                    {\r\n                                        \"annotationIds\": [\r\n                                            \"01J3AX5BW5V77M2C7YBJRN1WGS\"\r\n                                        ],\r\n                                        \"comb\": false,\r\n                                        \"defaultValue\": \"\",\r\n                                        \"doNotScroll\": false,\r\n                                        \"doNotSpellCheck\": false,\r\n                                        \"id\": \"01J3AX64W4SJSJA90NQRAMJCGC\",\r\n                                        \"label\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"multiLine\": false,\r\n                                        \"name\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"password\": false,\r\n                                        \"pdfObjectId\": 94,\r\n                                        \"richText\": false,\r\n                                        \"type\": \"pspdfkit/form-field/text\",\r\n                                        \"v\": 1\r\n                                    }\r\n                                ],\r\n                                \"format\": \"https://pspdfkit.com/instant-json/v1\",\r\n                                \"pdfId\": {\r\n                                    \"changing\": \"QV5CW7SEzOfM3vnnwDZlRA==\",\r\n                                    \"permanent\": \"SGS5RehxYUyGZIpdckC0Nw==\"\r\n                                }\r\n                            }\r\n                        }", null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(3122), "https://blobstoragedbdemo.blob.core.windows.net/smsproject/00deed32-72c9-4322-b928-265ba7184a1d.pdf" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "ReasonRejection", "Role" },
                values: new object[,]
                {
                    { new Guid("024f7799-a482-465c-a07c-6ac4df97b53e"), null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(2435), 1, "Demande de stage", new Guid("7b34f089-35e7-44dc-916f-67d239b7f2ff"), null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(2475), new Guid("84138a39-4945-473f-ab26-f16ef65c98ce"), null, "", "assistant" },
                    { new Guid("0edd1c4c-bf8c-4587-a962-250e49f87fa8"), null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(2520), 2, "Convention de stage", new Guid("86652354-8cd3-4ca6-a992-9ea6582e067f"), null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(2521), new Guid("31aa833a-6346-4850-8365-a0db98e9785b"), null, "ya pas de justification", "director" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "FirstName", "LastModifiedBy", "LastModifiedDate", "LastName" },
                values: new object[,]
                {
                    { new Guid("0538ec10-a678-407b-ac05-550c334d57af"), null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(3465), "John", null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(3471), "Doe" },
                    { new Guid("e298149e-d90a-426b-8539-9ad9b10bda72"), null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(3479), "Jane", null, new DateTime(2024, 7, 23, 14, 4, 54, 144, DateTimeKind.Local).AddTicks(3480), "Smith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Trainees");
        }
    }
}
