using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//sieempre incluir dominio  y pesistencia
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;


namespace Tecnopress.App.SitioWeb.Pages_Cliente
{
    public class CreateModel : PageModel
    {
        //crear una instancia del Irepositorio
        private IRepositorioCliente _repoCliente{get;set;}
        [BindProperty]
        public Cliente cliente {get;set;}

        public CreateModel()
        {
             _repoCliente= new RepositorioCliente(new Tecnopress.App.Persistencia.ApplicationContext());
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Cliente cliente)
        {
            if(ModelState.IsValid)
            {
            _repoCliente.AddCliente(cliente);
            return RedirectToPage("/Cliente/List");
            }else{
                return Page();
            }
        }
    }
}
