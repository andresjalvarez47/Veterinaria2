using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Facturas
    {
        public int IDFacturacion { get; set; }
        public int Cuit { get; set; }
        public string Razon_Social { get; set; }
        public int Importe { get; set; }


        public ICollection<Detalle_Facturas> Detalle_Facturas { get; set; }


        //foreign key

        public Clientes Clientes { get; set; }
        public int IDCliente { get; set; }

       

        public Medio_de_Pago Medio_de_Pago { get; set; }
        public int IDMediopago { get; set; }


    }



    // metadata
    [MetadataType(typeof(CobranzasMetadata))]
    public partial class Facturas
    {
        public class CobranzasMetadata
        {
            [Key]
            public int IDFacturacion { get; set; }


            [StringLength(200)]
            
            public string Razon_Social { get; set; }


        }
    }
}