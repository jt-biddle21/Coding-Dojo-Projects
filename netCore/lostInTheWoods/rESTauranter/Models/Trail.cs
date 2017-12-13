using System.ComponentModel.DataAnnotations;

namespace rESTauranter.Models
{
    public class Trail : BaseEntity
    {
        [Key]
        public int TrailId {get; set;}

        [Required]
        [Display(Name="Trail Name")]
        public string Name {get; set;}
        
        [Required]
        public string Description {get; set;}

        [Required]
        [Range(0, 10000)]
        [Display(Name="Trail Length (in miles)")]
        public float Length {get; set;}

        [Required]
        public int Elevation {get; set;}

        [Required]
        [Range(-90, 90)]
        public float Latitude {get; set;}

        [Required]
        [Range(-180,180)]
        public float Longitude {get; set;}
    }
}