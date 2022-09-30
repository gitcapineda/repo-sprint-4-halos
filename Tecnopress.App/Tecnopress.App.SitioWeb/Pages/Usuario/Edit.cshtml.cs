using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;

namespace Tecnopress.App.SitioWeb.Pages_Usaurio
{
    public class EditModel : PageModel
    {
       private IRepositorioUsuario _repoUsuario { get; set; }

        [BindProperty]
        public Usuario usuario { get; set; }

        public EditModel()
        {
            _repoUsuario = new RepositorioUsuario(
                new Tecnopress.App.Persistencia.ApplicationContext()
            );
        }

        public IActionResult OnGet(int id)
        {
            usuario = _repoUsuario.GetUsuario(id);
            if (usuario == null)
            {
                return RedirectToPage("/Usuario/List");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Usuario usuario)
        {
            _repoUsuario.UpdateUsuario(usuario);
            return RedirectToPage("/Usuario/List");
        }

    }
}
