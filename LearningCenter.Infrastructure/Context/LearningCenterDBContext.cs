using LearningCenter.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infrastructure.Context;
public class LearningCenterDBContext : DbContext
{
    public LearningCenterDBContext()
    {
        
    }
    
    public LearningCenterDBContext(DbContextOptions<LearningCenterDBContext> options) : base(options)
    {
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tutorial> Tutorials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            optionsBuilder.UseMySql("Server=localhost,3306;Uid=root;Pwd=root;Database=learning-center-db", serverVersion);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().ToTable("Categories");
        modelBuilder.Entity<Category>().HasKey(category => category.Id);
        modelBuilder.Entity<Category>().Property(category => category.Id).IsRequired().ValueGeneratedOnAdd();
        modelBuilder.Entity<Category>().Property(category => category.Name).IsRequired().HasMaxLength(30);
        modelBuilder.Entity<Category>().HasMany(category => category.Tutorials)
                                       .WithOne(tutorial=> tutorial.Category)
                                       .HasForeignKey(tutorial => tutorial.CategoryId )
                                       .IsRequired();
        
        modelBuilder.Entity<Tutorial>().ToTable("Tutorials");
        modelBuilder.Entity<Tutorial>().HasKey(tutorial => tutorial.Id);
        modelBuilder.Entity<Tutorial>().Property(tutorial => tutorial.Id).IsRequired().ValueGeneratedOnAdd();
        modelBuilder.Entity<Tutorial>().Property(tutorial => tutorial.Name).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Tutorial>().Property(tutorial => tutorial.Description).IsRequired().HasMaxLength(100);
    }
    
    
}