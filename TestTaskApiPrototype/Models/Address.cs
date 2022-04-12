using System.ComponentModel.DataAnnotations;

namespace TestTaskApiPrototype.Models;

public class Address
{
    public Guid Id { get; set; }

    public string? ZipCode { get; set; }

    [Required]
    public string? Country { get; set; }

    [Required]
    public string? Region { get; set; }

    [Required]
    public string? City { get; set; }

    [Required]
    public string? Street { get; set; }

    [Required]
    public string? House { get; set; }

    public string? Block { get; set; }

    public string? Apartment { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}