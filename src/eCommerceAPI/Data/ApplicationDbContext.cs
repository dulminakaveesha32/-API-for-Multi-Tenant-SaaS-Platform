using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<CartItemModel> CartItems { get;set; }
        public DbSet<CategoryModel>Categories { get;set;}
        public DbSet<OrderItemModel> OrderItems { get;set;}
        public DbSet<OrderModel> Orders { get;set;}
        public DbSet<ProductModel>Products { get;set;}
        public DbSet<TenantModel>Tenants { get;set;}
        public DbSet<UserModel> Users { get; set;}
    }
}