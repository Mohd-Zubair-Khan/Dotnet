using System.ComponentModel.DataAnnotations;

public class Product
{
    [Required]
    public int ProductID { get; set; }
    
    [Required]
    public string ProductName { get; set; }
    
    public string Description { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
    public int Quantity { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    public decimal UnitPrice { get; set; }

    [Required]
    public int ReOrderLevel { get; set; }
}
