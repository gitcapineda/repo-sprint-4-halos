using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;  
using Tecnopress.App.Dominio;

namespace Tecnopress.App.Persistencia
{
    public class RepositorioCategoria : IRepositorioCategoria
    {
        private readonly ApplicationContext _appContext;
        public RepositorioCategoria(ApplicationContext appContext)
        {
            _appContext=appContext;
        }
        Categoria IRepositorioCategoria.AddCategoria(Categoria Categorias)
        {
            var categoriaAdicionado=_appContext.Categorias.Add(Categorias);
            _appContext.SaveChanges();
            return categoriaAdicionado.Entity;
        }
        void IRepositorioCategoria.DeleteCategoria(int idCategoria)
        {
            var categoriaEncontrado = _appContext.Categorias.FirstOrDefault(u => u.idCategoria==idCategoria);
            if (categoriaEncontrado==null)
            return;
            _appContext.Categorias.Remove(categoriaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Categoria> IRepositorioCategoria.GetALLCategoria()
        {
            return _appContext.Categorias;
        }
        Categoria IRepositorioCategoria.GetCategoria(int idCategoria)
        {
            return _appContext.Categorias.FirstOrDefault(u=> u.idCategoria==idCategoria);
        }
        Categoria IRepositorioCategoria.UpdateCategoria(Categoria Categorias)
        {
            var categoriaEncontrado = _appContext.Categorias.FirstOrDefault(u=> u.idCategoria== Categorias.idCategoria);
            if (categoriaEncontrado!=null)
            {
                categoriaEncontrado.nombreCategoria=Categorias.nombreCategoria;
               
               

                _appContext.SaveChanges();
                
            }
            return categoriaEncontrado;
        }
    
    }
}