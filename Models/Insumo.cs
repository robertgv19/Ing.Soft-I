using System;
using System.ComponentModel.DataAnnotations;

namespace Ing.soft_I.Models
{
    public class insumo
    {
        [Key]
        public string idinsumo{get;set;}
        public string nominsumo{get;set;}
        public string descinsumo{get;set;}
        public int cantinsumo{get;set;}
    }
}