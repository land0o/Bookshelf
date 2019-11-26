using System;
using System.ComponentModel.DataAnnotations;

namespace BookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }

        [Required]
        [MaxLength(55)]
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}