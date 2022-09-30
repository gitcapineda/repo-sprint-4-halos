using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tecnopress.App.Dominio;


namespace Tecnopress.App.Persistencia
{
    public class RepositorioFase : IRepositorioFase
    {
        private readonly ApplicationContext _appContext;

        public RepositorioFase(ApplicationContext contexto)
        {
            _appContext = contexto;
        }

        Fase IRepositorioFase.AddFase(Fase fasenuevo)
        {
            var faseA = _appContext.Fases.Add(fasenuevo);
            _appContext.SaveChanges();
            return faseA.Entity;
        }

        Fase IRepositorioFase.UpdateFase(Fase faseActualizar)
        {
            var faseU = _appContext.Fases.FirstOrDefault(c => c.idFase == faseActualizar.idFase);
            if (faseU != null)
            {
                faseU.nombreFase = faseActualizar.nombreFase;
                faseU.descripcion = faseActualizar.descripcion;
                faseU.fechaCambio = faseActualizar.fechaCambio;
                faseU.proyectoId = faseActualizar.proyectoId;
                _appContext.SaveChanges();
            }
            return faseU;
        }

        void IRepositorioFase.DeleteFase(int idFase)
        {
            var faseB = _appContext.Fases.FirstOrDefault(c => c.idFase == idFase);
            if (faseB != null)
            {
                _appContext.Fases.Remove(faseB);
                _appContext.SaveChanges();
            }
        }

        Fase IRepositorioFase.GetFase(int idFase)
        {
            return _appContext.Fases
                .Where(c => c.idFase == idFase)
                .Select(
                    c =>
                        new Fase
                        {
                            idFase = c.idFase,
                            nombreFase = c.nombreFase,
                            fechaCambio = c.fechaCambio,
                            descripcion = c.descripcion,
                            proyectoId = c.proyectoId,
                            proyecto = c.proyecto
                        }).FirstOrDefault();
        }
        IEnumerable<Fase>  IRepositorioFase.GetALLFase()
        {
            return _appContext.Fases.Select(c =>new Fase
                        {
                           idFase=c.idFase,
                            nombreFase=c.nombreFase,
                            fechaCambio= c.fechaCambio,
                            descripcion=c.descripcion,  
                            proyectoId=c.proyectoId,
                            proyecto= c.proyecto
                        }).ToList();
        }
    }
}
