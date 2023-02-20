using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_MasonNH.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        // build foreign key relationship
        [Required]
        public int CategoryId { get; set; }
        public Category category { get; set; }
        
        [Required]
        public string title { get; set; }
        
        [Required]
        public int year { get; set; }
        
        [Required]
        public string director { get; set; }
        
        [Required]
        public string rating { get; set; }
        


        public bool edited { get; set; }
        
        public string lent_to { get; set; }
        
        [MaxLength(25)]
        public string notes { get; set; }
    }
}
