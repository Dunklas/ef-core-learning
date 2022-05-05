using Microsoft.EntityFrameworkCore;

namespace ef_core_learning.Models;

public class PetioDbContext: DbContext
{
    public DbSet<Pet> Pets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql(@"host=localhost:8002;database=petio;user id=super-user;password=super-secret;");
}