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
    public class DeleteModel : PageModel
    {
         private IRepositorioUsuario _repoUsuario {get; set;}
        [BindProperty]
        public Usuario usuario{get; set;}

        public DeleteModel()
        {
            _repoUsuario = new RepositorioUsuario(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet(int id)
        {
            usuario = _repoUsuario.GetUsuario(id);
        }

        public IActionResult OnPost()
        {
            _repoUsuario.DeleteUsuario(usuario.idUsuario);
            return RedirectToPage("/Usuario/List");
        }

    }
}