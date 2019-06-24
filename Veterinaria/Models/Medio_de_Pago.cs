using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Medio_de_Pago
    {

        public int IDMediopago { get; set; }
        public string Nombre { get; set; }

        public ICollection<Cobranzas> Cobranzas { get; set; }

    }


    // metadata
    [MetadataType(typeof(medioMetadata))]
    public partial class Medio_de_Pago
    {
        public class medioMetadata
        {
            [Key]
            public int IDMediopago { get; set; }


            [StringLength(200)]
            [Required]
            public string Nombre { get; set; }
            

        }
    }


}