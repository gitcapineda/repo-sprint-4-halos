//puente entre las entidades y la BD
using System.Collections.Generic;  
using Tecnopress.App.Dominio;

namespace Tecnopress.App.Persistencia

{

    public interface IRepositorioUsuario
    {
        IEnumerable <Usuario> GetALLUsuario();  
        Usuario AddUsuario(Usuario Usuarios);
        Usuario UpdateUsuario(Usuario Usuarios);
        void DeleteUsuario(int idUsuario);
        Usuario GetUsuario(int idUsuario);
    }
    
}