using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//sieempre incluir dominio  y pesistencia
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;


namespace Tecnopress.App.SitioWeb.Pages_Categoria
{
    public class CreateModel : PageModel
    {
        private IRepositorioCategoria _repoCategoria{get;set;}
        [BindProperty]
        public Categoria categoria {get;set;}

        public CreateModel()
        {
             _repoCategoria= new RepositorioCategoria(new Tecnopress.App.Persistencia.ApplicationContext());
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Categoria categoria)
        {
            if(ModelState.IsValid)
            {
            _repoCategoria.AddCategoria(categoria);
            return RedirectToPage("/Categoria/List");
            }else{
                return Page();
            }
        }
    }
}
