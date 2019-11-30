using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class AuthorViewModel
    {
        public Author Author { get; set; }
        public List<Book> Books { get; set; }

        public List<SelectListItem> BookOptions
        {
            get
            {
                return Books?.Select(b => new SelectListItem(b.Title, b.Id.ToString())).ToList();
            }
        }
    }
}
