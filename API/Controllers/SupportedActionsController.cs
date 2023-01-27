using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class SupportedActionsController : ControllerBase
{    
    [HttpGet]
    public async Task<IEnumerable<string>> Get()
    {
        return new[] { "1", "2", "3" };
    }
}