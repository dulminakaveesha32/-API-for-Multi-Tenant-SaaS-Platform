using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceAPI.Models
{
    public class TenantModel
    {
        [Key]
        public int TenantId { get;set; }
        public string Name { get;set; }
        public string Domain { get;set; }
        public string SubscriptionPlan { set; get; }
        public DateTime CreatedDate {  get;set; }
        public bool isActive { get;set ;}

        public ICollection<UserModel>Users { get;set; }
        public ICollection<ProductModel>Products { get;set; }
        public ICollection<OrderModel> Orders { get;set; }
    }
}