using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;


namespace Tecnopress.App.SitioWeb.Pages_Cliente
{
    public class ListModel : PageModel
    {
        public IEnumerable<Cliente> clientes {get;set;}
        private IRepositorioCliente _repoCliente;

        public ListModel(){
            _repoCliente= new RepositorioCliente(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet()
        {
            clientes=_repoCliente.OptenerTodosCliente();
        }
    }
}
