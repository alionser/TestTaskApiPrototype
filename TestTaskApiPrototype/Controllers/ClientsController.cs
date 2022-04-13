using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestTaskApiPrototype.Models;

namespace TestTaskApiPrototype.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController : ControllerBase
{
    private readonly ClientsContext _context;

    public ClientsController(ClientsContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>>> GetClients()
    {
        return await _context.Clients.ToListAsync();
    }

    [HttpPut]
    public async Task<IActionResult> PutClient()
    {

        Client client = new Client();

        _context.Clients.Add(client);
        await _context.SaveChangesAsync();

        return Accepted();
    }

}