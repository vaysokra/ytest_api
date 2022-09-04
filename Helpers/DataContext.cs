namespace ytest_api.Helpers;

using Microsoft.EntityFrameworkCore;
using ytest_api.Entities;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }

    private readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // in memory database used for simplicity, change to a real db for production applications

        options.UseInMemoryDatabase("TestDb", b => b.EnableNullChecks(false));
    }
}