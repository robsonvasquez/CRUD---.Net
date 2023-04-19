using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste.Models
{
    class Buy
    {
        [Key]
        public int IdBuy { get; set; }

        public double Value { get; set; }

        [ForeignKey("Client")]
        public int IdClient { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Product")]
        public int IdProduct { get; set; }
        public Product Product { get; set; }
    }
}
