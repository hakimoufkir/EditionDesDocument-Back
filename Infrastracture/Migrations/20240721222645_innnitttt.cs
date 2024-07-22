using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class innnitttt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: new Guid("d59a4cb8-d06c-4c1c-a84c-bd605da552d6"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("603ada26-8f5f-44fa-b20a-d0494a849b93"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("ae7701f6-a32b-42a0-b9fa-78faae7f9c96"));

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "InstantJSON", "LastModifiedBy", "LastModifiedDate", "PathFile" },
                values: new object[] { new Guid("dc0a7372-f46b-4847-9611-7075c52ef44a"), null, new DateTime(2024, 7, 21, 23, 26, 45, 90, DateTimeKind.Local).AddTicks(2670), "{\r\n                            \"documentId\": \"SGS5RehxYUyGZIpdckC0Nw==\",\r\n                            \"instantJSON\": {\r\n                                \"annotations\": [\r\n                                    {\r\n                                        \"bbox\": [\r\n                                            147.92001342773438,\r\n                                            206.239990234375,\r\n                                            306.55999755859375,\r\n                                            32\r\n                                        ],\r\n                                        \"borderStyle\": \"solid\",\r\n                                        \"borderWidth\": 1,\r\n                                        \"createdAt\": \"2024-07-21T15:04:32Z\",\r\n                                        \"creatorName\": \"{\\\"Document\\\":\\\"Ttire\\\"}\",\r\n                                        \"customData\": {\r\n                                            \"User\": \"FirstName\",\r\n                                            \"value\": \"\"\r\n                                        },\r\n                                        \"font\": \"Helvetica\",\r\n                                        \"fontSize\": 12,\r\n                                        \"formFieldName\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"horizontalAlign\": \"left\",\r\n                                        \"id\": \"01J3AX5BW5V77M2C7YBJRN1WGS\",\r\n                                        \"lineHeightFactor\": 1.186000108718872,\r\n                                        \"name\": \"01J3AX5BW6J3YBJBZF3ABV0ZE4\",\r\n                                        \"opacity\": 1,\r\n                                        \"pageIndex\": 0,\r\n                                        \"rotation\": 0,\r\n                                        \"type\": \"pspdfkit/widget\",\r\n                                        \"updatedAt\": \"2024-07-21T15:04:56Z\",\r\n                                        \"v\": 2,\r\n                                        \"verticalAlign\": \"center\"\r\n                                    }\r\n                                ],\r\n                                \"formFields\": [\r\n                                    {\r\n                                        \"annotationIds\": [\r\n                                            \"01J3AX5BW5V77M2C7YBJRN1WGS\"\r\n                                        ],\r\n                                        \"comb\": false,\r\n                                        \"defaultValue\": \"\",\r\n                                        \"doNotScroll\": false,\r\n                                        \"doNotSpellCheck\": false,\r\n                                        \"id\": \"01J3AX64W4SJSJA90NQRAMJCGC\",\r\n                                        \"label\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"multiLine\": false,\r\n                                        \"name\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"password\": false,\r\n                                        \"pdfObjectId\": 94,\r\n                                        \"richText\": false,\r\n                                        \"type\": \"pspdfkit/form-field/text\",\r\n                                        \"v\": 1\r\n                                    }\r\n                                ],\r\n                                \"format\": \"https://pspdfkit.com/instant-json/v1\",\r\n                                \"pdfId\": {\r\n                                    \"changing\": \"QV5CW7SEzOfM3vnnwDZlRA==\",\r\n                                    \"permanent\": \"SGS5RehxYUyGZIpdckC0Nw==\"\r\n                                }\r\n                            }\r\n                        }", null, new DateTime(2024, 7, 21, 23, 26, 45, 90, DateTimeKind.Local).AddTicks(2679), "https://blobstoragedbdemo.blob.core.windows.net/smsproject/00deed32-72c9-4322-b928-265ba7184a1d.pdf" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "ReasonRejection", "Role" },
                values: new object[,]
                {
                    { new Guid("47eca36e-8f47-491b-be5d-c3ce55e95d22"), null, new DateTime(2024, 7, 21, 23, 26, 45, 90, DateTimeKind.Local).AddTicks(2177), 2, "Convention de stage", new Guid("b94f01e8-6b75-4eed-9a6b-b234e2d8767f"), null, new DateTime(2024, 7, 21, 23, 26, 45, 90, DateTimeKind.Local).AddTicks(2180), new Guid("d6e4c173-baa4-495e-8149-0a058446d468"), null, "ya pas de justification", "director" },
                    { new Guid("b719cafa-0632-4ecf-8a00-963e9eac25ea"), null, new DateTime(2024, 7, 21, 23, 26, 45, 90, DateTimeKind.Local).AddTicks(2095), 1, "Demande de stage", new Guid("c29bed38-6a2d-40d7-9274-376c8ebb2188"), null, new DateTime(2024, 7, 21, 23, 26, 45, 90, DateTimeKind.Local).AddTicks(2149), new Guid("e13c737f-0fa9-485d-ad5b-ff771bde6fd5"), null, "", "assistant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: new Guid("dc0a7372-f46b-4847-9611-7075c52ef44a"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("47eca36e-8f47-491b-be5d-c3ce55e95d22"));

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: new Guid("b719cafa-0632-4ecf-8a00-963e9eac25ea"));

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "InstantJSON", "LastModifiedBy", "LastModifiedDate", "PathFile" },
                values: new object[] { new Guid("d59a4cb8-d06c-4c1c-a84c-bd605da552d6"), null, new DateTime(2024, 7, 21, 23, 19, 13, 333, DateTimeKind.Local).AddTicks(3724), "{\r\n  \"documentId\": \"SGS5RehxYUyGZIpdckC0Nw==\",\r\n  \"instantJSON\": \r\n  {\r\n    \"annotations\": [\r\n      {\r\n        \"bbox\": [\r\n          147.92001342773438,\r\n          206.239990234375,\r\n          306.55999755859375,\r\n          32\r\n        ],\r\n        \"borderStyle\": \"solid\",\r\n        \"borderWidth\": 1,\r\n        \"createdAt\": \"2024-07-21T15:04:32Z\",\r\n        \"creatorName\": \"{\\\"Document\\\":\\\"Ttire\\\"}\",\r\n        \"customData\": {\r\n          \"User\": \"FirstName\",\r\n          \"value\":\"\"\r\n        },\r\n        \"font\": \"Helvetica\",\r\n        \"fontSize\": 12,\r\n        \"formFieldName\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n        \"horizontalAlign\": \"left\",\r\n        \"id\": \"01J3AX5BW5V77M2C7YBJRN1WGS\",\r\n        \"lineHeightFactor\": 1.186000108718872,\r\n        \"name\": \"01J3AX5BW6J3YBJBZF3ABV0ZE4\",\r\n        \"opacity\": 1,\r\n        \"pageIndex\": 0,\r\n        \"rotation\": 0,\r\n        \"type\": \"pspdfkit/widget\",\r\n        \"updatedAt\": \"2024-07-21T15:04:56Z\",\r\n        \"v\": 2,\r\n        \"verticalAlign\": \"center\"\r\n      }\r\n    ],\r\n    \"formFields\": [\r\n      {\r\n        \"annotationIds\": [\r\n          \"01J3AX5BW5V77M2C7YBJRN1WGS\"\r\n        ],\r\n        \"comb\": false,\r\n        \"defaultValue\": \"\",\r\n        \"doNotScroll\": false,\r\n        \"doNotSpellCheck\": false,\r\n        \"id\": \"01J3AX64W4SJSJA90NQRAMJCGC\",\r\n        \"label\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n        \"multiLine\": false,\r\n        \"name\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n        \"password\": false,\r\n        \"pdfObjectId\": 94,\r\n        \"richText\": false,\r\n        \"type\": \"pspdfkit/form-field/text\",\r\n        \"v\": 1\r\n      }\r\n    ],\r\n    \"format\": \"https://pspdfkit.com/instant-json/v1\",\r\n    \"pdfId\": {\r\n      \"changing\": \"QV5CW7SEzOfM3vnnwDZlRA==\",\r\n      \"permanent\": \"SGS5RehxYUyGZIpdckC0Nw==\"\r\n    }\r\n  }\r\n}", null, new DateTime(2024, 7, 21, 23, 19, 13, 333, DateTimeKind.Local).AddTicks(3727), "https://blobstoragedbdemo.blob.core.windows.net/smsproject/00deed32-72c9-4322-b928-265ba7184a1d.pdf" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DocumentStatus", "DocumentType", "IdTrainee", "LastModifiedBy", "LastModifiedDate", "ModeleId", "NameTrainee", "ReasonRejection", "Role" },
                values: new object[,]
                {
                    { new Guid("603ada26-8f5f-44fa-b20a-d0494a849b93"), null, new DateTime(2024, 7, 21, 23, 19, 13, 333, DateTimeKind.Local).AddTicks(3390), 2, "Convention de stage", new Guid("dbe98382-b095-43af-8670-a9c9c4236701"), null, new DateTime(2024, 7, 21, 23, 19, 13, 333, DateTimeKind.Local).AddTicks(3391), new Guid("8df575bc-1008-4a38-9c47-a7bd642d4a08"), null, "ya pas de justification", "director" },
                    { new Guid("ae7701f6-a32b-42a0-b9fa-78faae7f9c96"), null, new DateTime(2024, 7, 21, 23, 19, 13, 333, DateTimeKind.Local).AddTicks(3322), 1, "Demande de stage", new Guid("f22fee4f-be8f-4d30-b4a3-86d6040e7087"), null, new DateTime(2024, 7, 21, 23, 19, 13, 333, DateTimeKind.Local).AddTicks(3369), new Guid("778cdda3-7605-4447-8c83-182fe23b54bf"), null, "", "assistant" }
                });
        }
    }
}
