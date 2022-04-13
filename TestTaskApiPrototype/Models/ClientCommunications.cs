namespace TestTaskApiPrototype.Models;

public enum ClientCommunicationsType
{
    Email = 1,
    Phone = 2
}

public class ClientCommunications
{
    public int Id { get; set; }

    public ClientCommunicationsType Type { get; set; }

    public string? Value { get; set; }

    public Client Client { get; set; }
}