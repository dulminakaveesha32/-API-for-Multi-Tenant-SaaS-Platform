using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceAPI.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderId { get;set; }
        [ForeignKey("Tenant")]
        public int TenantId { get;set; }
        [ForeignKey("User")]
        public int UserId { get;set; }
        public DateTime OrderDate { get;set; }
        public decimal TotalAmount { get;set;}
        public string Status { get;set; }

    public TenantModel Tenant { get; set; }
    public UserModel User { get; set; }
    public ICollection<OrderItemModel> OrderItems { get; set; }
    }
}