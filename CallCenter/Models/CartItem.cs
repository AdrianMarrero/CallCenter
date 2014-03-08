using System.ComponentModel.DataAnnotations;

namespace CallCenter.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int AveriaId { get; set; }

        public virtual Averia Averia { get; set; }

    }
}