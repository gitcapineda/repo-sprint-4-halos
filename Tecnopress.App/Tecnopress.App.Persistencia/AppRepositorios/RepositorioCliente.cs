using System.Collections.Generic;  
using Tecnopress.App.Dominio;
using System.Linq;

namespace Tecnopress.App.Persistencia

{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly ApplicationContext _appContext;
        public RepositorioCliente(ApplicationContext appContext)
        {
            _appContext=appContext;
        }

        Cliente IRepositorioCliente.AddCliente(Cliente Clientes)
        {
            var clienteAdicionado= _appContext.Clientes.Add(Clientes);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }
        void IRepositorioCliente.DeleteCliente(int idCliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.idCliente==idCliente);
            if (clienteEncontrado == null)
            return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Cliente> IRepositorioCliente.OptenerTodosCliente()
        {
            return _appContext.Clientes;
        }
        Cliente IRepositorioCliente.OptenerPorId(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(c => c.idCliente == idCliente); 
        }
        Cliente IRepositorioCliente.UpdateCliente(Cliente Clientes)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.idCliente == Clientes.idCliente);
            if (clienteEncontrado!=null)
            {
                clienteEncontrado.nit=Clientes.nit;
                clienteEncontrado.nombre=Clientes.nombre;
                clienteEncontrado.telefono=Clientes.telefono;
                clienteEncontrado.email=Clientes.email;
                clienteEncontrado.direccion=Clientes.direccion;
                clienteEncontrado.nacionalidad=Clientes.nacionalidad;
            

                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }
        
    }
}