using DPXQRPoc.Data.DataModels;
using DPXQRPoc.Data.DataModels.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DPXQRPoc.Data.DbContexts;

public class DPXPocDbContext : DbContext
{
    private readonly IConfiguration _config;
    
    public DPXPocDbContext(DbContextOptions options, IConfiguration config) : base(options)
    {
        _config = config;

    }
    
    public DbSet<IsoTimestampDataModel> IsoTimestamps { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(_config.GetConnectionString("DefaultConnection"), 
            ServerVersion.AutoDetect(_config.GetConnectionString("DefaultConnection")))
            .EnableSensitiveDataLogging(true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new IsoTimestampConfiguration());
    }
}
