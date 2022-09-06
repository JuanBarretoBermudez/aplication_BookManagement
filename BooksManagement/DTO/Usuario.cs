using System.ComponentModel.DataAnnotations;

namespace BooksManagement.DTO
{
    public class Usuario
    {
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombres { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Apellidos { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Numero de Identificacion")]
        public int NumIdentificacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El Campo debe ser un correo electronico valido")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Direccion { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string TelefonoFijo { get; set; } = null!;

        public int Chabilitado { get; set; }
    }
}
