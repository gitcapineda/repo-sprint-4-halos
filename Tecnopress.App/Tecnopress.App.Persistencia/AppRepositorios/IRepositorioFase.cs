//puente entre las entidades y la BD
using System.Collections.Generic;  
using Tecnopress.App.Dominio;

namespace Tecnopress.App.Persistencia

{

    public interface IRepositorioFase
    {
        IEnumerable <Fase> GetALLFase();  
        Fase AddFase(Fase Fases);
        Fase UpdateFase(Fase Fases);
        void DeleteFase(int idFase);
        Fase GetFase(int idFase);
    }
    
}