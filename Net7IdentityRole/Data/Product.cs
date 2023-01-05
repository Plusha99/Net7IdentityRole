using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net7IdentityRole.Data
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
