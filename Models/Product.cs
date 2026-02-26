using System.ComponentModel.DataAnnotations;

namespace DotNetAssignment.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative")]
    public double Price { get; set; } = 0;
}