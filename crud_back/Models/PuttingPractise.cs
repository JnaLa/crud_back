using System.ComponentModel.DataAnnotations;

namespace crud_back.Models
{
    public class PuttingPractise
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int C1Short { get; set; }
        [Required]
        public int C1Medium { get; set; }
        [Required]
        public int C1Long { get; set; }
        [Required]
        public int C2Short { get; set; }
        [Required]
        public int C2Medium { get; set; }
        [Required]
        public int C2Long { get; set; }
    }
}
