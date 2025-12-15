using System.ComponentModel.DataAnnotations;

namespace demoWeb.Models;

public class Category
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Fill category name")]
    public string Name { get; set; } = String.Empty;
}