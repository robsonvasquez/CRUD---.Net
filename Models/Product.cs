using System.ComponentModel.DataAnnotations;

namespace teste.Models
{
    class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }

        public virtual List<Buy>? Buys { get; set; }
    }
}
