using System;
using System.ComponentModel.DataAnnotations;

namespace Ing.soft_I.Models
{
    public class compra_insumo
    {
        public string idcompra{get;set;}
        public string idinsumo{get;set;}
        public string observaciones{get;set;}
        public double subtotal{get;set;}
        public int cantinsumo{get;set;}
        public double precio {get;set;}
    }
}