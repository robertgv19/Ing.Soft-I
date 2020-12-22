using System;
using System.ComponentModel.DataAnnotations;

namespace Ing.soft_I.Models
{
    public class queso
    {
             [Key]
             public string idqueso{get;set;}
             public string nomqueso{get;set;}
             public string desccqueso{get;set;}
             public double precio{get;set;}
             
    }
}