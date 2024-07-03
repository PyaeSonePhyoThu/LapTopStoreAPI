using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LapTopStoreAPI.Models;

[Table("OrderDetail")]
public class OrderDetail
{
    [Key]
    public int OrderId { get; set; }
    public int Quantity { get; set; }
    public Customer? CustomerId { get; set; }
    public Product? ProductId { get; set; }
}
