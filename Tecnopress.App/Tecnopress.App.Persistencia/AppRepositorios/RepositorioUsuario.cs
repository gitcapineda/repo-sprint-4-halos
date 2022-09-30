using System.Collections.Generic;  
using Tecnopress.App.Dominio;
using System.Linq;

namespace Tecnopress.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly ApplicationContext _appContext;
        public RepositorioUsuario(ApplicationContext appContext)
        {
            _appContext=appContext;
        }
        Usuario IRepositorioUsuario.AddUsuario(Usuario Usuarios)
        {
            var usuarioAdicionado=_appContext.Usuarios.Add(Usuarios);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }
        void IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u => u.idUsuario==idUsuario);
            if (usuarioEncontrado==null)
            return;
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Usuario> IRepositorioUsuario.GetALLUsuario()
        {
            return _appContext.Usuarios;
        }
        Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
        {
            return _appContext.Usuarios.FirstOrDefault(u=> u.idUsuario==idUsuario);
        }
        Usuario IRepositorioUsuario.UpdateUsuario(Usuario Usuarios)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u=> u.idUsuario== Usuarios.idUsuario);
            if (usuarioEncontrado!=null)
            {
                usuarioEncontrado.nombreUsuario=Usuarios.nombreUsuario;
                usuarioEncontrado.direccionUsuario=Usuarios.direccionUsuario;
                usuarioEncontrado.roles=Usuarios.roles;
                usuarioEncontrado.estado= Usuarios.estado;
                usuarioEncontrado.users=Usuarios.users;
                usuarioEncontrado.pass=Usuarios.pass;

                _appContext.SaveChanges();
                
            }
            return usuarioEncontrado;
        }
    
    }
}