using System;
using System.ComponentModel.DataAnnotations;

namespace Ing.soft_I.Models
{
    public class compra
    {
        [Key]
        public string idcompra{get;set;}
        public string descompra{get;set;}
        public string fechacompra{get;set;}
        public double precio{get;set;}
    }
}
