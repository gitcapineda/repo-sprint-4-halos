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
    public class EditModel : PageModel
    {
        private IRepositorioFase _repoFase { get; set; }

        [BindProperty]
        public Fase fase { get; set; }

        public EditModel()
        {
            _repoFase = new RepositorioFase(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public IActionResult OnGet(int id)
        {
            fase = _repoFase.UpdateFase(fase);
            if (fase == null)
            {
                return RedirectToPage("/Fase/List");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Fase fase)
        {
            _repoFase.UpdateFase(fase);
            return RedirectToPage("/Fase/List");
        }

    }
}
