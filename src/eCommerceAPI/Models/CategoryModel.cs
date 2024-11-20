using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceAPI.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get;set; }
        public string Name { get;set; }
        public string Description {get;set; }

        public ICollection<ProductModel> Products { get;set; }
    }
}