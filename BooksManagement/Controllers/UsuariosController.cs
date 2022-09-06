
using BooksManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksManagement.Controllers
{
    public class UsuariosController : Controller
    {
        private Models.BookManagementContext _db;

        public UsuariosController(Models.BookManagementContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Usuario> usurioList = new List<Usuario>();

            using (_db)// (var bd = new ManejoDocumentalThomasContext)
            {
                usurioList = (from usuario in _db.Usuarios
                               where usuario.Chabilitado == 1
                               select new Usuario
                               {
                                   IdCliente = usuario.IdCliente,
                                   Nombres = usuario.Nombres,
                                   Apellidos = usuario.Apellidos,
                                   NumIdentificacion = usuario.NumIdentificacion,
                                   Email = usuario.Email,
                                   Direccion = usuario.Direccion,
                                   TelefonoFijo = usuario.TelefonoFijo,
                                   Chabilitado = usuario.Chabilitado
                               }).ToList();
            }
            return View(usurioList);
        }

        public IActionResult Crear()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Crear(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }
            else
            {
                using (_db)
                {
                    Usuario usuario1 = new Usuario();
                    usuario1.Nombres = usuario.Nombres;
                    usuario1.Apellidos = usuario.Apellidos;
                    usuario1.NumIdentificacion = usuario.NumIdentificacion;
                    usuario1.Email = usuario.Email;
                    usuario1.Direccion = usuario.Direccion;
                    usuario1.TelefonoFijo = usuario.TelefonoFijo;
                    usuario1.Chabilitado = 1;
                    _db.Usuarios.Add(usuario1);
                    _db.SaveChanges();

                }
            }
            return RedirectToAction("Index");
        }
    }
}
