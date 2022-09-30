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
    public class DeleteModel : PageModel
    {
  private IRepositorioProyecto _repoProyecto {get; set;}
        [BindProperty]
        public Proyecto proyecto {get; set;}

        public DeleteModel()
        {
            _repoProyecto = new RepositorioProyecto(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet(int id)
        {
            proyecto = _repoProyecto.GetProyecto(id); 
        }

        public IActionResult OnPost()
        {
            _repoProyecto.DeleteProyecto(proyecto.IdProyecto);
            return RedirectToPage("/Proyecto/List");
        }

    }
}
