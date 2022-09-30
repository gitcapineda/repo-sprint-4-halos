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
    public class EditModel : PageModel
    {
     private IRepositorioProyecto _repoProyecto {get; set;}
        private IRepositorioCliente _repoCliente { get; set;}
        private IRepositorioCategoria _repoCategoria { get; set;}

        [BindProperty]
        public Proyecto proyecto {get; set;}
        
        public IEnumerable<Cliente> clientes {get; set;}
        public IEnumerable<Categoria> categorias {get; set;}

        public EditModel()
        {
            _repoProyecto = new RepositorioProyecto(new Tecnopress.App.Persistencia.ApplicationContext());
            _repoCliente = new RepositorioCliente(new Tecnopress.App.Persistencia.ApplicationContext());
             _repoCategoria = new RepositorioCategoria(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public IActionResult OnGet(int id)
        {
            categorias =_repoCategoria.GetALLCategoria();
            clientes = _repoCliente.OptenerTodosCliente(); 
            proyecto= _repoProyecto.GetProyecto(id); 
            if (proyecto == null)
            {
                return RedirectToPage("/Proyecto/List");
            }
            else
            {
                return Page();
            }
        }


        public IActionResult OnPost(Proyecto proyecto)
        {
            _repoProyecto.UpdateProyecto(proyecto);
            return RedirectToPage("/Proyecto/List");
        }
    }
}
 
