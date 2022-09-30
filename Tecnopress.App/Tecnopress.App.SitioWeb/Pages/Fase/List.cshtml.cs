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
    public class ListModel : PageModel
    {
 public IEnumerable<Fase> fases {get;set;}
        private IRepositorioFase _repoFase;

        public ListModel(){
            _repoFase= new RepositorioFase(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet()
        {
            fases = _repoFase.GetALLFase();   
        }
    }
}
