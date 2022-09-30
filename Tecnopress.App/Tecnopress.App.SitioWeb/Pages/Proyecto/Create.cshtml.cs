using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;

namespace Tecnopress.App.SitioWeb.Pages_Proyecto
{
    public class CreateModel : PageModel
    {
        private IRepositorioProyecto _repoProyecto { get; set; }
        private IRepositorioCategoria _repoCategoria { get; set; }
         private IRepositorioCliente _repoCliente { get; set; }

        [BindProperty]
        public Proyecto proyecto { get; set; }
        [BindProperty]
        public IEnumerable<Categoria> categorias { get; set; }
        [BindProperty]
        public IEnumerable<Cliente> clientes { get; set; }

        public CreateModel()
        {
            _repoProyecto = new RepositorioProyecto(
                new Tecnopress.App.Persistencia.ApplicationContext()
            );
            _repoCategoria = new RepositorioCategoria(new Tecnopress.App.Persistencia.ApplicationContext());
            _repoCliente = new RepositorioCliente(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet()
        {
            categorias = _repoCategoria.GetALLCategoria(); 
            clientes=_repoCliente.OptenerTodosCliente(); 
        }

        public IActionResult OnPost(Proyecto proyecto)
        {
            _repoProyecto.AddProyecto(proyecto);
            return RedirectToPage("/Proyecto/List");
            if (ModelState.IsValid)
            {
                _repoProyecto.AddProyecto(proyecto);
                return RedirectToPage("/Proyecto/List");
            }
            else
            {
                return Page();
            }
        }
    }
}
