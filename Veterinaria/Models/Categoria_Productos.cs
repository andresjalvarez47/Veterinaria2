using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Categoria_Productos
    {

        public int IDCategoriaproductos { get; set; }
        public String nombre { get; set; }


        public ICollection<Productos> Productos { get; set; }


    }


    // metadata
    [MetadataType(typeof(TipoMetadata))]
    public partial class Categoria_Productos
    {
        public class TipoMetadata
        {
            [Key]
            public int IDCategoriaproductos { get; set; }


            [StringLength(200)]
            [Required]
            public string nombre { get; set; }


        }
    }


}