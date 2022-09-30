using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;

namespace Tecnopress.App.SitioWeb.Pages_Categoria
{
    public class DeleteModel : PageModel
    {
        private IRepositorioCategoria _repoCategoria {get; set;}
        [BindProperty]
        public Categoria categoria {get; set;}

        public DeleteModel()
        {
            _repoCategoria = new RepositorioCategoria(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet(int id)
        {
            categoria = _repoCategoria.GetCategoria(id);
        }

        public IActionResult OnPost()
        {
            _repoCategoria.DeleteCategoria(categoria.idCategoria);
            return RedirectToPage("/Categoria/List");
        }

    }
}