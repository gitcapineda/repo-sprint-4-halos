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
    public class CreateModel : PageModel
    {
        //crear una instancia del Irepositorio
        private IRepositorioFase _repoFase{get;set;}
        [BindProperty]
        public Fase fase {get;set;}

        public CreateModel()
        {
             _repoFase= new RepositorioFase(new Tecnopress.App.Persistencia.ApplicationContext());
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Fase fase)
        {
            _repoFase.AddFase(fase);
            return RedirectToPage("/Fase/List");
        }
    }
}
