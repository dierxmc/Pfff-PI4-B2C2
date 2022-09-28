using System.ComponentModel.DataAnnotations;

namespace Pfff_PI4_B2C2.Models
{
    public class Camera
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Specification { get; set; }

        [Required]
        public float xCoords { get; set; }

        [Required]
        public float yCoords { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
