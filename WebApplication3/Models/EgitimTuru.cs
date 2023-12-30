using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class EgitimTuru
    {
        [Key]
        public int Id { get; set; }
        [Required]  // not null
        public string Ad { get; set; }
        
    }
}
