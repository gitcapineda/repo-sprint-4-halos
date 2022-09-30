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
    public class ListModel : PageModel
    {
        public IEnumerable<Usuario> usuarios {get;set;}
        private IRepositorioUsuario _repoUsuario;

        public ListModel(){
            _repoUsuario= new RepositorioUsuario(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet()
        {
            usuarios= _repoUsuario.GetALLUsuario();  
        }
    }
}
