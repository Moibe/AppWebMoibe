using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppWebMoibe.Pages
{
    public class FormularioModel : PageModel
    {
        [BindProperty]
        public string Cedula { get; set; } = string.Empty;

        [BindProperty]
        public string Nombre { get; set; } = string.Empty;

        [BindProperty]
        public string Titulo { get; set; } = string.Empty;

        [BindProperty]
        public string Correo { get; set; } = string.Empty;

        [BindProperty]
        public string Telefono { get; set; } = string.Empty;

        public string Mensaje { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                // Mensaje con todos los datos
                Mensaje = $"¡Gracias, {Nombre}!<br>"
                        + $"<strong>Cédula:</strong> {Cedula}<br>"
                        + $"<strong>Título:</strong> {Titulo}<br>"
                        + $"<strong>Correo:</strong> {Correo}<br>"
                        + $"<strong>Teléfono:</strong> {Telefono}";
            }
        }
    }
}