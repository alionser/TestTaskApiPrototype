namespace TestTaskApiPrototype.Models;

public class DocumentPassport
{
    //TODO: nullable ref type enabled, id it ok?
    //TODO: add description
    public Guid Id { get; set; }

    public string? Series { get; set; }

    public string? Number { get; set; }

    public string? Giver { get; set; }

    public DateTime DateIssued { get; set; }

    public string? BirthPlace { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}