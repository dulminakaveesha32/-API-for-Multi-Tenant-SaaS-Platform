using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eCommerceAPI.Models
{
    public class UserModel:IdentityUser
    {
        [Key]
        public int UserId { get;set; }
        [ForeignKey("Tenant")]
        public int TenantId { get;set; }
        public string Name { get;set; }
        public string Email { get;set; }
        public string PasswordHash { get;set; }
        public string Role { get;set; }

        public TenantModel Tenant { get;set; }
        public ICollection<OrderModel> Orders { get;set;}
        public ICollection<CartItemModel> CartItems{ get;set;}
    }
}