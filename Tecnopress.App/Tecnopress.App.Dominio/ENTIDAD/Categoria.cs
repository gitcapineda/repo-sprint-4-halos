using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Tecnopress.App.Dominio
{
    public class Categoria
    {
        [Key]
        public int idCategoria  {get;set;}
        [MaxLength(50)]
        public string nombreCategoria {get;set;}

        //Lista de Proyectos
        
    }
}