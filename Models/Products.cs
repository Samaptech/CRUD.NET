using System.ComponentModel.DataAnnotations;

namespace CRUD.NET.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string product_name { get; set; }

        [Required]
        [StringLength(255)]
        public string product_description { get; set; }
        [Required]
        [StringLength(255)]
        
        public string product_price { get; set; }

       

    }
}
