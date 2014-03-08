using System.ComponentModel.DataAnnotations;

namespace CallCenter.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public string Username { get; set; }

        public int AveriaId { get; set; }

        public int Quantity { get; set; }

        public double? UnitPrecio { get; set; }

    }
}