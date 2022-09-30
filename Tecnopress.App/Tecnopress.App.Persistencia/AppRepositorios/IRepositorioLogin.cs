//puente entre las entidades y la BD
using System.Collections.Generic;
using Tecnopress.App.Dominio;

namespace Tecnopress.App.Persistencia
{
    public interface IRepositorioLogin
    {
        IEnumerable<Login> GetALLLogin();
        Login AddLogin(Login Logins);
        Login UpdateLogin(Login Logins);
        void DeleteLogin(int idLogin);
        Login GetLogin(int idLogin);
    }
}
