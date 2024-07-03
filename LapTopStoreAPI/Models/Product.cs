using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LapTopStoreAPI.Models;

[Table("Product")]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}
