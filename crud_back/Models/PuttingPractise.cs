using System.ComponentModel.DataAnnotations;

namespace crud_back.Models
{
    public class PuttingPractise
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string C1Short { get; set; }
        [Required]
        public string C1Medium { get; set; }
        [Required]
        public string C1Long { get; set; }
        [Required]
        public string C2Short { get; set; }
        [Required]
        public string C2Medium { get; set; }
        [Required]
        public string C2Long { get; set; }
    }
}
