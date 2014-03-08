using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CallCenter.Models
{
    public class Averia
    {
        [ScaffoldColumn(false)]
        public int AveriaID { get; set; }

        [Required, StringLength(100), Display(Name = "Nombre")]
        public string AveriaNombre { get; set; }

        [Required, StringLength(10000), Display(Name = "Averia Descripcion"), DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrecio { get; set; }

        public int? CategoriaID { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}