using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace E_Commerce.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Name")]
        public int Category_id { get; set; }
        public string Name { get; set; } 
        public IEnumerable<Product> Products { get; set; }

    }
}
