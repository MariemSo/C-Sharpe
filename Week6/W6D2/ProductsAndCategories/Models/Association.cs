#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations; //for validation 
namespace ProductsAndCategories.Models;
public class Association    	
{
    [Key]
    public int AssociationId { get; set; }

    public int CategoryId { get; set; } 
    public int ProductId { get; set; } 

    public Category? Category { get; set; }
    public Product? Product { get; set; }

}