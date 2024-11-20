using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eCommerceAPI.Models
{
    public class OrderItemModel
    {
    [Key]
    public int OrderItemId { get; set; }
    [ForeignKey("Order")]
    public int OrderId { get; set; }
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }


    public OrderModel Order { get; set; }
    public ProductModel Product { get; set; }
    }
}