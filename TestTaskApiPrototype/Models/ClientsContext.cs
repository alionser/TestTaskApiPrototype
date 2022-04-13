using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TestTaskApiPrototype.Models;

public class ClientsContext :DbContext
{
    public ClientsContext(DbContextOptions<ClientsContext> options)
        :base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        // //modelBuilder.Entity<List<Guid>>().HasNoKey();
        // var splitStringConverter = new ValueConverter<IEnumerable<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
        // modelBuilder.Entity<List<object>>().Property(nameof(Clients)).HasConversion(splitStringConverter);
    }

    public DbSet<Client> Clients { get; set; } = null!; //TODO: ClientItems?
}