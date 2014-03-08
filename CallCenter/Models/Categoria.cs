using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace CallCenter.Models
{
    public class Categoria
    {
        [ScaffoldColumn(false)]
        public int CategoriaID { get; set; }

        [Required, StringLength(100), Display(Name = "Nombre")]
        public string CategoriaNombre { get; set; }

        [Display(Name = "Averia Descripcion")]
        public string Descripcion { get; set; }

        public virtual ICollection<Averia> Averia { get; set; }

    }
}