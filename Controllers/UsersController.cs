using ef_core_learning.Models;
using Microsoft.AspNetCore.Mvc;

namespace ef_core_learning.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly PetioDbContext _dbContext;

    public UsersController(PetioDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public List<User> Get()
    {
        return _dbContext.Users.ToList();
    }
}