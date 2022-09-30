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
    public class DeleteModel : PageModel
    {
        private IRepositorioLogin _repoLogin { get; set; }

        [BindProperty]
        public Login login { get; set; }

        public DeleteModel()
        {
            _repoLogin = new RepositorioLogin(
                new Tecnopress.App.Persistencia.ApplicationContext()
            );
        }

        public void OnGet(int id)
        {
            login = _repoLogin.GetLogin(id);  
        }

        public IActionResult OnPost()
        {
            _repoLogin.DeleteLogin(login.idLogin);
            return RedirectToPage("/Login/List");
        }
    }
}
