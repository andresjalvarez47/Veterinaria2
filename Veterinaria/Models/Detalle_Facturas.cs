using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Detalle_Facturas
    {
        public int IDdetallefacturas { get; set; }



        //foreign key

        public Facturas Facturas { get; set; }
        public int IDFacturacion { get; set; }

        public Productos Productos { get; set; }
        public int IDProductos { get; set; }




    }



    // metadata
    [MetadataType(typeof(TipoMetadata))]
    public partial class Detalle_Facturas
    {
        public class TipoMetadata
        {
            [Key]
            public int IDdetallefacturas { get; set; }


           


        }
    }




}