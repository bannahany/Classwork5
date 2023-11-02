using System.ComponentModel.DataAnnotations;

namespace Classwork5.Models
{
    public class Item


    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Item Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int  Qty { get; set;}
    }
}
