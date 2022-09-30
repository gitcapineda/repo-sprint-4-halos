//puente entre las entidades y la BD
using System.Collections.Generic;  
using Tecnopress.App.Dominio;

namespace Tecnopress.App.Persistencia

{

    public interface IRepositorioCliente
    {
        IEnumerable <Cliente> OptenerTodosCliente();  
        Cliente AddCliente(Cliente Clientes);
        Cliente UpdateCliente(Cliente Clientes);
        void DeleteCliente(int idCliente);
        Cliente OptenerPorId(int idCliente);
    }
    
}