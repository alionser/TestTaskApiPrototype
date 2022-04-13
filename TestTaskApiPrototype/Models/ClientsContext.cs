using Microsoft.EntityFrameworkCore;

namespace TestTaskApiPrototype.Models;

public class ClientsContext :DbContext
{
    public ClientsContext(DbContextOptions<ClientsContext> options)
        :base(options)
    {
    }

    public DbSet<Client> Clients { get; set; } = null!; //TODO: ClientItems?
}