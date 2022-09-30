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
    public class CreateModel : PageModel
    {
        private IRepositorioUsuario _repoUsuario{get;set;}
        [BindProperty]
        public Usuario usuario {get;set;}

        public CreateModel()
        {
             _repoUsuario= new RepositorioUsuario(new Tecnopress.App.Persistencia.ApplicationContext());
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
            _repoUsuario.AddUsuario(usuario);
            return RedirectToPage("/Usuario/List");

            }else{
                return Page();
            }
        }
    }
}
