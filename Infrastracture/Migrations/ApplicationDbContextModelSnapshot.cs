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
                            Id = new Guid("c0449e76-caf5-40f4-9780-04fb28a8539b"),
                            CreatedDate = new DateTime(2024, 7, 31, 15, 13, 4, 922, DateTimeKind.Local).AddTicks(4820),
                            InstantJSON = "{\r\n                            \"documentId\": \"SGS5RehxYUyGZIpdckC0Nw==\",\r\n                            \"instantJSON\": {\r\n                                \"annotations\": [\r\n                                    {\r\n                                        \"bbox\": [\r\n                                            147.92001342773438,\r\n                                            206.239990234375,\r\n                                            306.55999755859375,\r\n                                            32\r\n                                        ],\r\n                                        \"borderStyle\": \"solid\",\r\n                                        \"borderWidth\": 1,\r\n                                        \"createdAt\": \"2024-07-21T15:04:32Z\",\r\n                                        \"creatorName\": \"{\\\"Document\\\":\\\"Ttire\\\"}\",\r\n                                        \"customData\": {\r\n                                            \"User\": \"FirstName\",\r\n                                            \"value\": \"\"\r\n                                        },\r\n                                        \"font\": \"Helvetica\",\r\n                                        \"fontSize\": 12,\r\n                                        \"formFieldName\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"horizontalAlign\": \"left\",\r\n                                        \"id\": \"01J3AX5BW5V77M2C7YBJRN1WGS\",\r\n                                        \"lineHeightFactor\": 1.186000108718872,\r\n                                        \"name\": \"01J3AX5BW6J3YBJBZF3ABV0ZE4\",\r\n                                        \"opacity\": 1,\r\n                                        \"pageIndex\": 0,\r\n                                        \"rotation\": 0,\r\n                                        \"type\": \"pspdfkit/widget\",\r\n                                        \"updatedAt\": \"2024-07-21T15:04:56Z\",\r\n                                        \"v\": 2,\r\n                                        \"verticalAlign\": \"center\"\r\n                                    }\r\n                                ],\r\n                                \"formFields\": [\r\n                                    {\r\n                                        \"annotationIds\": [\r\n                                            \"01J3AX5BW5V77M2C7YBJRN1WGS\"\r\n                                        ],\r\n                                        \"comb\": false,\r\n                                        \"defaultValue\": \"\",\r\n                                        \"doNotScroll\": false,\r\n                                        \"doNotSpellCheck\": false,\r\n                                        \"id\": \"01J3AX64W4SJSJA90NQRAMJCGC\",\r\n                                        \"label\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"multiLine\": false,\r\n                                        \"name\": \"TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3\",\r\n                                        \"password\": false,\r\n                                        \"pdfObjectId\": 94,\r\n                                        \"richText\": false,\r\n                                        \"type\": \"pspdfkit/form-field/text\",\r\n                                        \"v\": 1\r\n                                    }\r\n                                ],\r\n                                \"format\": \"https://pspdfkit.com/instant-json/v1\",\r\n                                \"pdfId\": {\r\n                                    \"changing\": \"QV5CW7SEzOfM3vnnwDZlRA==\",\r\n                                    \"permanent\": \"SGS5RehxYUyGZIpdckC0Nw==\"\r\n                                }\r\n                            }\r\n                        }",
                            LastModifiedDate = new DateTime(2024, 7, 31, 15, 13, 4, 922, DateTimeKind.Local).AddTicks(4823),
                            PathFile = "https://blobstoragedbdemo.blob.core.windows.net/smsproject/00deed32-72c9-4322-b928-265ba7184a1d.pdf"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdFiliere")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdYear")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdYear");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdTrainee")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<int?>("TypePayment")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTrainee");

                    b.ToTable("Payments");
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
                            Id = new Guid("536b4df7-34e0-4997-bbe5-308e6c3ae242"),
                            CreatedDate = new DateTime(2024, 7, 31, 15, 13, 4, 922, DateTimeKind.Local).AddTicks(4572),
                            DocumentStatus = 1,
                            DocumentType = "Demande de stage",
                            IdTrainee = new Guid("80adbf0d-eed7-4269-bfdb-186109e68ece"),
                            LastModifiedDate = new DateTime(2024, 7, 31, 15, 13, 4, 922, DateTimeKind.Local).AddTicks(4611),
                            ModeleId = new Guid("10284f49-3079-4fa1-a79e-9cc0589dfdf1"),
                            ReasonRejection = "",
                            Role = "assistant"
                        },
                        new
                        {
                            Id = new Guid("3c42fcba-9890-4e4d-8c02-92fa1dcc7041"),
                            CreatedDate = new DateTime(2024, 7, 31, 15, 13, 4, 922, DateTimeKind.Local).AddTicks(4644),
                            DocumentStatus = 2,
                            DocumentType = "Convention de stage",
                            IdTrainee = new Guid("8612e042-9b21-439c-9d38-94fd00eba0ec"),
                            LastModifiedDate = new DateTime(2024, 7, 31, 15, 13, 4, 922, DateTimeKind.Local).AddTicks(4645),
                            ModeleId = new Guid("d39ac185-a36f-4327-81dc-01dc7b39994f"),
                            ReasonRejection = "ya pas de justification",
                            Role = "director"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Trainee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AnneeScolaire")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BacYear")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Baccalaureate")
                        .HasColumnType("bit");

                    b.Property<string>("BirthCertificates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Birthplace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiscoveryOriginOfTheSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherGSM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldJSON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("HighSchoolCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighSchoolCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighSchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdFiliere")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdGroup")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsWaitingList")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherGSM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfYearsOfStudy")
                        .HasColumnType("int");

                    b.Property<string>("ParentsAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Passerelle")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RegistrationStatus")
                        .HasColumnType("int");

                    b.Property<string>("ScholarCertificates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SchoolLevel")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StudiesCompleted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueIdentifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UniversityDegreeType")
                        .HasColumnType("int");

                    b.Property<string>("UniversityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdGroup");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("Domain.Entities.Year", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("current")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("Domain.Entities.Group", b =>
                {
                    b.HasOne("Domain.Entities.Year", "Year")
                        .WithMany()
                        .HasForeignKey("IdYear");

                    b.Navigation("Year");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.HasOne("Domain.Entities.Trainee", "Trainee")
                        .WithMany("Payments")
                        .HasForeignKey("IdTrainee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("Domain.Entities.Trainee", b =>
                {
                    b.HasOne("Domain.Entities.Group", "Group")
                        .WithMany("Trainees")
                        .HasForeignKey("IdGroup");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Domain.Entities.Group", b =>
                {
                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("Domain.Entities.Trainee", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
