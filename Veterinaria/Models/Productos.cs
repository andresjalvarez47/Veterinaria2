using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Productos
    {

        public int IDProductos { get; set; }
        public String nombre { get; set; }
        public int precio { get; set; }


        //foreign key

        public Categoria_Productos Categoria_Productos { get; set; }
        public int IDCategoriaproductos { get; set; }


    }



    // metadata
    [MetadataType(typeof(TipoMetadata))]
    public partial class Productos
    {
        public class TipoMetadata
        {
            [Key]
            public int IDProductos { get; set; }


            [StringLength(200)]
            [Required]
            public string nombre { get; set; }


        }
    }



}