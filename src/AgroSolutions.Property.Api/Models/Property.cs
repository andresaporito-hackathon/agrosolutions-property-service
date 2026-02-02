namespace AgroSolutions.Property.Api.Models;

public class Propertys
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public List<Talhao> Talhoes { get; set; } = new();
}

