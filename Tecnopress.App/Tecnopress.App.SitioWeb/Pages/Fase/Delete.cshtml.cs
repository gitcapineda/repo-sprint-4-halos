using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;

namespace Tecnopress.App.SitioWeb.Pages_Fase
{
    public class DeleteModel : PageModel
    {

    private IRepositorioFase _repoFase {get; set;}
        [BindProperty]
        public Fase fase {get; set;}

        public DeleteModel()
        {
            _repoFase = new RepositorioFase(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet(int id)
        {
            fase = _repoFase.GetFase(id);
        }

        public IActionResult OnPost()
        {
            _repoFase.DeleteFase(fase.idFase);
            return RedirectToPage("/Fase/List");
        }

    }
}
