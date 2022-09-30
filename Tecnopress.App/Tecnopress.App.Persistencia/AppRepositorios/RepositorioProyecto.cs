using System.Collections.Generic;
using Tecnopress.App.Dominio;
using System.Linq;

namespace Tecnopress.App.Persistencia
{
    public class RepositorioProyecto : IRepositorioProyecto
    {
        private readonly ApplicationContext _appContext;

        public RepositorioProyecto(ApplicationContext contexto)
        {
            _appContext = contexto;
        }

        Proyecto IRepositorioProyecto.AddProyecto(Proyecto proyectonuevo)
        {
            var proyectoA = _appContext.Proyectos.Add(proyectonuevo);
            _appContext.SaveChanges();
            return proyectoA.Entity;
        }

        Proyecto IRepositorioProyecto.UpdateProyecto(Proyecto proyectoActualizar)
        {
            var proyectoU = _appContext.Proyectos.FirstOrDefault(
                c => c.IdProyecto == proyectoActualizar.IdProyecto
            );
            if (proyectoU != null)
            {
                proyectoU.nombreProyecto = proyectoActualizar.nombreProyecto;
                proyectoU.codigoProyecto = proyectoActualizar.codigoProyecto;
                proyectoU.TiempoEjecucion = proyectoActualizar.TiempoEjecucion;
                proyectoU.FechaEjecucion = proyectoActualizar.FechaEjecucion;
                proyectoU.Costo = proyectoActualizar.Costo;
                proyectoU.DescripcionProyecto = proyectoActualizar.DescripcionProyecto;
                proyectoU.Visitas = proyectoActualizar.Visitas;
                proyectoU.clienteId=proyectoActualizar.clienteId;
                proyectoU.categoriaId=proyectoActualizar.categoriaId;
                _appContext.SaveChanges();
            }
            return proyectoU;
        }

        void IRepositorioProyecto.DeleteProyecto(int IdProyecto)
        {
            var proyectoB = _appContext.Proyectos.FirstOrDefault(c => c.IdProyecto == IdProyecto);
            if (proyectoB != null)
            {
                _appContext.Proyectos.Remove(proyectoB);
                _appContext.SaveChanges();
            }
        }

        Proyecto IRepositorioProyecto.GetProyecto(int IdProyecto)
        {
            return _appContext.Proyectos
                .Where(c => c.IdProyecto == IdProyecto)
                .Select(
                    c =>
                        new Proyecto
                        {

                            IdProyecto=c.IdProyecto,
                            nombreProyecto=c.nombreProyecto,
                            codigoProyecto= c.codigoProyecto,
                            TiempoEjecucion=c.TiempoEjecucion,
                            FechaEjecucion = c.FechaEjecucion,
                            Costo=c.Costo,
                            DescripcionProyecto=c.DescripcionProyecto,
                            Visitas=c.Visitas,
                            clienteId=c.clienteId,
                            cliente = c.cliente,
                            categoriaId = c.categoriaId,
                            categoria= c.categoria
                        }
                )
                .FirstOrDefault();
        }

        IEnumerable<Proyecto>  IRepositorioProyecto.GetALLProyecto()
        {
            return _appContext.Proyectos
                .Select(
                    c =>
                        new Proyecto
                        {
                            IdProyecto=c.IdProyecto,
                            nombreProyecto=c.nombreProyecto,
                            codigoProyecto= c.codigoProyecto,
                            TiempoEjecucion=c.TiempoEjecucion,
                            FechaEjecucion = c.FechaEjecucion,
                            Costo=c.Costo,
                            DescripcionProyecto=c.DescripcionProyecto,
                            Visitas=c.Visitas,
                            clienteId=c.clienteId,
                            cliente = c.cliente,
                            categoriaId = c.categoriaId,
                            categoria= c.categoria
                        }
                )
                .ToList();
        }
    }
}
