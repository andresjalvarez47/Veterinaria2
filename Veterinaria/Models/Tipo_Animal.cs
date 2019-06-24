using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Tipo_Animal
    {

        public int IDtipoanimal { get; set; }
        public string Nombre { get; set; }

        public ICollection<Mascota> Mascota { get; set; }
    }

    // metadata
    [MetadataType(typeof(tipoanimalMetadata))]
    public partial class Tipo_Animal
    {
        public class tipoanimalMetadata
        {
            [Key]
            public int IDtipoanimal { get; set; }

        
            [StringLength(200)]
            [Required]
            public string Nombre { get; set; }
           
        }



    }
}