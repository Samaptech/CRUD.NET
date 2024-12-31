using System.ComponentModel.DataAnnotations;

namespace CRUD.NET.Models
{
    public class Users
    {
        [Key]
        public int User_Id { get; set; }
        [Required]
        [StringLength(255)]
        public string User_name { get; set; }
        [Required]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string User_Email { get; set; }
        [Required]
        [StringLength(255)]
        [DataType(DataType.Password)]
        public string User_Password { get; set; }
        [Required]
        [StringLength(255)]
        public string User_Role { get; set; }    
    }
}
