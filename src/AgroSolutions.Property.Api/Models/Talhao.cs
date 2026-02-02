namespace AgroSolutions.Property.Api.Models
{

    public class Talhao
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Cultura { get; set; } = string.Empty;
    }
}
