using AgroSolutions.Property.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgroSolutions.Property.Api.Controllers;

[ApiController]
[Route("api/properties")]
[Authorize]
public class PropertyController : ControllerBase
{
    private static readonly List<Propertys> Properties = new();

    [HttpPost]
    public IActionResult CreateProperty([FromBody] Propertys property)
    {
        Properties.Add(property);
        return Ok(property);
    }

    [HttpPost("{propertyId}/talhoes")]
    public IActionResult AddTalhao(Guid propertyId, [FromBody] Talhao talhao)
    {
        var property = Properties.FirstOrDefault(p => p.Id == propertyId);
        if (property == null)
            return NotFound();

        property.Talhoes.Add(talhao);
        return Ok(talhao);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Properties);
    }
}
