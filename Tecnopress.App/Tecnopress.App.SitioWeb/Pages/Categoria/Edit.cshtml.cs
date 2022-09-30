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
    public class EditModel : PageModel
    {
 private IRepositorioCategoria _repoCategoria { get; set; }

        [BindProperty]
        public Categoria categoria { get; set; }

        public EditModel()
        {
            _repoCategoria = new RepositorioCategoria(
                new Tecnopress.App.Persistencia.ApplicationContext()
            );
        }

        public IActionResult OnGet(int id)
        {
            categoria = _repoCategoria.GetCategoria(id);
            if (categoria == null)
            {
                return RedirectToPage("/Categoria/List");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Categoria categoria)
        {
            _repoCategoria.UpdateCategoria(categoria);
            return RedirectToPage("/Categoria/List");
        }

    }
}
