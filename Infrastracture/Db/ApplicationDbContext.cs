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






        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{


        //    modelBuilder.Entity<Request>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.IdTrainee).IsRequired();
        //        entity.Property(e => e.ModeleId).IsRequired();
        //        entity.Property(e => e.Role).IsRequired().HasMaxLength(50);
        //        entity.Property(e => e.DocumentType).IsRequired().HasMaxLength(50);
        //        entity.Property(e => e.DocumentStatus).IsRequired();

        //        // Seed data for Requests entity
        //        entity.HasData(
        //            new Request
        //            {
        //                Id = Guid.NewGuid(),
        //                IdTrainee = Guid.NewGuid(),
        //                ModeleId = Guid.NewGuid(),
        //                Role = "assistant",
        //                DocumentType = "Demande de stage",
        //                ReasonRejection = "",
        //                DocumentStatus = Domain.Enums.DocumentStatus.Accepte  // Assuming DocumentStatus is an enum
        //            },
        //            new Request
        //            {
        //                Id = Guid.NewGuid(),
        //                IdTrainee = Guid.NewGuid(),
        //                ModeleId = Guid.NewGuid(),
        //                Role = "director",
        //                DocumentType = "Convention de stage",
        //                ReasonRejection = "ya pas de justification",
        //                DocumentStatus = Domain.Enums.DocumentStatus.Deny // Assuming DocumentStatus is an enum
        //            }
        //        );
        //    });

        //    modelBuilder.Entity<Document>(entity =>
        //    {
        //        entity.HasData(                
        //            new Document
        //            {
        //                Id = Guid.NewGuid(),
        //                PathFile = "https://smsproject.blob.core.windows.net/sms/fa0110fe-58b9-46c0-9835-59580685fb9f.pdf",
        //                InstantJSON = @"{
        //                    ""documentId"": ""SGS5RehxYUyGZIpdckC0Nw=="",
        //                    ""instantJSON"": {
        //                        ""annotations"": [
        //                            {
        //                                ""bbox"": [
        //                                    147.92001342773438,
        //                                    206.239990234375,
        //                                    306.55999755859375,
        //                                    32
        //                                ],
        //                                ""borderStyle"": ""solid"",
        //                                ""borderWidth"": 1,
        //                                ""createdAt"": ""2024-07-21T15:04:32Z"",
        //                                ""creatorName"": ""{\""Document\"":\""Ttire\""}"",
        //                                ""customData"": {
        //                                    ""User"": ""FirstName"",
        //                                    ""value"": """"
        //                                },
        //                                ""font"": ""Helvetica"",
        //                                ""fontSize"": 12,
        //                                ""formFieldName"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
        //                                ""horizontalAlign"": ""left"",
        //                                ""id"": ""01J3AX5BW5V77M2C7YBJRN1WGS"",
        //                                ""lineHeightFactor"": 1.186000108718872,
        //                                ""name"": ""01J3AX5BW6J3YBJBZF3ABV0ZE4"",
        //                                ""opacity"": 1,
        //                                ""pageIndex"": 0,
        //                                ""rotation"": 0,
        //                                ""type"": ""pspdfkit/widget"",
        //                                ""updatedAt"": ""2024-07-21T15:04:56Z"",
        //                                ""v"": 2,
        //                                ""verticalAlign"": ""center""
        //                            }
        //                        ],
        //                        ""formFields"": [
        //                            {
        //                                ""annotationIds"": [
        //                                    ""01J3AX5BW5V77M2C7YBJRN1WGS""
        //                                ],
        //                                ""comb"": false,
        //                                ""defaultValue"": """",
        //                                ""doNotScroll"": false,
        //                                ""doNotSpellCheck"": false,
        //                                ""id"": ""01J3AX64W4SJSJA90NQRAMJCGC"",
        //                                ""label"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
        //                                ""multiLine"": false,
        //                                ""name"": ""TEXT_WIDGET_01J3AX5BW5Q4S6YGEEERR87PJ3"",
        //                                ""password"": false,
        //                                ""pdfObjectId"": 94,
        //                                ""richText"": false,
        //                                ""type"": ""pspdfkit/form-field/text"",
        //                                ""v"": 1
        //                            }
        //                        ],
        //                        ""format"": ""https://pspdfkit.com/instant-json/v1"",
        //                        ""pdfId"": {
        //                            ""changing"": ""QV5CW7SEzOfM3vnnwDZlRA=="",
        //                            ""permanent"": ""SGS5RehxYUyGZIpdckC0Nw==""
        //                        }
        //                    }
        //                }",
        //                FirstYear= true,
        //                SecondYear=false
        //            }
        //        );
        //    });

        //}


    }
}
