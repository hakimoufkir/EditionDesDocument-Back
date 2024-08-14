using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;

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
            // Generate consistent Guids for seeding
            Guid documentId1 = Guid.Parse("7b241550-381a-4c2b-8148-112f7d808581");
            Guid documentId2 = Guid.Parse("94557cd1-2a66-4b5a-bd4c-4aacf9d67e34");
            Guid documentId3 = Guid.Parse("16ce2451-0dc2-4cb0-a325-857d53f6b371");
            Guid documentId4 = Guid.Parse("59ec09bd-7243-4da7-bfc4-9bd9a16782c1");
            Guid documentId5 = Guid.Parse("2415f49e-93a0-431b-9d03-f62eb9b56f4c");

            // Document entity configuration
            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.Id);

                // Seed data for Documents entity
                entity.HasData(
                    new Document
                    {
                        Id = documentId1,
                        PathFile = "https://smsproject.blob.core.windows.net/sms/106546be-7125-4b63-9b0a-2225e384c026.docx",
                        InstantJSON = "string",
                        FirstYear = null,
                        SecondYear = null,
                        Name = "Convention de stage",
                        CreatedDate = new DateTime(),
                        CreatedBy = null,
                        LastModifiedBy = null,
                        LastModifiedDate = new DateTime()
                    },
                    new Document
                    {
                        Id = documentId2,
                        PathFile = "https://smsproject.blob.core.windows.net/sms/b0177362-394b-4b78-b53e-a6666d8e3d69.docx",
                        InstantJSON = "string",
                        FirstYear = null,
                        SecondYear = null,
                        Name = "Demande de stage",
                        CreatedDate = new DateTime(),
                        CreatedBy = null,
                        LastModifiedBy = null,
                        LastModifiedDate = new DateTime()
                    },
                    new Document
                    {
                        Id = documentId3,
                        PathFile = "https://smsproject.blob.core.windows.net/sms/e0de30de-d492-4683-97dd-d4a8bf3bc511.docx",
                        InstantJSON = "string",
                        FirstYear = null,
                        SecondYear = null,
                        Name = "Attestation d'inscription",
                        CreatedDate = new DateTime(),
                        CreatedBy = null,
                        LastModifiedBy = null,
                        LastModifiedDate = new DateTime()
                    },
                    new Document
                    {
                        Id = documentId4,
                        PathFile = "https://smsproject.blob.core.windows.net/sms/1db826ac-886c-441c-b66b-7412f304219d.doc",
                        InstantJSON = "string",
                        FirstYear = null,
                        SecondYear = null,
                        Name = "Contrat",
                        CreatedDate =new DateTime(),
                        CreatedBy = null,
                        LastModifiedBy = null,
                        LastModifiedDate = new DateTime()
                    },
                    new Document
                    {
                        Id = documentId5,
                        PathFile = "https://smsproject.blob.core.windows.net/sms/79c6d185-c542-4609-a2fe-1942aa361e7f.docx",
                        InstantJSON = "string",
                        FirstYear = null,
                        SecondYear = null,
                        Name = "Attestation de scolarité",
                        CreatedDate = new DateTime(),
                        CreatedBy = null,
                        LastModifiedBy = null,
                        LastModifiedDate = new DateTime()
                    }
                );
            });

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
                        DocumentId = documentId2 // Reference the matching DocumentId
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
                        DocumentId = documentId1 // Reference the matching DocumentId
                    }
                );
            });

           
        }


 
    }
}
