﻿using System.ComponentModel.DataAnnotations;

namespace book.Models.Domain
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
