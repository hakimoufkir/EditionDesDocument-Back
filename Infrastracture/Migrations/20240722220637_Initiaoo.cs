using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class Initiaoo : Migration
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
                    InstantJSON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                values: new object[] { new Guid("8a1b0cef-0740-436e-917e-4ad14637b608"), null, new DateTime(2024, 7, 22, 23, 6, 36, 879, DateTimeKind.Local).AddTicks(3538), "{\r\n                            \"documentId\": \"SGS5RehxYUyGZIpdckC0Nw==\",\r\n                            \"instantJSON\": {\r\n                                \"annotations\": [\r\n                                    {\r\n                                        \"bbox\": [\r\n                                            147.92001342773438,\r\n                                            206.239990234375,\r\n                                            306.55999755859375,\r\n                                            32\r\n                                        ],\r\n                                        \"borderStyle\": \"solid\",\r\n                                        \"borderWidth\": 1,\r\n                                        \"createdAt\": \"2024-07-21T15:04:32Z\",\r\n                                        \"creatorName\": \"{\\\"Document\\\":\\\"Ttire\\\"}\",\r\n                                        \"customData\": {\r\n                                            \"User\": \"FirstName\",\r\n                                            \"value\": \"\"\r\n                                        },\r\n                                        \"font\": \"Helvetica\",\r\n                                        \"fontSize\": 12,\r\n                                        \"formFieldName\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"horizontalAlign\": \"left\",\r\n                                        \"id\": \"01J3AX5BW5V77M2C7YBJRN1WGS\",\r\n                                        \"lineHeightFactor\": 1.186000108718872,\r\n                                        \"name\": \"01J3AX5BW6J3YBJBZF3ABV0ZE4\",\r\n                                        \"opacity\": 1,\r\n                                        \"pageIndex\": 0,\r\n                                        \"rotation\": 0,\r\n                                        \"type\": \"pspdfkit/widget\",\r\n                                        \"updatedAt\": \"2024-07-21T15:04:56Z\",\r\n                                        \"v\": 2,\r\n                                        \"verticalAlign\": \"center\"\r\n                                    }\r\n                                ],\r\n                                \"formFields\": [\r\n                                    {\r\n                                        \"annotationIds\": [\r\n                                            \"01J3AX5BW5V77M2C7YBJRN1WGS\"\r\n                                        ],\r\n                                        \"comb\": false,\r\n                                        \"defaultValue\": \"\",\r\n                                        \"doNotScroll\": false,\r\n                                        \"doNotSpellCheck\": false,\r\n                                        \"id\": \"01J3AX64W4SJSJA90NQRAMJCGC\",\r\n                                        \"label\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"multiLine\": false,\r\n                                        \"name\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"password\": false,\r\n                                        \"pdfObjectId\": 94,\r\n                                        \"richText\": false,\r\n                                        \"type\": \"pspdfkit/form-field/text\",\r\n                                        \"v\": 1\r\n                                    }\r\n                                ],\r\n                                \"format\": \"https://pspdfkit.com/instant-json/v1\",\r\n                                \"pdfId\": {\r\n                                    \"changing\": \"QV5CW7SEzOfM3vnnwDZlRA==\",\r\n                                    \"permanent\": \"SGS5RehxYUyGZIpdckC0Nw==\"\r\n                                }\r\n                            }\r\n                        }", null, new DateTime(2024, 7, 22, 23, 6, 36, 879, DateTimeKind.Local).AddTicks(3542), "https://blobstoragedbdemo.blob.core.windows.net/smsproject/00deed32-72c9-4322-b928-265ba7184a1d.pdf" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "ReasonRejection", "Role" },
                values: new object[,]
                {
                    { new Guid("13ec942c-1aac-4898-8df3-ed0e83acc915"), null, new DateTime(2024, 7, 22, 23, 6, 36, 879, DateTimeKind.Local).AddTicks(3141), 1, "Demande de stage", new Guid("45b1534c-a64e-4ff0-b062-b2ebb50d701d"), null, new DateTime(2024, 7, 22, 23, 6, 36, 879, DateTimeKind.Local).AddTicks(3212), new Guid("457f1d0d-b8f8-4aa3-9a4f-121fcfbad074"), null, "", "assistant" },
                    { new Guid("1adae146-c761-41e1-b161-5de3a367de81"), null, new DateTime(2024, 7, 22, 23, 6, 36, 879, DateTimeKind.Local).AddTicks(3258), 2, "Convention de stage", new Guid("bb3b6ad4-aeb7-4cb7-b3c1-5d1f8ac81d35"), null, new DateTime(2024, 7, 22, 23, 6, 36, 879, DateTimeKind.Local).AddTicks(3261), new Guid("fe5ae3a0-75a6-4dd6-9cf6-fb48bacecae2"), null, "ya pas de justification", "director" }
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
