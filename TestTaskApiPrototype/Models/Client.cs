namespace TestTaskApiPrototype.Models;

public enum StatusType
{
    Lead = 1,
    Potential,
    NonTarget,
    Consultation,
    Application,
    Deal,
    TransactionParticipant,
    Rejection
}

public enum EducationType
{
    Secondary = 1,
    SecondarySpecial,
    IncompleteHigher,
    Higher,
    TwoOrMoreHigher,
    AcademicDegree
}

public enum MaritalStatusType
{
    Single = 1,
    Married = 2,
    Widower = 3,
    Widow = 3,
    InDivorce = 4,
    CivilMarriage = 5
}

public enum EmpType
{
    Employee,
    IE,
    Owner,
    Coowner, //typo?
    Retiree,
    Unemployed
}

public class Client
{
    public Guid Id { get; set; }

    public string? Name;

    public string? Surname { get; set; }

    public string? Patronymic { get; set; }

    public DateTime Dob { get; set; }

    public Client Spouse { get; set; }

    public ICollection<Child> Children { get; set; } //TODO: use IEnumerable<Child>, or ICollection

    public DocumentPassport Passport { get; set; }

    public Address LivingAddress { get; set; }

    public Address RegAddress { get; set; }

    public ICollection<Job> Jobs { get; set; }

    public int GeneralExp { get; set; } //int?

    public int CurWorkExp { get; set; } //int?

    public int CurFieldExp { get; set; } //int?

    public StatusType Status { get; set; }

    public EducationType TypeEducation { get; set; }

    public MaritalStatusType MaritalStatus { get; set; }

    public EmpType TypeEmp { get; set; }

    public double MonIncome { get; set; }

    public double MonExpense { get; set; }

    public ICollection<File> Files { get; set; }

    public ICollection<Document> Documents { get; set; }

    public ICollection<ClientCommunications> Communications { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}

//ВЫНЕСТИ В ОТДЕЛЬНЫЕ ФАЙЛЫ!!
public class File
{
    public int Id { get; set; }
    public Guid FileGuid;
}

public class Document //TODO: РАЗОБРАТЬСЯ СО СХЕМОЙ НАИМЕНОВАНИЯ!!!!!
{
    public int Id { get; set; }
    public Guid DocumentGuid;
}