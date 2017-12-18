using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace dojoLeague.Models
{
    public class Dojo : BaseEntity
    {
        [Key]
        public int DojoId {get; set;}

        [Required]
        [Display(Name="Dojo Name")]
        public string DojoName {get; set;}
        
        [Required]
        public string Location {get; set;}

        [Required]
        public string Description {get; set;}
        public int Dojo_Id {get; set;}
        public int NinjaId {get; set;}

        public string NinjaName {get; set;}
    }
}