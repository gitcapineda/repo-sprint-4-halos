using System.Collections.Generic;
using Tecnopress.App.Dominio;
using System.Linq;

namespace Tecnopress.App.Persistencia
{
   public class RepositorioLogin : IRepositorioLogin
    {
        private readonly ApplicationContext _appContext;

        public RepositorioLogin(ApplicationContext contexto)
        {
            _appContext = contexto;
        }


        Login IRepositorioLogin.AddLogin(Login loginnuevo)
        {
            var loginA = _appContext.Logins.Add(loginnuevo);
            _appContext.SaveChanges();
            return loginA.Entity;
        }
        
        Login IRepositorioLogin.UpdateLogin(Login loginActualizar) 
        {
            var loginU = _appContext.Logins.FirstOrDefault(c => c.idLogin == loginActualizar.idLogin);
            if (loginU != null)
            {
                loginU.fechaIngreso = loginActualizar.fechaIngreso;
              loginU.direccionIp = loginActualizar.direccionIp;
                loginU.usuarioId = loginActualizar.usuarioId;
                _appContext.SaveChanges();
            }
            return loginU;
        }
        
        void IRepositorioLogin.DeleteLogin(int idLogin)
        {
            var loginB = _appContext.Logins.FirstOrDefault(c => c.idLogin == idLogin);
            if (loginB != null)
            {
                _appContext.Logins.Remove(loginB);
                _appContext.SaveChanges();
            }
        }
        
        Login IRepositorioLogin.GetLogin(int idLogin){
            return _appContext.Logins.Where(c => c.idLogin == idLogin).Select(c => new Login
            {
                

                idLogin=c.idLogin,
                fechaIngreso =c.fechaIngreso,
                direccionIp=c.direccionIp,
                usuarioId=c.usuarioId,
                usuario=c.usuario

                
            }).FirstOrDefault();
        }
        
        IEnumerable<Login> IRepositorioLogin.GetALLLogin()
        {
            return _appContext.Logins.Select(c => new Login
            {
               idLogin=c.idLogin,
                fechaIngreso =c.fechaIngreso,
                direccionIp=c.direccionIp,
                usuarioId=c.usuarioId,
                usuario=c.usuario
            }).ToList(); 
        }
    }
}