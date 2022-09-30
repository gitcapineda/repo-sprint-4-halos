using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Tecnopress.App.Dominio
{
    public class Cliente
    {
        //atritbutos
        [Key]
        public int idCliente { get; set; }
        public string nit { get; set; }
        public string nombre { get; set; }

        [MaxLength(10)]
        public string telefono { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string nacionalidad { get; set; }

        //Lista de Proyectos
        
    }
}