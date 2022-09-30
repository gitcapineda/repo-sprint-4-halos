using System;
using System.ComponentModel.DataAnnotations;
namespace Tecnopress.App.Dominio
{
    public class Fase
    {
        [Key]
        public int idFase {get;set;}
        public int? proyectoId {get;set;}

        public Proyecto proyecto {get;set;}
        public string nombreFase {get;set;}
        public DateTime fechaCambio {get;set;}
        public string descripcion {get;set;}


    }
}