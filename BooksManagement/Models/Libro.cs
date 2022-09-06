using System;
using System.Collections.Generic;

namespace BooksManagement.Models
{
    public partial class Libro
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
