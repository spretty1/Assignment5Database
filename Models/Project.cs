using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models
{
    public class Project
    {   //sets a key for the data, and checks to ensure all the needed info is required as well as normalizing it by splitting it up
        
        [Key, Required]
        public int BookId { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string AuthorFirst { get; set; }
        
        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string Publisher { get; set; }

        //checks to ensure the ISBN is in proper format 
        [Required, RegularExpression(@"^[0-9]{3}(-[0-9]{10})$", ErrorMessage = "Enter a valid ISBN")]
        public string ISBN { get; set; }
       
        [Required]
        public string Classification { get; set; }
        
        [Required]
        public string Category { get; set; }
        
        [Required]
        public double Price { get; set; }

        [Required]
        public int NumPages { get; set; }
    }
}
