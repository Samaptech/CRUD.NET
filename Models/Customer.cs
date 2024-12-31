using System.ComponentModel.DataAnnotations;

namespace CRUD.NET.Models
{
    public class Customer
    {
        [Key]
        public int Custumer_Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Custumer_Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Custumer_Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Custumer_Phone { get; set;}
        [Required]
        [StringLength(255)]
        public string Custumer_City { get;  set; }  

    }
}
