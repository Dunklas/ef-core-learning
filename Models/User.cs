namespace ef_core_learning.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Pet> Pets { get; set; }
}