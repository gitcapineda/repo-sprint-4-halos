using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Tecnopress.App.Dominio
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string direccionUsuario { get; set; }
        public Roles roles { get; set; }
        public Estado estado { get; set; }
        public string users { get; set; }
        public string pass { get; set; }

        //Lista login
        
    }
}
