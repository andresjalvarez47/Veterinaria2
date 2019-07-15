using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public partial class Clientes
    {
        public int IDCliente { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public int Codigo_postal { get; set; }
        public string email { get; set; }

        public ICollection<Facturas> Cobranzas { get; set; }
        public ICollection<Mascota> Mascota { get; set; }
        

        //foreing key 



    }


    // metadata
    [MetadataType(typeof(ClientMetadata))]
    public partial class Clientes
    {
        public class ClientMetadata
        {
            [Key]
            public int IDCliente { get; set; }

            [Required]
            public int Dni { get; set; }
            [StringLength(200)]
            [Required]
            public string Nombre { get; set; }
            [StringLength(200)]
            [Required]
            public string Apellido { get; set; }
            [StringLength(200)]
            [Required]
            public string Direccion { get; set; }
            [StringLength(200)]
            [Required]
            public string Ciudad { get; set; }
            [StringLength(200)]
            [Required]
            public string Provincia { get; set; }

            [Required]
            public int Codigo_postal { get; set; }
            [StringLength(200)]
            public string email { get; set; }
        }
    }



}