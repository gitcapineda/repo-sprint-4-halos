//puente entre las entidades y la BD
using System.Collections.Generic;  
using Tecnopress.App.Dominio;

namespace Tecnopress.App.Persistencia

{

    public interface IRepositorioCategoria
    {
        IEnumerable <Categoria> GetALLCategoria();  
        Categoria AddCategoria(Categoria Categorias);
        Categoria UpdateCategoria(Categoria Categorias);
        void DeleteCategoria(int idCategoria);
        Categoria GetCategoria (int idCategoria);
    }
    
}