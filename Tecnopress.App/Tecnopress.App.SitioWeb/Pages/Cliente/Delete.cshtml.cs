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
    public class DeleteModel : PageModel
    {

    private IRepositorioCliente _repoCliente {get; set;}
        [BindProperty]
        public Cliente cliente {get; set;}

        public DeleteModel()
        {
            _repoCliente = new RepositorioCliente(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet(int id)
        {
            cliente = _repoCliente.OptenerPorId(id);
        }

        public IActionResult OnPost()
        {
            _repoCliente.DeleteCliente(cliente.idCliente);
            return RedirectToPage("/Cliente/List");
        }

    }
}