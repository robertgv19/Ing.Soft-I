using System;
using System.ComponentModel.DataAnnotations;


namespace Ing.soft_I.Models
{
    public class cliente
    {
        [Key]
        public string documento {get;set;}
        public string nombre{get;set;}
        public string apepaterno{get;set;}
        public string apematerno{get;set;}
    }
}