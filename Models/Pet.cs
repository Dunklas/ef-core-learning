namespace ef_core_learning.Models;

public class Pet
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<User> Owners { get; set; }
}