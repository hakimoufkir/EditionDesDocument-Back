using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using static Domain.Enums.ResponsStutusHandler;

namespace Infrastructure.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Request> Requests { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid documentId1 = Guid.NewGuid();
            Guid documentId2 = Guid.NewGuid();
            Guid documentId3 = Guid.NewGuid();
            Guid documentId4 = Guid.NewGuid();
            Guid documentId5 = Guid.NewGuid();


            // Request entity configuration
            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IdTrainee).IsRequired();
                entity.Property(e => e.ModeleId).IsRequired();
                entity.Property(e => e.Role).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DocumentType).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DocumentStatus).IsRequired();

                // Define one-to-one relationship between Request and Document
                entity.HasOne(e => e.Document)
                      .WithMany(e => e.Requests)
                      .HasForeignKey(e => e.DocumentId)
                      .OnDelete(DeleteBehavior.Cascade);  // Cascade delete if a Request is deleted

                // Seed data for Requests entity
                entity.HasData(
                    new Request
                    {
                        Id = Guid.NewGuid(),
                        IdTrainee = Guid.NewGuid(),
                        ModeleId = Guid.NewGuid(),
                        Role = "assistant",
                        DocumentType = "Demande de stage",
                        ReasonRejection = "",
                        DocumentStatus = Domain.Enums.DocumentStatus.Accepte,
                        DocumentId = documentId1  // Use Guid.NewGuid() for seeding
                    },
                    new Request
                    {
                        Id = Guid.NewGuid(),
                        IdTrainee = Guid.NewGuid(),
                        ModeleId = Guid.NewGuid(),
                        Role = "director",
                        DocumentType = "Convention de stage",
                        ReasonRejection = "ya pas de justification",
                        DocumentStatus = Domain.Enums.DocumentStatus.Deny,
                        DocumentId = documentId2 // Use Guid.NewGuid() for seeding
                    }
                );
            });

            // Document entity configuration
            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.Id);

                // Seed data for Documents entity
                entity.HasData(
                    new Document
                    {
                        Id = documentId1, // This Id should match DocumentId in Request seeding
                        PathFile = "https://smsproject.blob.core.windows.net/sms/1db826ac-886c-441c-b66b-7412f304219d.doc",
                        InstantJSON = @"{
                            ""documentId"": ""SGS5RehxYUyGZIpdckC0Nw=="",
                            ""instantJSON"": {
                                ""annotations"": [
                                    {
                                        ""bbox"": [
                                            147.92001342773438,
                                            206.239990234375,
                                            306.55999755859375,
                                            32
                                        ],
                                        ""borderStyle"": ""solid"",
                                        ""borderWidth"": 1,
                                        ""createdAt"": ""2024-07-21T15:04:32Z"",
                                        ""creatorName"": ""{\""Document\"":\""Ttire\""}"",
                                        ""customData"": {
                                            ""User"": ""FirstName"",
                                            ""value"": """"
                                        },
                                        ""font"": ""Helvetica"",
                                        ""fontSize"": 12,
                                        ""formFieldName"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""horizontalAlign"": ""left"",
                                        ""id"": ""01J3AX5BW5V77M2C7YBJRN1WGS"",
                                        ""lineHeightFactor"": 1.186000108718872,
                                        ""name"": ""01J3AX5BW6J3YBJBZF3ABV0ZE4"",
                                        ""opacity"": 1,
                                        ""pageIndex"": 0,
                                        ""rotation"": 0,
                                        ""type"": ""pspdfkit/widget"",
                                        ""updatedAt"": ""2024-07-21T15:04:56Z"",
                                        ""v"": 2,
                                        ""verticalAlign"": ""center""
                                    }
                                ],
                                ""formFields"": [
                                    {
                                        ""annotationIds"": [
                                            ""01J3AX5BW5V77M2C7YBJRN1WGS""
                                        ],
                                        ""comb"": false,
                                        ""defaultValue"": """",
                                        ""doNotScroll"": false,
                                        ""doNotSpellCheck"": false,
                                        ""id"": ""01J3AX64W4SJSJA90NQRAMJCGC"",
                                        ""label"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""multiLine"": false,
                                        ""name"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""password"": false,
                                        ""pdfObjectId"": 94,
                                        ""richText"": false,
                                        ""type"": ""pspdfkit/form-field/text"",
                                        ""v"": 1
                                    }
                                ],
                                ""format"": ""https://pspdfkit.com/instant-json/v1"",
                                ""pdfId"": {
                                    ""changing"": ""QV5CW7SEzOfM3vnnwDZlRA=="",
                                    ""permanent"": ""SGS5RehxYUyGZIpdckC0Nw==""
                                }
                            }
                        }",
                        Name = "Contrat",
                        FirstYear = true,
                        SecondYear = false
                    },
                     new Document
                     {
                         Id = documentId2, // This Id should match DocumentId in Request seeding
                         PathFile = "https://smsproject.blob.core.windows.net/sms/b0177362-394b-4b78-b53e-a6666d8e3d69.docx",
                         InstantJSON = @"{
                            ""documentId"": ""SGS5RehxYUyGZIpdckC0Nw=="",
                            ""instantJSON"": {
                                ""annotations"": [
                                    {
                                        ""bbox"": [
                                            147.92001342773438,
                                            206.239990234375,
                                            306.55999755859375,
                                            32
                                        ],
                                        ""borderStyle"": ""solid"",
                                        ""borderWidth"": 1,
                                        ""createdAt"": ""2024-07-21T15:04:32Z"",
                                        ""creatorName"": ""{\""Document\"":\""Ttire\""}"",
                                        ""customData"": {
                                            ""User"": ""FirstName"",
                                            ""value"": """"
                                        },
                                        ""font"": ""Helvetica"",
                                        ""fontSize"": 12,
                                        ""formFieldName"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""horizontalAlign"": ""left"",
                                        ""id"": ""01J3AX5BW5V77M2C7YBJRN1WGS"",
                                        ""lineHeightFactor"": 1.186000108718872,
                                        ""name"": ""01J3AX5BW6J3YBJBZF3ABV0ZE4"",
                                        ""opacity"": 1,
                                        ""pageIndex"": 0,
                                        ""rotation"": 0,
                                        ""type"": ""pspdfkit/widget"",
                                        ""updatedAt"": ""2024-07-21T15:04:56Z"",
                                        ""v"": 2,
                                        ""verticalAlign"": ""center""
                                    }
                                ],
                                ""formFields"": [
                                    {
                                        ""annotationIds"": [
                                            ""01J3AX5BW5V77M2C7YBJRN1WGS""
                                        ],
                                        ""comb"": false,
                                        ""defaultValue"": """",
                                        ""doNotScroll"": false,
                                        ""doNotSpellCheck"": false,
                                        ""id"": ""01J3AX64W4SJSJA90NQRAMJCGC"",
                                        ""label"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""multiLine"": false,
                                        ""name"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""password"": false,
                                        ""pdfObjectId"": 94,
                                        ""richText"": false,
                                        ""type"": ""pspdfkit/form-field/text"",
                                        ""v"": 1
                                    }
                                ],
                                ""format"": ""https://pspdfkit.com/instant-json/v1"",
                                ""pdfId"": {
                                    ""changing"": ""QV5CW7SEzOfM3vnnwDZlRA=="",
                                    ""permanent"": ""SGS5RehxYUyGZIpdckC0Nw==""
                                }
                            }
                        }",
                         Name = "Demande de stage",
                         FirstYear = true,
                         SecondYear = false
                     },
                      new Document
                      {
                          Id = documentId3, // This Id should match DocumentId in Request seeding
                          PathFile = "https://smsproject.blob.core.windows.net/sms/106546be-7125-4b63-9b0a-2225e384c026.docx",
                          InstantJSON = @"{
                            ""documentId"": ""SGS5RehxYUyGZIpdckC0Nw=="",
                            ""instantJSON"": {
                                ""annotations"": [
                                    {
                                        ""bbox"": [
                                            147.92001342773438,
                                            206.239990234375,
                                            306.55999755859375,
                                            32
                                        ],
                                        ""borderStyle"": ""solid"",
                                        ""borderWidth"": 1,
                                        ""createdAt"": ""2024-07-21T15:04:32Z"",
                                        ""creatorName"": ""{\""Document\"":\""Ttire\""}"",
                                        ""customData"": {
                                            ""User"": ""FirstName"",
                                            ""value"": """"
                                        },
                                        ""font"": ""Helvetica"",
                                        ""fontSize"": 12,
                                        ""formFieldName"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""horizontalAlign"": ""left"",
                                        ""id"": ""01J3AX5BW5V77M2C7YBJRN1WGS"",
                                        ""lineHeightFactor"": 1.186000108718872,
                                        ""name"": ""01J3AX5BW6J3YBJBZF3ABV0ZE4"",
                                        ""opacity"": 1,
                                        ""pageIndex"": 0,
                                        ""rotation"": 0,
                                        ""type"": ""pspdfkit/widget"",
                                        ""updatedAt"": ""2024-07-21T15:04:56Z"",
                                        ""v"": 2,
                                        ""verticalAlign"": ""center""
                                    }
                                ],
                                ""formFields"": [
                                    {
                                        ""annotationIds"": [
                                            ""01J3AX5BW5V77M2C7YBJRN1WGS""
                                        ],
                                        ""comb"": false,
                                        ""defaultValue"": """",
                                        ""doNotScroll"": false,
                                        ""doNotSpellCheck"": false,
                                        ""id"": ""01J3AX64W4SJSJA90NQRAMJCGC"",
                                        ""label"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""multiLine"": false,
                                        ""name"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""password"": false,
                                        ""pdfObjectId"": 94,
                                        ""richText"": false,
                                        ""type"": ""pspdfkit/form-field/text"",
                                        ""v"": 1
                                    }
                                ],
                                ""format"": ""https://pspdfkit.com/instant-json/v1"",
                                ""pdfId"": {
                                    ""changing"": ""QV5CW7SEzOfM3vnnwDZlRA=="",
                                    ""permanent"": ""SGS5RehxYUyGZIpdckC0Nw==""
                                }
                            }
                        }",
                          Name = "Convention de stage",
                          FirstYear = true,
                          SecondYear = false
                      },
                       new Document
                       {
                           Id = documentId4, // This Id should match DocumentId in Request seeding
                           PathFile = "https://smsproject.blob.core.windows.net/sms/e0de30de-d492-4683-97dd-d4a8bf3bc511.docx",
                           InstantJSON = @"{
                            ""documentId"": ""SGS5RehxYUyGZIpdckC0Nw=="",
                            ""instantJSON"": {
                                ""annotations"": [
                                    {
                                        ""bbox"": [
                                            147.92001342773438,
                                            206.239990234375,
                                            306.55999755859375,
                                            32
                                        ],
                                        ""borderStyle"": ""solid"",
                                        ""borderWidth"": 1,
                                        ""createdAt"": ""2024-07-21T15:04:32Z"",
                                        ""creatorName"": ""{\""Document\"":\""Ttire\""}"",
                                        ""customData"": {
                                            ""User"": ""FirstName"",
                                            ""value"": """"
                                        },
                                        ""font"": ""Helvetica"",
                                        ""fontSize"": 12,
                                        ""formFieldName"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""horizontalAlign"": ""left"",
                                        ""id"": ""01J3AX5BW5V77M2C7YBJRN1WGS"",
                                        ""lineHeightFactor"": 1.186000108718872,
                                        ""name"": ""01J3AX5BW6J3YBJBZF3ABV0ZE4"",
                                        ""opacity"": 1,
                                        ""pageIndex"": 0,
                                        ""rotation"": 0,
                                        ""type"": ""pspdfkit/widget"",
                                        ""updatedAt"": ""2024-07-21T15:04:56Z"",
                                        ""v"": 2,
                                        ""verticalAlign"": ""center""
                                    }
                                ],
                                ""formFields"": [
                                    {
                                        ""annotationIds"": [
                                            ""01J3AX5BW5V77M2C7YBJRN1WGS""
                                        ],
                                        ""comb"": false,
                                        ""defaultValue"": """",
                                        ""doNotScroll"": false,
                                        ""doNotSpellCheck"": false,
                                        ""id"": ""01J3AX64W4SJSJA90NQRAMJCGC"",
                                        ""label"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""multiLine"": false,
                                        ""name"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""password"": false,
                                        ""pdfObjectId"": 94,
                                        ""richText"": false,
                                        ""type"": ""pspdfkit/form-field/text"",
                                        ""v"": 1
                                    }
                                ],
                                ""format"": ""https://pspdfkit.com/instant-json/v1"",
                                ""pdfId"": {
                                    ""changing"": ""QV5CW7SEzOfM3vnnwDZlRA=="",
                                    ""permanent"": ""SGS5RehxYUyGZIpdckC0Nw==""
                                }
                            }
                        }",
                           Name = "Attestation d'inscription",
                           FirstYear = true,
                           SecondYear = false
                       },
                        new Document
                        {
                            Id = documentId5, // This Id should match DocumentId in Request seeding
                            PathFile = "https://smsproject.blob.core.windows.net/sms/79c6d185-c542-4609-a2fe-1942aa361e7f.docx",
                            InstantJSON = @"{
                            ""documentId"": ""SGS5RehxYUyGZIpdckC0Nw=="",
                            ""instantJSON"": {
                                ""annotations"": [
                                    {
                                        ""bbox"": [
                                            147.92001342773438,
                                            206.239990234375,
                                            306.55999755859375,
                                            32
                                        ],
                                        ""borderStyle"": ""solid"",
                                        ""borderWidth"": 1,
                                        ""createdAt"": ""2024-07-21T15:04:32Z"",
                                        ""creatorName"": ""{\""Document\"":\""Ttire\""}"",
                                        ""customData"": {
                                            ""User"": ""FirstName"",
                                            ""value"": """"
                                        },
                                        ""font"": ""Helvetica"",
                                        ""fontSize"": 12,
                                        ""formFieldName"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""horizontalAlign"": ""left"",
                                        ""id"": ""01J3AX5BW5V77M2C7YBJRN1WGS"",
                                        ""lineHeightFactor"": 1.186000108718872,
                                        ""name"": ""01J3AX5BW6J3YBJBZF3ABV0ZE4"",
                                        ""opacity"": 1,
                                        ""pageIndex"": 0,
                                        ""rotation"": 0,
                                        ""type"": ""pspdfkit/widget"",
                                        ""updatedAt"": ""2024-07-21T15:04:56Z"",
                                        ""v"": 2,
                                        ""verticalAlign"": ""center""
                                    }
                                ],
                                ""formFields"": [
                                    {
                                        ""annotationIds"": [
                                            ""01J3AX5BW5V77M2C7YBJRN1WGS""
                                        ],
                                        ""comb"": false,
                                        ""defaultValue"": """",
                                        ""doNotScroll"": false,
                                        ""doNotSpellCheck"": false,
                                        ""id"": ""01J3AX64W4SJSJA90NQRAMJCGC"",
                                        ""label"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""multiLine"": false,
                                        ""name"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
                                        ""password"": false,
                                        ""pdfObjectId"": 94,
                                        ""richText"": false,
                                        ""type"": ""pspdfkit/form-field/text"",
                                        ""v"": 1
                                    }
                                ],
                                ""format"": ""https://pspdfkit.com/instant-json/v1"",
                                ""pdfId"": {
                                    ""changing"": ""QV5CW7SEzOfM3vnnwDZlRA=="",
                                    ""permanent"": ""SGS5RehxYUyGZIpdckC0Nw==""
                                }
                            }
                        }",
                            Name = "Attestation de scolarité",
                            FirstYear = true,
                            SecondYear = false
                        }
                );
            });
        }
    }
}
