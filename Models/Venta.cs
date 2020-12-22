using System;
using System.ComponentModel.DataAnnotations;

namespace Ing.soft_I.Models
{
    public class venta
    {
        [Key]
        public string idventa{get;set;}
    
        public DateTime fechaventa{get;set;}
        public string descventa{get;set;}
        public double precio {get;set;}
        public string cliente_documento{get;set;}
    }
}