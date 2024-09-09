using Core.Concrete;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    public class Product : IEntity
    {
        [Required]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string? ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}