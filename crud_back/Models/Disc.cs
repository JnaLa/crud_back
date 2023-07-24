using System.ComponentModel.DataAnnotations;

namespace crud_back.Models
{
    public class Disc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Plastic { get; set; }
        [Required]
        public int Speed { get; set; }
        [Required]
        public int Glide { get; set; }
        [Required]
        public int Turn { get; set; }
        [Required]
        public int Fade { get; set; }

        public bool IsInBag { get; set; } 
    }
}
