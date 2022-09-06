using System;
using System.Collections.Generic;

namespace BooksManagement.Models
{
    public partial class Usuario
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int NumIdentificacion { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string TelefonoFijo { get; set; }
        public int Chabilitado { get; set; }
    }
}
