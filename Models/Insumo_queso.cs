using System;
using System.ComponentModel.DataAnnotations;

namespace Ing.soft_I.Models
{
    public class insumo_queso
    {
        [Key]
        public string idqueso{get;set;}
        public string idinsumo{get;set;}
        public double cantinsumousado{get;set;}
        
    }
}