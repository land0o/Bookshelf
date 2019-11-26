using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(25)]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(35)]
        [MinLength(2)]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
    }
}
