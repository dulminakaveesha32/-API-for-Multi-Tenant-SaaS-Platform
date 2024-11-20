using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceAPI.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get;set; }
        [ForeignKey("Tenant")]
        public int TenantId { get;set; }
        public string Name { get;set; }
        public string Description { get;set; }
        public decimal Price { get;set; }
        public int StockQuantity { get;set; }
        public DateTime CreatedDate { get;set; }

        public TenantModel Tenant  {get;set; }
        public ICollection<OrderItemModel>OrderItems { get;set; }
        public ICollection<CategoryModel>Category { get;set; }


    }
}