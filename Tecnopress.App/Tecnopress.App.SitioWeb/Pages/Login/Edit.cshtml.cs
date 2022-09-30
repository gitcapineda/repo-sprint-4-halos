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
    public class EditModel : PageModel
    {
        private IRepositorioLogin _repoLogin { get; set; }
        private IRepositorioUsuario _repoUsuario { get; set; }

        [BindProperty]
        public Login login { get; set; }

        public IEnumerable<Usuario> usuarios { get; set; }

        public EditModel()
        {
            _repoLogin = new RepositorioLogin(
                new Tecnopress.App.Persistencia.ApplicationContext()
            );
            _repoUsuario = new RepositorioUsuario(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public IActionResult OnGet(int id)
        {
            usuarios = _repoUsuario.GetALLUsuario();
            login = _repoLogin.GetLogin(id);
            if (login == null)
            {
                return RedirectToPage("/Login/List");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Login login)
        {
            _repoLogin.UpdateLogin(login);
            return RedirectToPage("/Login/List");
        }
    }
}
