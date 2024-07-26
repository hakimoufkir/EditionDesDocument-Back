﻿using System;
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

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "InstantJSON", "LastModifiedBy", "LastModifiedDate", "PathFile" },
                values: new object[] { new Guid("adfc1cb2-132c-4416-a101-ee66c24efb69"), null, new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(6476), "{\r\n                            \"documentId\": \"SGS5RehxYUyGZIpdckC0Nw==\",\r\n                            \"instantJSON\": {\r\n                                \"annotations\": [\r\n                                    {\r\n                                        \"bbox\": [\r\n                                            147.92001342773438,\r\n                                            206.239990234375,\r\n                                            306.55999755859375,\r\n                                            32\r\n                                        ],\r\n                                        \"borderStyle\": \"solid\",\r\n                                        \"borderWidth\": 1,\r\n                                        \"createdAt\": \"2024-07-21T15:04:32Z\",\r\n                                        \"creatorName\": \"{\\\"Document\\\":\\\"Ttire\\\"}\",\r\n                                        \"customData\": {\r\n                                            \"User\": \"FirstName\",\r\n                                            \"value\": \"\"\r\n                                        },\r\n                                        \"font\": \"Helvetica\",\r\n                                        \"fontSize\": 12,\r\n                                        \"formFieldName\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"horizontalAlign\": \"left\",\r\n                                        \"id\": \"01J3AX5BW5V77M2C7YBJRN1WGS\",\r\n                                        \"lineHeightFactor\": 1.186000108718872,\r\n                                        \"name\": \"01J3AX5BW6J3YBJBZF3ABV0ZE4\",\r\n                                        \"opacity\": 1,\r\n                                        \"pageIndex\": 0,\r\n                                        \"rotation\": 0,\r\n                                        \"type\": \"pspdfkit/widget\",\r\n                                        \"updatedAt\": \"2024-07-21T15:04:56Z\",\r\n                                        \"v\": 2,\r\n                                        \"verticalAlign\": \"center\"\r\n                                    }\r\n                                ],\r\n                                \"formFields\": [\r\n                                    {\r\n                                        \"annotationIds\": [\r\n                                            \"01J3AX5BW5V77M2C7YBJRN1WGS\"\r\n                                        ],\r\n                                        \"comb\": false,\r\n                                        \"defaultValue\": \"\",\r\n                                        \"doNotScroll\": false,\r\n                                        \"doNotSpellCheck\": false,\r\n                                        \"id\": \"01J3AX64W4SJSJA90NQRAMJCGC\",\r\n                                        \"label\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"multiLine\": false,\r\n                                        \"name\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"password\": false,\r\n                                        \"pdfObjectId\": 94,\r\n                                        \"richText\": false,\r\n                                        \"type\": \"pspdfkit/form-field/text\",\r\n                                        \"v\": 1\r\n                                    }\r\n                                ],\r\n                                \"format\": \"https://pspdfkit.com/instant-json/v1\",\r\n                                \"pdfId\": {\r\n                                    \"changing\": \"QV5CW7SEzOfM3vnnwDZlRA==\",\r\n                                    \"permanent\": \"SGS5RehxYUyGZIpdckC0Nw==\"\r\n                                }\r\n                            }\r\n                        }", null, new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(6537), "https://blobstoragedbdemo.blob.core.windows.net/smsproject/00deed32-72c9-4322-b928-265ba7184a1d.pdf" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "ReasonRejection", "Role" },
                values: new object[,]
                {
                    { new Guid("57ce87b5-49cf-4e80-825c-98863cfbd484"), null, new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(2599), 2, "Convention de stage", new Guid("7a7e7477-2227-4259-892a-ea2f4b422558"), null, new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(2610), new Guid("16e25497-0402-4ed6-88c4-d016630dc843"), null, "ya pas de justification", "director" },
                    { new Guid("8172caa9-53a0-49a7-903b-c2afca62ce0a"), null, new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(2375), 1, "Demande de stage", new Guid("f146f372-9ee7-4783-8208-28fa217d2c4c"), null, new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(2488), new Guid("3c1e5657-6032-4dc8-a505-c07491b4bf12"), null, "", "assistant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
