using ef_core_learning.Models;
using Microsoft.AspNetCore.Mvc;

namespace ef_core_learning.Controllers;

[ApiController]
[Route("[controller]")]
public class PetsController : ControllerBase
{
    private readonly PetioDbContext _dbContext;

    public PetsController(PetioDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public List<Pet> Get()
    {
        return _dbContext.Pets.ToList();
    }
}