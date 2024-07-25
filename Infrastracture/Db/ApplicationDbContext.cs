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



       


    }
}
