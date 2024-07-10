using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }



        public DbSet<Documents> DocumentsBase { get; set; }

        public DbSet<Requests>Requests { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Documents>()
                .HasDiscriminator<string>("document_type")
                .HasValue<DocumentsTrainee>("document_trainee")
                .HasValue<DocuementsTraineeList>("document_traineeList");

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IdTrainee).IsRequired();
                entity.Property(e => e.ModeleId).IsRequired();
                entity.Property(e => e.role).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DocumentType).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DocumentStatus).IsRequired();

                // Seed data for Requests entity
                entity.HasData(
                    new Requests
                    {
                        Id = Guid.NewGuid(),
                        IdTrainee = Guid.NewGuid(),
                        ModeleId = Guid.NewGuid(),
                        role = "Admin",
                        DocumentType = "document_trainee",
                        DocumentStatus = Domain.Enums.DocumentStatus.Accepte  // Assuming DocumentStatus is an enum
                    },
                    new Requests
                    {
                        Id = Guid.NewGuid(),
                        IdTrainee = Guid.NewGuid(),
                        ModeleId = Guid.NewGuid(),
                        role = "User",
                        DocumentType = "document_traineeList",
                        DocumentStatus = Domain.Enums.DocumentStatus.InProgress // Assuming DocumentStatus is an enum
                    }
                );
            });
        }


    }
}
