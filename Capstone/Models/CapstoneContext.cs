using Microsoft.EntityFrameworkCore;

namespace Capstone.Models
{
  public class CapstonePageContext : DbContext
  {
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ServiceEmployeeEntity> ServiceEmployeeEntities { get; set; }

    public CapstonePageContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServiceEmployeeEntity>()
            .HasKey(ps => new { ps.EmployeeId, ps.ServiceId });
            
        // modelBuilder.Entity<Service>()
        //     .HasOne(s => s.Client)
        //     .WithMany(c => c.Services)
        //     .HasForeignKey(s => s.ClientId);
    }
   }
}