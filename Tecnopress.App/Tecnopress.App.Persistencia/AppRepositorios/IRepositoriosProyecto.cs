//puente entre las entidades y la BD
using System.Collections.Generic;  
using Tecnopress.App.Dominio;

namespace Tecnopress.App.Persistencia

{

    public interface IRepositorioProyecto
    {
        IEnumerable <Proyecto> GetALLProyecto();  
        Proyecto AddProyecto(Proyecto Proyectos);
        Proyecto UpdateProyecto(Proyecto Proyectos);
        void DeleteProyecto(int ProyectoId);
        Proyecto GetProyecto(int ProyectoId);
    }
    
}