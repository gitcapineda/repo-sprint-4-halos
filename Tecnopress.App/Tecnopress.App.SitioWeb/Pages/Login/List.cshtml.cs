using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;

namespace Tecnopress.App.SitioWeb.Pages_Login
{
    public class ListModel : PageModel
    {
        public IEnumerable<Login> logins {get; set;}
        private IRepositorioLogin _repoLogin;

        public ListModel()
        {
            _repoLogin = new RepositorioLogin(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet()
        {
            logins= _repoLogin.GetALLLogin();
        }
    }
}
