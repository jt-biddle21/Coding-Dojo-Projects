using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace dojoLeague.Models
{
    public class Ninja : BaseEntity
    {
        [Key]
        public int NinjaId {get; set;}

        [Required]
        [Display(Name="Ninja Name")]
        public string NinjaName {get; set;}
        
        [Required]
        [Range(1, 10)]
        public int Level {get; set;}

        [Required]
        public string Dojo {get; set;}

        [Display(Name="Optional Description")]
        public string Description {get; set;}
        public string NinjaDescription {get; set;}
        public string DojoName {get; set;}
        public int Dojo_Id {get; set;}
    }
}