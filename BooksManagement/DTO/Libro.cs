using System.ComponentModel.DataAnnotations;

namespace BooksManagement.DTO
{
    public class Libro
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Title { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Body { get; set; }
    }
}
