using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Commerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public decimal price { get; set; }
        [ForeignKey("Category")]
        [DisplayName("Category Name")]
        [DefaultValue(1)]
        public int Category_id { get; set; }

        public virtual Category? Category { get; set; }
    }
}
