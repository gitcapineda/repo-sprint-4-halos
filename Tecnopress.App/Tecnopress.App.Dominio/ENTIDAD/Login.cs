using System;
using System.ComponentModel.DataAnnotations;
namespace Tecnopress.App.Dominio
{
    public class Login 
    {
        [Key]
        public int idLogin {get;set;}
        
        public int? usuarioId {get;set;}
        public Usuario usuario{get;set;}
        public DateTime fechaIngreso {get;set;}
        public string direccionIp {get;set;}

       
       
    }
}