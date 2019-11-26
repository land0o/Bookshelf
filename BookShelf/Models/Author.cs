using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShelf.Models
{
    public class Author
    {
        [Required]
        public int Id { get; set; }

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

        public List<Book> Books { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}