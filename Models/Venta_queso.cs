using System;
using System.ComponentModel.DataAnnotations;

namespace Ing.soft_I.Models
{
    public class venta_queso
    {
        [Key]
        public string idventa{get;set;}
        public string idqueso{get;set;}
        public string observaciones{get;set;}
        public double subtotal {get;set;}
        public int cantquesto{get;set;}
        public double precio {get;set;}
    }
}