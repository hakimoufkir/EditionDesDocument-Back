﻿// <auto-generated />
using System;
using Infrastructure.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastracture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InstantJSON")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PathFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            Id = new Guid("adfc1cb2-132c-4416-a101-ee66c24efb69"),
                            CreatedDate = new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(6476),
                            InstantJSON = "{\r\n                            \"documentId\": \"SGS5RehxYUyGZIpdckC0Nw==\",\r\n                            \"instantJSON\": {\r\n                                \"annotations\": [\r\n                                    {\r\n                                        \"bbox\": [\r\n                                            147.92001342773438,\r\n                                            206.239990234375,\r\n                                            306.55999755859375,\r\n                                            32\r\n                                        ],\r\n                                        \"borderStyle\": \"solid\",\r\n                                        \"borderWidth\": 1,\r\n                                        \"createdAt\": \"2024-07-21T15:04:32Z\",\r\n                                        \"creatorName\": \"{\\\"Document\\\":\\\"Ttire\\\"}\",\r\n                                        \"customData\": {\r\n                                            \"User\": \"FirstName\",\r\n                                            \"value\": \"\"\r\n                                        },\r\n                                        \"font\": \"Helvetica\",\r\n                                        \"fontSize\": 12,\r\n                                        \"formFieldName\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"horizontalAlign\": \"left\",\r\n                                        \"id\": \"01J3AX5BW5V77M2C7YBJRN1WGS\",\r\n                                        \"lineHeightFactor\": 1.186000108718872,\r\n                                        \"name\": \"01J3AX5BW6J3YBJBZF3ABV0ZE4\",\r\n                                        \"opacity\": 1,\r\n                                        \"pageIndex\": 0,\r\n                                        \"rotation\": 0,\r\n                                        \"type\": \"pspdfkit/widget\",\r\n                                        \"updatedAt\": \"2024-07-21T15:04:56Z\",\r\n                                        \"v\": 2,\r\n                                        \"verticalAlign\": \"center\"\r\n                                    }\r\n                                ],\r\n                                \"formFields\": [\r\n                                    {\r\n                                        \"annotationIds\": [\r\n                                            \"01J3AX5BW5V77M2C7YBJRN1WGS\"\r\n                                        ],\r\n                                        \"comb\": false,\r\n                                        \"defaultValue\": \"\",\r\n                                        \"doNotScroll\": false,\r\n                                        \"doNotSpellCheck\": false,\r\n                                        \"id\": \"01J3AX64W4SJSJA90NQRAMJCGC\",\r\n                                        \"label\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"multiLine\": false,\r\n                                        \"name\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"password\": false,\r\n                                        \"pdfObjectId\": 94,\r\n                                        \"richText\": false,\r\n                                        \"type\": \"pspdfkit/form-field/text\",\r\n                                        \"v\": 1\r\n                                    }\r\n                                ],\r\n                                \"format\": \"https://pspdfkit.com/instant-json/v1\",\r\n                                \"pdfId\": {\r\n                                    \"changing\": \"QV5CW7SEzOfM3vnnwDZlRA==\",\r\n                                    \"permanent\": \"SGS5RehxYUyGZIpdckC0Nw==\"\r\n                                }\r\n                            }\r\n                        }",
                            LastModifiedDate = new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(6537),
                            PathFile = "https://blobstoragedbdemo.blob.core.windows.net/smsproject/00deed32-72c9-4322-b928-265ba7184a1d.pdf"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DocumentStatus")
                        .HasColumnType("int");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("IdTrainee")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModeleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameTrainee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonRejection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Requests");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8172caa9-53a0-49a7-903b-c2afca62ce0a"),
                            CreatedDate = new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(2375),
                            DocumentStatus = 1,
                            DocumentType = "Demande de stage",
                            IdTrainee = new Guid("f146f372-9ee7-4783-8208-28fa217d2c4c"),
                            LastModifiedDate = new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(2488),
                            ModeleId = new Guid("3c1e5657-6032-4dc8-a505-c07491b4bf12"),
                            ReasonRejection = "",
                            Role = "assistant"
                        },
                        new
                        {
                            Id = new Guid("57ce87b5-49cf-4e80-825c-98863cfbd484"),
                            CreatedDate = new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(2599),
                            DocumentStatus = 2,
                            DocumentType = "Convention de stage",
                            IdTrainee = new Guid("7a7e7477-2227-4259-892a-ea2f4b422558"),
                            LastModifiedDate = new DateTime(2024, 7, 22, 12, 15, 50, 568, DateTimeKind.Local).AddTicks(2610),
                            ModeleId = new Guid("16e25497-0402-4ed6-88c4-d016630dc843"),
                            ReasonRejection = "ya pas de justification",
                            Role = "director"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
