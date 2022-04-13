namespace TestTaskApiPrototype.Models;

public enum JobType
{
    Main = 1, //TODO: is it right?
    Pluralistically = 2,
    Owner = 3,
    Participant = 3 //TODO: string representation????
}

public class Job
{
    public Guid Id { get; set; }

    public string? CompanyName { get; set; }

    public JobType Type { get; set; }

    public DateTime DateEmp { get; set; }

    public DateTime DateDismissal { get; set; }

    public string? Tin { get; set; } //Tax Inspection Number?

    public Address Address { get; set; } //TODO: nullable?

    public string? JobTitle { get; set; }

    public int MonIncome { get; set; }

    public string? FioManager { get; set; }

    public Uri Site { get; set; } //or common string is better?

    public ICollection<PhoneNumber> PhoneNumbers { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }


    public Client Client { get; set; }
}

public class PhoneNumber
{
    public int Id { get; set; } //TODO: разобраться с типом айдишника
    public string? Number;
}