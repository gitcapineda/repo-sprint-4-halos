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
    public class ListModel : PageModel
    {
        public IEnumerable<Categoria> categorias{get;set;}
        private IRepositorioCategoria _repoCategoria;

        public ListModel(){
            _repoCategoria= new RepositorioCategoria(new Tecnopress.App.Persistencia.ApplicationContext());
        }

        public void OnGet()
        {
            categorias=_repoCategoria.GetALLCategoria();
        }
    }
}
