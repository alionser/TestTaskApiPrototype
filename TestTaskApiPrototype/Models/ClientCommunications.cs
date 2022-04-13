namespace TestTaskApiPrototype.Models;

public enum ClientCommunicationsType
{
    Email = 1,
    Phone = 2
}

public class ClientCommunications
{
    public ClientCommunicationsType Type { get; set; }

    public string? Value { get; set; }
}