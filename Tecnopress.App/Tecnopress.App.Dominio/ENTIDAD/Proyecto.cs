using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Tecnopress.App.Dominio
{
   public class Proyecto
   {
    [Key]
    public int IdProyecto {get;set;}
    
    public int? clienteId {get;set;}
    //el codigo public Cliente cliente  hace referencia a la llave foranea
    public Cliente cliente {get;set;}
    public int? categoriaId {get;set;}
    public Categoria categoria {get;set;}
    public string nombreProyecto {get;set;}
    public string codigoProyecto {get;set;}
    public string TiempoEjecucion {get;set;}
    public DateTime FechaEjecucion {get;set;}
    public double Costo {get;set;}
    public string DescripcionProyecto {get;set;}
    public int Visitas {get;set;}

    //Lista de Fases
   
   } 
}