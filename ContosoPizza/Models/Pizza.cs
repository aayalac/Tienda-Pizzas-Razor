using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Pizza
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public bool IsGlutenFree { get; set; }
    [Range(0, double.MaxValue)]

    [Required]
    public int Price { get; set; }
}

public enum PizzaSize { Small, Medium, Large }