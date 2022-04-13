namespace TestTaskApiPrototype.Models;

public class Child
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Patronymic { get; set; }

    public DateTime Dob { get; set; } //TODO: BirthDate?


    public Client Client { get; set; }
}