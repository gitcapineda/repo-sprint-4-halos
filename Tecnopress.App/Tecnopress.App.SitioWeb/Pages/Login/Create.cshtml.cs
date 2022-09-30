using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//sieempre incluir dominio  y pesistencia
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;

namespace Tecnopress.App.SitioWeb.Pages_Login
{
     public class CreateModel : PageModel
    {
        private IRepositorioLogin _repoLogin {get; set;}
        private IRepositorioUsuario _repoUsuario { get; set;}
        [BindProperty]
        public Login login {get; set;}
        public IEnumerable<Usuario> usuarios {get; set;}

        public CreateModel()
        {
            _repoLogin = new RepositorioLogin(new Tecnopress.App.Persistencia.ApplicationContext());
            _repoUsuario = new RepositorioUsuario(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet()
        {
            usuarios = _repoUsuario.GetALLUsuario();
        }

        public IActionResult OnPost(Login login)
        {
            _repoLogin.AddLogin(login);
                return RedirectToPage("/Login/List");
            
        }

    }
}

