using Microsoft.EntityFrameworkCore;

namespace ef_core_learning.Models;

public class PetioDbContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }

    public PetioDbContext(DbContextOptions<PetioDbContext> options)
        : base(options)
    { }
}