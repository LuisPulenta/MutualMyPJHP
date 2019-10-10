using System.ComponentModel.DataAnnotations;

namespace MutualMyPJHPCommon.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Beneficiario { get; set; }
        [Required]
        public string DNI { get; set; }
        [Required]
        public string Password { get; set; }
    }
}