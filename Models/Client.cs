using System.ComponentModel.DataAnnotations;

namespace teste.Models
{
    class Client
    {
        [Key]
        public int IdClient { get; set; }

        [Required, MaxLength(100)]
        public string firstName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string lastName { get; set; } = string.Empty;

        public virtual List<Buy>? Buys { get; set; }


    }
}
